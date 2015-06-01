using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PV138_RSS_Reader.Storage;
using System.IO;

namespace PV138_RSS_Reader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // testovaci kod, v debuggeri vidno hodnoty 
            /*
            var manager = new FeedManager(new DUMMYInMemoryStorage());
            manager.SubscribeToURL("http://deoxy.org/koans?rss=1"); // Vzdy je tam ina random vec
            manager.SubscribeToURL("http://en.wikipedia.org/w/api.php?hidebots=1&days=7&limit=50&hidewikidata=1&action=feedrecentchanges&feedformat=atom");

            var feeds = manager.Feeds;
            for (int i = 0; i < 2; i++)
            {
                foreach (var feed in feeds)
                {
                    var articles = manager.Articles(feed); // Breakpoint sem; potom step over, articles ma 1 clanok.
                                                              // Continue, step over a articles ma 2 clanky

                }
                manager.UpdateAllFeeds();
            }

            feeds = manager.Feeds;
            foreach (var feed in feeds)
            {
                manager.Unsubscribe(feed);
            }
            feeds = manager.Feeds;
            *//*
            string uri = @"../testAAAAAAAAAAAAAAAAAAAAAAAa.xml";
            XMLStorage storage;
            storage = new XMLStorage(uri);
            List<Category> categories = new List<Category>()
            {
            new Category(new List<IFeed>(), "category1", 1),
            new Category(new List<IFeed>(), "category2", 2),
            new Category(new List<IFeed>(), "category3", 3)
            };

             foreach (Category cat in categories)
            {
                storage.AddCategory(cat);
            }
            List<Category> inDatabase = storage.GetCategories();
            //CollectionAssert.AreEqual(categories, storage.GetCategories());

             for (int i = 0; i < categories.Count; i++)
             {
               /*  Console.WriteLine("Original: {0}, database: {1}", categories[i].ToString(), inDatabase[i].ToString());
                 Console.WriteLine("OriginalID: {0}, databaseID: {1}", categories[i].Feeds.ToString(), inDatabase[i].Feeds.ToString());
                 Console.WriteLine("toString: "+categories[i].ToString().Equals(inDatabase[i].ToString()));
                 Console.WriteLine("names: "+categories[i].Name.Equals(inDatabase[i].Name));
                 Console.WriteLine(categories[i].ID.Equals(inDatabase[i].ID));*/
            /*     Console.WriteLine("Feeds: "+categories[i].Feeds.Equals(inDatabase[i].Feeds));
                 Console.WriteLine(categories[i].Feeds.ToString().Equals(inDatabase[i].Feeds.ToString()));

             }


                 File.Delete(uri);
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
