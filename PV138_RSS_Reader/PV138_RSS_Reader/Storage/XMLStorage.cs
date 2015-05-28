using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PV138_RSS_Reader.Extensions;
using PV138_RSS_Reader.Exceptions;
using System.IO;

namespace PV138_RSS_Reader.Storage
{
    /// <summary>
    /// XML suborove ulozisko dat
    /// </summary>
    class XMLStorage : IStorageManager
    {
        private string Uri { get; set; }
        private XDocument Doc { get; set; }
        
        /// <summary>
        /// Zkonstruuje XML Storage. Ak subor na uri neexistuje, pokusi sa ho vytvorit.
        /// </summary>
        /// <param name="uri">Uri XML suboru databazy</param>
        public XMLStorage(string uri)
        {
            Uri = uri;

            try
            {
                Doc = XDocument.Load(Uri);
            }
            catch (FileNotFoundException)
            {
                CreateXML();
                Doc = XDocument.Load(Uri);
            }

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(Save);

            if (!Doc.ValidateStringXSD(Properties.Resources.DATABASE_XSD)) {
                throw new FormatException("Database is corrupt!");
            }
        }

        /// <summary>
        /// Vrati zoznam vsetkych prihlasenych feedov
        /// </summary>
        /// <returns>Zoznam feedov</returns>
        public List<IFeed> GetFeeds()
        {
            return Doc.Root.Descendants("feed").Select(CreateFeed).ToList<IFeed>();
        }

        /// <summary>
        /// Vrati zoznam vsetkych clankov pre dany feed
        /// </summary>
        /// <param name="feed">Feed</param>
        /// <returns>Zoznam clankov vo feede</returns>
        public List<IArticle> GetArticles(IFeed feed)
        {
            return GetFeedInXML(feed)
                .Descendants("articles")
                .Descendants("article")
                .Select(article => CreateArticle(article, feed))
                .ToList<IArticle>();
        }

        /// <summary>
        /// Prida novy feed
        /// </summary>
        /// <param name="feed">Feed</param>
        public void AddFeed(IFeed feed)
        {
            // Test ci uz feed nie je ulozeny
            if (Doc.Descendants("feed").Count(oneFeed => oneFeed.Descendants("url").First().Value == feed.FeedURL) > 0)
                throw new InformUserException("Feed" + feed.Title + " již odeberáte");

            Doc.Root.Add
            (
                new XElement
                (
                    "feed",

                    new XElement("url", feed.FeedURL),
                    new XElement("title", feed.Title),
                    new XElement("main-link", feed.MainPageLink),
                    new XElement("description", feed.Description),
                    new XElement("articles")
                )
            );
        }
        
        /// <summary>
        /// Odstrani feed
        /// </summary>
        /// <param name="feed">Feed</param>
        public void RemoveFeed(IFeed feed)
        {
            Doc.Descendants("feed-link").Where(link => link.Attribute("url").Value.Equals(feed.FeedURL)).Remove();

            GetFeedInXML(feed).Remove();
        }

        /// <summary>
        /// Prida vsetky clanky z kolekcie do feedu
        /// </summary>
        /// <param name="articles">Kolekcia clankov</param>
        /// <param name="feed">Feed, ktoremu sa clanky maju priradit</param>
        public void AddArticles(IEnumerable<IArticle> articles, IFeed feed)
        {
            GetFeedInXML(feed).Descendants("articles").First().Add
            (
                articles.Select(article => 
                {
                    return new XElement
                    (
                        "article",

                        new XElement("title", article.Title),
                        new XElement("url", article.URL),
                        new XElement("description", article.Description),
                        new XElement("pubdate", article.PubDate.ToString("o")),

                        new XAttribute("read", "false"),
                        new XAttribute("starred", "false")
                    );
                }).ToArray()
            );
        }

        /// <summary>
        /// Zmeni ohviezdickovanost clanku
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma zmenit</param>
        public void SetStarred(IArticle article, bool setTo)
        {
            GetArticleInXML(article).Attribute("starred").Value = setTo.ToString().ToLower();
        }

        /// <summary>
        /// Zmeni precitanost clanku
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma zmenit</param>
        public void SetRead(IArticle article, bool setTo)
        {
            GetArticleInXML(article).Attribute("read").Value = setTo.ToString().ToLower();
        }

        /// <summary>
        /// Vrati zoznam vsetkych kategorii
        /// </summary>
        /// <returns>Zoznam kategorii</returns>
        public List<Category> GetCategories()
        {
            return Doc.Descendants("category").Select(category =>
            {
                var feedUrls = category
                    .Descendants("feeds")
                    .Descendants("feed-link")
                    .Select(feed => feed.Attribute("url").Value)
                    .ToList();

                return new Category
                (
                    Doc.Descendants("feed")
                    .Where
                    (
                        feed => feedUrls.Contains(feed.Descendants("url").First().Value)
                    )
                    .Select(CreateFeed).ToList(),

                    category.Descendants("name").First().Value,
                    Convert.ToInt32(category.Attribute("id").Value)
                );
            }).ToList<Category>();
        }

        /// <summary>
        /// Prida novu kategoriu
        /// </summary>
        /// <param name="category">Kategoria</param>
        public void AddCategory(Category category)
        {
            int useId = 0;

            if (Doc.Descendants("category").Count() > 0)
                useId = Doc.Descendants("category").Max(oneCategory => Convert.ToInt32(oneCategory.Attribute("id").Value)) + 1;

            Doc.Root.Add
            (
                new XElement
                (
                    "category",

                    new XElement("name", category.Name),
                    new XElement
                    (
                        "feeds",

                        category.Feeds.Select
                        (
                            feed => new XElement("feed-link", new XAttribute("url", feed.FeedURL))
                        )
                    ),

                    new XAttribute("id", useId)
                )
            );

            category.ID = useId;
        }

