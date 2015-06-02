using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PV138_RSS_Reader;

namespace UnitTests
{
    [TestClass]
    public class ArticleTest
    {

        [TestMethod]
        public void ArticleEqualArticles()
        {
            string Title = "title";
            string Url = "www.someUrl.com";
            string Description = "bla";
            DateTime Time = new DateTime(2015, 5, 20);


            Article myArticle1 = new Article(Title, Url, Description, Time);
            Article myArticle2 = new Article(Title, Url, Description, Time);
            Article myArticle3 = new Article(Title, Url, Description, new DateTime(1999, 1, 1));

            Assert.AreEqual(true, myArticle1.Equals(myArticle2));
            Assert.AreEqual(true, myArticle2.Equals(myArticle1));
            Assert.AreEqual(true, myArticle1.Equals(myArticle3));


        }

        [TestMethod]
        public void ArticleNotEqualArticles()
        {
            string Title = "title";
            string AnotherTitle = "anotherTitle";
            string Url = "www.someUrl.com";
            string AnotherUrl = "anotherUrl";
            string Description = "bla";
            DateTime Time = new DateTime(2015, 5, 20);

            Article myArticle1 = new Article(Title, Url, Description, Time);
            Article myArticle2 = new Article(AnotherTitle, Url, Description, Time);
            Article myArticle3 = new Article(Title, AnotherUrl, Description, Time);

            Assert.AreNotEqual(true, myArticle1.Equals(myArticle2));
            Assert.AreNotEqual(true, myArticle2.Equals(myArticle1));
            Assert.AreNotEqual(true, myArticle2.Equals(myArticle3));
        }
    }
}
