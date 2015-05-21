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
    }
}
