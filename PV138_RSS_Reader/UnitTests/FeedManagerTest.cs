using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader;

namespace UnitTests
{
    [TestClass]
    public class FeedManagerTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStorage()
        {
            FeedManager manager = new FeedManager(null);
        }


    }
}
