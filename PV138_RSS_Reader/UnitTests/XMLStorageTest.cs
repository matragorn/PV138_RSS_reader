using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader.Storage;
using PV138_RSS_Reader;
using System.Collections.Generic;
using System.IO;
using PV138_RSS_Reader.Exceptions;

namespace UnitTests
{
    [TestClass]
    public class XMLStorageTest
    {
        string uri = @"../test.xml";
        XMLStorage storage;
        List<IFeed> feedList;
        List<Category> categories;


        
        [TestMethod]
        public void StorageAddRemoveSingleFeed(){
            //adding
            Assert.AreNotEqual(null, storage);

            storage.AddFeed(feedList[0]);
            Assert.AreEqual(1, storage.GetFeeds().Count);
          

            storage.RemoveFeed(feedList[0]);
            Assert.AreEqual(0, storage.GetFeeds().Count);

            
        }

        [TestMethod]
        [ExpectedException(typeof(PV138_RSS_Reader.Exceptions.InformUserException))]
        public void StorageSetSameFeed()
        {
            storage.AddFeed(feedList[0]);
            storage.AddFeed(feedList[0]);
        }

        [TestMethod]
        public void StorageAddListFeeds()
        {
            foreach(Feed feed in feedList){
                storage.AddFeed(feed);
            }
            Assert.AreEqual(5, storage.GetFeeds().Count);

            CollectionAssert.AreEqual(feedList,storage.GetFeeds());
            
        }

        [TestMethod]
        public void StorageCategories()
        {
           
            foreach (Category cat in categories)
            {
                storage.AddCategory(cat);
            }

            Assert.AreEqual(categories.Count, storage.GetCategories().Count);
          
            string newName =  "New name";
            storage.RenameCategory(categories[0], newName);

            Assert.AreEqual("New name", storage.GetCategories()[0].Name);

            storage.RemoveCategory(categories[0]);
            Assert.AreEqual(categories.Count - 1, storage.GetCategories().Count);

            

        }

        [TestMethod]
        public void StorageFeedsInCategories()
        {
            Category cat1 = categories[0];
            Category cat2 = categories[1];
            storage.AddCategory(cat1);
            storage.AddFeed(feedList[0]);

            storage.AddFeedToCategory(cat1, feedList[0]);
            Assert.AreEqual(1, storage.GetFeeds().Count);

            Assert.AreEqual(1, storage.GetCategories()[0].Feeds.Count);

            storage.RemoveFeedFromCategory(cat1, feedList[0]);
            Assert.AreEqual(1, storage.GetFeeds().Count);
            Assert.AreEqual(0, storage.GetCategories()[0].Feeds.Count);

            cat2.AddFeed(feedList[1]);
            cat2.AddFeed(feedList[2]);
            storage.AddCategory(cat2);

            Assert.AreEqual(2, storage.GetCategories().Count);

            Assert.AreEqual(cat1.ToString(), storage.GetCategories()[0].ToString());
            Assert.AreEqual(cat2.ToString(), storage.GetCategories()[1].ToString());

        }

        [TestMethod]
        public void StorageArticlesAdd()
        {
            List<Article> articles = InitArticles();
            IFeed feed = feedList[0];

            storage.AddFeed(feed);
            storage.AddArticles(articles, feed);
           
            CollectionAssert.AreEqual(articles, storage.GetArticles(feed));
            
      
        }

        [TestMethod]
        public void StorageArticlesSearch()
        {
            List<Article> articles = InitArticles();
            IFeed feed1 = feedList[0];
            IFeed feed2 = feedList[1];

            storage.AddFeed(feed1);

            Assert.AreEqual(0, storage.Search("Title").Count);

            storage.AddArticles(articles, feed1);

            CollectionAssert.AreEqual(articles, storage.Search("Title"));
            Assert.AreEqual(0, storage.Search("Shit").Count);

            storage.AddFeed(feed2);
            storage.AddArticles(articles, feed2);

            Assert.AreEqual(articles.Count * 2, storage.Search("Title").Count);
            Assert.AreEqual(2, storage.Search("Title1").Count);
                        
        }

        private List<Article> InitArticles()
        {
            List<Article> articles = new List<Article>();

            for(int i = 1; i < 5; i++){
                articles.Add(new Article("Title"+i.ToString(),"www.url"+i.ToString()+".com", "Description"+i.ToString(),new DateTime(1999+i,i,i)));
                
            }

            return articles;

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StorageAddFeedToInvalidCategory()
        {
            storage.AddFeedToCategory(categories[0], feedList[0]);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StorageRemoveFeedFromInvalidCategory()
        {
            storage.AddFeed(feedList[0]);
            storage.AddFeedToCategory(categories[0], feedList[0]);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StorageRemoveIvalidFeedFromCategory()
        {
            storage.AddCategory(categories[0]);
            storage.AddFeedToCategory(categories[0], feedList[0]);

            storage.RemoveFeedFromCategory(categories[0], feedList[1]);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StorageRemoveNotExistingCaterory()
        {
            storage.AddCategory(categories[0]);

            storage.RemoveCategory(categories[0]);
            storage.RemoveCategory(categories[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StorageRemoveNotExistingFeed()
        {
            storage.AddFeed(feedList[0]);

            storage.RemoveFeed(feedList[0]);
            storage.RemoveFeed(feedList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StorageRemoveNotExistingAtAllFeed()
        {
            storage.RemoveFeed(feedList[4]);
        }


        [TestInitialize]
        public void Init()
        {
            storage = new XMLStorage(uri); 
            categories = new List<Category>()
            {
                new Category(new List<IFeed>(), "category1", 1),
                new Category(new List<IFeed>(), "category2", 2),
                new Category(new List<IFeed>(), "category3", 3)
            };

            feedList = new List<IFeed>(){new Feed("www.someUrl1.com", "title1", "www.link1.com", "description1"),
                                          new Feed("www.someUrl2.com", "title2", "www.link2.com", "description2"),
                                          new Feed("www.someUrl3.com", "title3", "www.link3.com", "description3"),
                                          new Feed("www.someUrl4.com", "title4", "www.link4.com", "description4"),
                                          new Feed("www.someUrl5.com", "title5", "www.link5.com", "description5")
                                            };
        }
        
        [TestCleanup]
        public void CleanUp()
        {             
            File.Delete(uri);
        }
        
    }
}