        /// <summary>
        /// Odstrani kategoriu
        /// </summary>
        /// <param name="category">Kategoria</param>
        public void RemoveCategory(Category category)
        {
            GetCategoryInXML(category).Remove();
        }

        /// <summary>
        /// Prida feed do kategorie
        /// </summary>
        /// <param name="category">kategoria</param>
        /// <param name="feed">feed</param>
        public void AddFeedToCategory(Category category, IFeed feed)
        {
            if (Doc
                .Descendants("category")
                .Where(cat => cat.Attribute("id").Value.Equals(category.ID.ToString()))
                .Descendants("feed-link")
                .Count(feedlink => feedlink.Attribute("url").Value.Equals(feed.FeedURL)) > 0
              )
                throw new InformUserException("Feed "+ feed.Title +"se jiz nachazi v kategorii "+category.Name);

            GetCategoryInXML(category).Descendants("feeds").First().Add(new XElement("feed-link", new XAttribute("url", feed.FeedURL)));
        }

        /// <summary>
        /// Odstrani feed z kategorie
        /// </summary>
        /// <param name="category">Kategoria</param>
        /// <param name="feed">Feed</param>
        public void RemoveFeedFromCategory(Category category, IFeed feed)
        {
            GetCategoryInXML(category).Descendants("feeds").Elements().First(feedlink => feedlink.Attribute("url").Value.Equals(feed.FeedURL)).Remove();
        }

        /// <summary>
        /// Premenuje kategoriu
        /// </summary>
        /// <param name="category">kategoria</param>
        /// <param name="name">nove meno</param>
        public void RenameCategory(Category category, string name)
        {
            GetCategoryInXML(category).Descendants("name").First().Value = name;
        }

        /// <summary>
        /// Vyhlada clanky, ktore maju v nadpise alebo popise frazu <paramref name="phrase"/>
        /// </summary>
        /// <param name="phrase">Vyhladavana fraza</param>
        /// <returns>Zoznam clankov</returns>
        public List<IArticle> Search(string phrase)
        {
            return GetFeeds().SelectMany(feed =>
            {
                return GetArticles(feed).Where(article => article.Identificator.ToLower().RemoveDiacritics().Contains(phrase.ToLower().RemoveDiacritics()));
            }).ToList();
        }


        /// <summary>
        /// Z XElementu pre clanok vytvori IArticle
        /// </summary>
        /// <param name="article">XElement clanku</param>
        /// <param name="feed">Feed clanku</param>
        /// <returns>IArticle</returns>
        private IArticle CreateArticle(XElement article, IFeed feed)
        {
            var ret = new Article
                    (
                        article.Descendants("title").First().Value,
                        article.Descendants("url").First().Value,
                        article.Descendants("description").First().Value,
                        DateTime.Parse(article.Descendants("pubdate").First().Value),
                        feed
                    );

            ret.Read = Convert.ToBoolean(article.Attribute("read").Value);
            ret.Starred = Convert.ToBoolean(article.Attribute("starred").Value);

            return ret;
        }

        /// <summary>
        /// Z XElementu pre feed vytvori IFeed
        /// </summary>
        /// <param name="feed">XElement feedu</param>
        /// <returns>IFeed</returns>
        private IFeed CreateFeed(XElement feed)
        {
            return new Feed
                (
                    feed.Descendants("url").First().Value,
                    feed.Descendants("title").First().Value,
                    feed.Descendants("main-link").First().Value,
                    feed.Descendants("description").First().Value
                );
        }

        /// <summary>
        /// Najde a vrati XElement daneho feedu
        /// </summary>
        /// <param name="feed">Feed</param>
        /// <returns>XElement feedu</returns>
        private XElement GetFeedInXML(IFeed feed)
        {
            return Doc.Descendants("feed")
                .Where(oneFeed => oneFeed.Descendants("url").First().Value.Equals(feed.FeedURL)).First();
        }

        /// <summary>
        /// Najde a vrati XElement daneho clanku
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <returns>XElement clanku</returns>
        private XElement GetArticleInXML(IArticle article)
        {
            return Doc.Descendants("feed")
                .Descendants("articles")
                .Descendants("article")
                .Where(oneArticle =>
                    oneArticle.Descendants("title").First().Value.Equals(article.Title) &&
                    oneArticle.Descendants("url").First().Value.Equals(article.URL) &&
                    oneArticle.Descendants("description").First().Value.Equals(article.Description)
                ).First();
        }

        /// <summary>
        /// Najde a vrati XElement danej kategorie
        /// </summary>
        /// <param name="category">Kategoria</param>
        /// <returns>XElement kategorie</returns>
        private XElement GetCategoryInXML(Category category)
        {
            if (category.ID == null)
                throw new ArgumentException("Kategorie " + category.Name + " jeste nebyla pridana do uloziste.");

            return Doc
                .Descendants("category")
                .Where(oneCategory => Convert.ToInt32(oneCategory.Attribute("id").Value) == category.ID)
                .First();
        }

        /// <summary>
        /// Ulozi databazu do suboru na disk. Tato funkcia je volana pri ukonceni aplikacie.
        /// </summary>
        private void Save(object sender, EventArgs e)
        {
            Doc.Save(Uri);
        }

        /// <summary>
        /// Vytvori prazdnu databazu
        /// </summary>
        private void CreateXML()
        {
            File.WriteAllText(Uri, Properties.Resources.BLANK_DATABASE_XML);
        }
    }
}
