using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader;
using PV138_RSS_Reader.Storage;
using System.IO;


namespace UnitTests
{
    [TestClass]
    public class FeedManagerOnlineTest
    {
        string uri = @"../test.xml";
        XMLStorage storage;
        FeedManager manager;

        [TestMethod]
        public void FeedManagerOnlineSub()
        {
            manager.SubscribeToURL("http://servis.lidovky.cz/rss.aspx?r=ln_domov");
            Assert.AreNotEqual(0, manager.Feeds.Count);
        }

        [TestMethod]
        public void FeedManagerOnlineUnsub()
        {
            manager.SubscribeToURL("http://servis.lidovky.cz/rss.aspx?r=ln_domov");
            manager.SubscribeToURL("http://servis.lidovky.cz/rss.aspx?r=ln_zahranici");
            IFeed feed = manager.Feeds[0];

            manager.Unsubscribe(manager.Feeds[0]);

            
            Assert.AreNotEqual(true, manager.Feeds.Contains(feed));


        }


        [TestMethod]
        [ExpectedException(typeof(System.Net.WebException))]
        public void FeedManagerOnlineBadUrl()
        {
            manager.SubscribeToURL("http://www.veryBadUrl.mum");
        }

        [TestInitialize]
        public void Init()
        {
            storage = new XMLStorage(uri);
            manager = new FeedManager(storage);

        }

        [TestCleanup]
        public void CleanUp()
        {
            File.Delete(uri);
        }
    }
}
