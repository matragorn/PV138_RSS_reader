using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PV138_RSS_Reader.Validation;
using System.IO;

namespace PV138_RSS_Reader.Storage
{
    class XMLStorage : IStorageManager
    {
        private string Uri { get; set; }
        private XDocument Doc { get; set; }

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

            if (!Doc.ValidateStringXSD(Properties.Resources.DATABASE_XSD))
                throw new FormatException("Database is corrupt!");
        }

        public List<IFeed> GetFeeds()
        {
            return Doc.Descendants("feed").Select(CreateFeed).ToList<IFeed>();
        }

        public List<IArticle> GetArticles(IFeed feed)
        {
            return GetFeedInXML(feed)
                .Descendants("articles")
                .Descendants("article")
                .Select(article => CreateArticle(article, feed))
                .ToList<IArticle>();
        }

        public void AddFeed(IFeed feed)
        {
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

        public void RemoveFeed(IFeed feed)
        {
            GetFeedInXML(feed).Remove();
        }

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

        public IArticle GetArticleByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public void SetStarred(IArticle article, bool setTo)
        {
            GetArticleInXML(article).Attribute("starred").Value = setTo.ToString().ToLower();
        }

        public void SetRead(IArticle article, bool setTo)
        {
            GetArticleInXML(article).Attribute("read").Value = setTo.ToString().ToLower();
        }

        public List<Category> GetCategories()
        {
            return Doc.Descendants("category").Select(category =>
            {
                var feedUrls = category
                    .Descendants("feeds")
                    .Descendants("feed")
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

                    Convert.ToInt32(category.Attribute("id").Value)
                );
            }).ToList<Category>();
        }

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
                            feed => new XElement("feed", new XAttribute("url", feed.FeedURL))
                        )
                    ),

                    new XAttribute("id", useId)
                )
            );
        }

        public void RemoveCategory(Category category)
        {
            GetCategoryInXML(category).Remove();
        }


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

        private XElement GetFeedInXML(IFeed feed)
        {
            return Doc.Descendants("feed")
                .Where(oneFeed => oneFeed.Descendants("url").First().Value.Equals(feed.FeedURL)).First();
        }

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

        private XElement GetCategoryInXML(Category category)
        {
            if (category.ID == null)
                throw new ArgumentException("Kategorie " + category.Name + " jeste nebyla pridana do uloziste.");

            return Doc
                .Descendants("category")
                .Where(oneCategory => Convert.ToInt32(oneCategory.Attribute("id").Value) == category.ID)
                .First();
        }

        private void Save(object sender, EventArgs e)
        {
            Doc.Save(Uri);
        }

        private void CreateXML()
        {
            File.WriteAllText(Uri, Properties.Resources.BLANK_DATABASE_XML);
        }
    }
}
