using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            */



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
