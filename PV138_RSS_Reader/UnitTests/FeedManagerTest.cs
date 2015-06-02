using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader;
using PV138_RSS_Reader.Storage;
using System.IO;
using System.Collections.Generic;
using PV138_RSS_Reader.Exceptions;

namespace UnitTests
{
    [TestClass]
    public class FeedManagerTest
    {
        string uri = @"../test.xml";
        XMLStorage storage;
        List<IFeed> feedList;
        List<Category> categories;
        List<Article> articles;
        FeedManager manager;

        

        [TestMethod]
        public void FeedManagerFeeds(){

            CollectionAssert.AreEqual(feedList, manager.Feeds);

        }

        [TestMethod]
        public void FeedManagerUnsubcribe()
        {
            List<IFeed> unsubcribedFeed = new List<IFeed>();
            for(int i = 0; i < feedList.Count-1; i++){
                unsubcribedFeed.Add(feedList[i]);
            }

            manager.Unsubscribe(feedList[feedList.Count-1]);
            CollectionAssert.AreEqual(unsubcribedFeed, manager.Feeds);

            foreach(Feed feed in unsubcribedFeed){
                manager.Unsubscribe(feed);
            }

            CollectionAssert.AreEqual(new List<IFeed>(), manager.Feeds);
        }

        [TestMethod]
        public void FeedManagerArticlesInFeed()
        {
            
            CollectionAssert.AreEqual(new List<Article>() { articles[0], articles[1], articles[2] }, manager.Articles(feedList[0]));
            CollectionAssert.AreEqual(new List<Article>() { articles[7], articles[8] }, manager.Articles(feedList[3]));

            CollectionAssert.AreEqual(new List<Article>(), manager.Articles(feedList[4]));
        }

        [TestMethod]
        public void FeedManagerReaded()
        {
            manager.SetRead(articles[0], true);
            Assert.AreEqual(true, manager.Articles(feedList[0])[0].Read);
            Assert.AreNotEqual(true, manager.Articles(feedList[0])[1].Read);
            
        }

        [TestMethod]
        public void FeedManagerStarred()
        {
            manager.SetStarred(articles[0], true);
            Assert.AreEqual(true, manager.Articles(feedList[0])[0].Starred);
            Assert.AreNotEqual(true, manager.Articles(feedList[0])[1].Starred);

        }

        [TestMethod]
        public void FeedManagerSearch()
        {
            CollectionAssert.AreEqual(new List<Article>(), manager.Search("Superman"));
            CollectionAssert.AreEqual(articles, manager.Search("Title"));

            Assert.AreEqual(1, manager.Search("5").Count);
        }



        [TestMethod]
        [ExpectedException(typeof(InformUserException))]
        public void FeedManagerDoubleAddOneFeed()
        {
            manager.AddFeedToCategory(categories[0], feedList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FeedManagerDoubleUnsubcribeOneFeed()
        {
            manager.Unsubscribe(feedList[0]);
            manager.Unsubscribe(feedList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FeedManagerNullStorage()
        {
            manager = new FeedManager(null);
        }

        [TestInitialize]
        public void Init()
        {
            storage = new XMLStorage(uri);

            feedList = new List<IFeed>();  
            articles = new List<Article>();
            for(int i = 1; i < 10; i++){
                articles.Add(new Article("Title"+i.ToString(),"www.url"+i.ToString()+".com", "Description"+i.ToString(),new DateTime(1999+i,i,i)));
                if(i < 6) feedList.Add(new Feed("www.someUrl" + i.ToString() + ".com", "title" + i.ToString(), "www.link" + i.ToString() + ".com", "description" + i.ToString()));

            }

            categories = new List<Category>(){
                new Category(new List<IFeed>(), "category1", 1),
                new Category(new List<IFeed>(), "category2", 2)
            };

            foreach(Feed feed in feedList){
                storage.AddFeed(feed);
            }

            storage.AddArticles(new List<Article>(){articles[0],articles[1],articles[2]}, feedList[0]);
            storage.AddArticles(new List<Article>(){articles[3],articles[4]}, feedList[1]);
            storage.AddArticles(new List<Article>(){articles[5],articles[6]}, feedList[2]);
            storage.AddArticles(new List<Article>(){articles[7],articles[8]}, feedList[3]);


            foreach(Category cat in categories){
                storage.AddCategory(cat);
            }


            storage.AddFeedToCategory(categories[0], feedList[0]);
            storage.AddFeedToCategory(categories[0], feedList[1]);
            storage.AddFeedToCategory(categories[1], feedList[2]);

            
            manager = new FeedManager(storage);
        }
        
        [TestCleanup]
        public void CleanUp()
        {             
            File.Delete(uri);
        }
    }
}
