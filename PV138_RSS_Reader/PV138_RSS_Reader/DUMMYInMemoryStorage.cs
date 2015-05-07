﻿using System;
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

        public DUMMYInMemoryStorage()
        {
            data = new Dictionary<IFeed, List<IArticle>>();
        }


        public List<IFeed> GetFeeds()
        {
            return data.Keys.ToList();
        }

        public List<IArticle> GetArticles(IFeed feed)
        {
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

        public void AddArticles(IEnumerable<IArticle> articles, IFeed feed)
        {

            foreach (var article in articles)
            {
                data[feed].Add(article);
            }

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
        }
    }
}
