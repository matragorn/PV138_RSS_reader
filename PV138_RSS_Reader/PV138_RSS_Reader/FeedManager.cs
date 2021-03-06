﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PV138_RSS_Reader.Extensions;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Hlavny spravca logiky programu
    /// </summary>
    public class FeedManager
    {
        public IStorageManager Storage { get; set; }

        /// <summary>
        /// Vrati List vsetkych prihlasenych feedov
        /// </summary>
        /// <returns>List prihlasenych feedov</returns>
        public List<IFeed> Feeds
        {
            get { return Storage.GetFeeds(); }
        }

        /// <summary>
        /// Vytvori novy FeedManager
        /// </summary>
        /// <param name="storage">Ulozisko, ktore sa ma pouzit</param>
        public FeedManager(IStorageManager storage)
        {
            if (storage == null)
                throw new ArgumentNullException("storage");

            Storage = storage;
        }

        /// <summary>
        /// Prihlasi sa na odber na <paramref name="url"/>
        /// </summary>
        /// <param name="url">Url feedu na spracovanie</param>
        /// <returns>Nacitany feed</returns>
        public IFeed SubscribeToURL(string url)
        {
            XDocument doc = XDocument.Parse(new WebClient().DownloadStringAwareOfEncoding(url).Trim());

            Feed feed = (Feed)FeedReader.CreateFeed(doc, url);

            Storage.AddFeed(feed);

            UpdateFeed(feed);

            return feed;
        }

        /// <summary>
        /// Odhlasi sa z odberu
        /// </summary>
        /// <param name="feed">Feed, ktory sa ma vymazat</param>
        public void Unsubscribe(IFeed feed)
        {
            Storage.RemoveFeed(feed);
        }

        /// <summary>
        /// Vrati List clankov pre dany feed
        /// </summary>
        /// <param name="feed">feed</param>
        /// <returns>Zoznam clankov vo feede</returns>
        public List<IArticle> Articles(IFeed feed)
        {
            return Storage.GetArticles(feed);
        }
        
        /// <summary>
        /// Aktualizuje feedy
        /// </summary>
        public void UpdateAllFeeds()
        {
            foreach (var feed in Feeds)
            {
                UpdateFeed(feed);
            }
        }

        /// <summary>
        /// Aktualizuje jeden feed
        /// </summary>
        /// <param name="feed">Feed, ktory sa ma aktualizovat</param>
        public void UpdateFeed(IFeed feed)
        {
            var c = new WebClient();
            //c.Encoding = Encoding.UTF8;

            XDocument doc = XDocument.Parse(c.DownloadStringAwareOfEncoding(feed.FeedURL));

            var newArticles = FeedReader.GetArticles(doc).Except(Storage.GetArticles(feed), new ArticleComparer());

            Storage.AddArticles(newArticles, feed);
        }

        /// <summary>
        /// Zmeni clanku hodnotu precitania
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma zmenit</param>
        public void SetRead(IArticle article, bool setTo)
        { 
            Storage.SetRead(article, setTo);
        }

        /// <summary>
        /// Zmeni clanku hodnotu ohviezdickovania
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma zmenit</param>
        public void SetStarred(IArticle article, bool setTo)
        {
            Storage.SetStarred(article, setTo);
        }

        /// <summary>
        /// Vyhlada clanky, ktore maju v nadpise alebo popise frazu <paramref name="phrase"/>
        /// </summary>
        /// <param name="phrase">Vyhladavana fraza</param>
        /// <returns>Zoznam clankov</returns>
        public List<IArticle> Search(string phrase)
        {
            return Storage.Search(phrase);
        }

        /// <summary>
        /// vrátí všechny feedy kde je alespon jeden clane neprecteny
        /// </summary>
        /// <returns></returns>
        internal List<IFeed> getUnreadFeeds()
        {
            return Feeds.Where(x => Storage.GetArticles(x).Exists(y => y.Read == false)).ToList();
        }

        /// <summary>
        /// vrati vsechny feedy kde je alespon jeden clanek s hvězdickou
        /// </summary>
        /// <returns></returns>
        internal List<IFeed> getStarredFeeds()
        {
            return Feeds.Where(x => Storage.GetArticles(x).Exists(y => y.Starred)).ToList();
        }

        /// <summary>
        /// Vrati zoznam vsetkych kategorii
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            return Storage.GetCategories();
        }

        /// <summary>
        /// Prida kategoriu
        /// </summary>
        /// <param name="category"></param>
        public void AddCategory(Category category)
        {
            Storage.AddCategory(category);
        }

        /// <summary>
        /// Odstrani kategoriu
        /// </summary>
        /// <param name="category"></param>
        public void RemoveCategory(Category category)
        {
            Storage.RemoveCategory(category);
        }

        /// <summary>
        /// Prida feed do kategorie
        /// </summary>
        /// <param name="category">kategoria, do které se má feed přidat</param>
        /// <param name="feed">feed který se má přidat</param>
        /// <exception cref="InformUserException">Vyhazuje se když se nepovede přidat daný feed do kategorie</exception>
        public void AddFeedToCategory(Category category, IFeed feed)
        {
            Storage.AddFeedToCategory(category, feed);

            category.Feeds.Add(feed);
        }

        /// <summary>
        /// Odstrani feed z kategorie
        /// </summary>
        /// <param name="category">Kategoria</param>
        /// <param name="feed">Feed</param>
        public void RemoveFeedFromCategory(Category category, IFeed feed)
        {
            Storage.RemoveFeedFromCategory(category, feed);
            category.Feeds.Remove(feed);
        }

        /// <summary>
        /// Premenuje kategoriu
        /// </summary>
        /// <param name="category">kategoria</param>
        /// <param name="name">nove meno</param>
        public void RenameCategory(Category category, string name)
        {
            Storage.RenameCategory(category, name);
            category.Name = name;
        }



    }
}
