using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader;

namespace UnitTests
{
    [TestClass]
    public class FeedTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullTitleGetException()
        {
            string FeedUrl = "www.someURL.com";
            string Title = null;
            string MainPageLink = "www.someWebAdress.com";
            string Description = "Amazing Feed!";

            Feed myFeed = new Feed(FeedUrl, Title, MainPageLink, Description);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullURLGetException()
        {
            string FeedUrl = null;
            string Title = "News";
            string MainPageLink = "www.someWebAdress.com";
            string Description = "Amazing Feed!";

            Feed myFeed = new Feed(FeedUrl, Title, MainPageLink, Description);
        }

        [TestMethod]
        public void EqualFeeds()
        {
            string FeedUrl = "www.someURL.com";
            string Title = "News";
            string MainPageLink = "www.someWebAdress.com";
            string Description = "Amazing Feed!";

            Feed feedOne = new Feed(FeedUrl, Title, MainPageLink, Description);
            Feed feedTwo = new Feed(FeedUrl, Title, MainPageLink, Description);

            Assert.AreEqual(true, feedOne.Equals(feedTwo));
            Assert.AreEqual(true, feedTwo.Equals(feedOne));            
        }

        [TestMethod]
        public void NotEqualFeeds()
        {
            string FeedUrlOne = "www.someURL.com";
            string FeedUrlTwo = "www.anotherURL.com";
            string Title = "News";
            string MainPageLink = "www.someWebAdress.com";
            string Description = "Amazing Feed!";

            Feed feedOne = new Feed(FeedUrlOne, Title, MainPageLink, Description);
            Feed feedTwo = new Feed(FeedUrlTwo, Title, MainPageLink, Description);

            Assert.AreNotEqual(true, feedOne.Equals(feedTwo));
            Assert.AreNotEqual(true, feedTwo.Equals(feedOne));
        }
    }
}
