using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class CategoryTest
    {

        [TestMethod]
        public void CategoryDifferentConstructors()
        {
            Category category1 = new Category(null);

            Category category2 = new Category();

            Category category3 = new Category(null, "Stars", 1);

        }

        [TestMethod]
        public void CategoryAddRemoveFeed()
        {
            List<IFeed> feedList = new List<IFeed>();
            Feed feed1 = new Feed("www.url.com", "title", "www.link.com", "something");
            Feed feed2 = new Feed("www.url2.com", "title2", "www.link2.com", "something2");
            Feed feed3 = new Feed("www.url3.com", "title3", "www.link3.com", "something3");

            feedList.Add(feed1);
            feedList.Add(feed2);

            Category category = new Category(feedList);

            category.RemoveFeed(feed3);

            Assert.AreEqual(2, category.Feeds.Count);

            category.AddFeed(feed3);

            Assert.AreEqual(3, category.Feeds.Count);

            category.RemoveFeed(feed2);

            Assert.AreEqual(2, category.Feeds.Count);

        }

    }
}
