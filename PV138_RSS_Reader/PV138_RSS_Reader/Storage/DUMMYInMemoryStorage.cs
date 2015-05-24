using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Docasny storage, ktory nikam zmeny neuklada
    /// </summary>
    class DUMMYInMemoryStorage : IStorageManager
    {
        private Dictionary<IFeed, List<IArticle>> data;
        private List<Category> categories;

        public DUMMYInMemoryStorage()
        {
            data = new Dictionary<IFeed, List<IArticle>>();
            //pro testovací účely, až bude databaze načte se z databaze
            categories = new List<Category> { new Category { Name = "Zprávy" }, new Category { Name = "Blbosti" }, new Category { Name = "Ostatni" } };
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public List<IFeed> GetFeeds()
        {
            return data.Keys.ToList();
        }

        public IArticle GetArticleByTitle(string title)
        {
            foreach (var feed in GetFeeds())
            {
                foreach (var article in GetArticles(feed))
                {
                    if (article.Title == title)
                    {
                        return article;
                    }
                }
            }

            throw new KeyNotFoundException("Neexistuje clanok s nadpisom " + title);
        }

        public List<IArticle> GetArticles(IFeed feed)
        {
            if (feed == null)
            {
                return new List<IArticle>();
            }
            return data[feed];
        }

        public void AddFeed(IFeed feed)
        {
            data.Add(feed, new List<IArticle>());
        }

        public void RemoveFeed(IFeed feed)
        {
            data.Remove(feed);
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void RemoveCategory(Category category)
        {
            categories.Remove(category);
        }

        public void AddArticles(IEnumerable<IArticle> articles, IFeed feed)
        {
            data[feed].InsertRange(0,articles);
        }

        public void SetStarred(IArticle article, bool setTo)
        {
            var articleComparer = new ArticleComparer();

            foreach (var feed in GetFeeds())
            {
                var articles = GetArticles(feed);
                if (articles.Contains(article))
                {
                    articles[articles.IndexOf(article)].Starred = setTo;
                }
            }


            // co takhle celou tuto metodu nahoře nahradit řádkem:
            // article.Starred = setTo; [Michael]
        }

        public void SetRead(IArticle article, bool setTo)
        {
            var articleComparer = new ArticleComparer();

            foreach (var feed in GetFeeds())
            {
                var articles = GetArticles(feed);
                if (articles.Contains(article))
                {
                    articles[articles.IndexOf(article)].Read = setTo;
                }
            }

            // co takhle celou tuto metodu nahoře nahradit řádkem:
            // article.Read = setTo; [Michael]

        }
    }
}
