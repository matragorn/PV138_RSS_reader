using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public class Category
    {
        public string Name { get; set; }
        public List<IFeed> Feeds { get; set; }


        public Category()
        {
            Feeds = new List<IFeed>();
        }
        public Category(List<IFeed> feeds)
        {
            Feeds = feeds;
        }

        public void AddFeed(IFeed feed)
        {
            Feeds.Add(feed);
        }
        public void RemoveFeed(IFeed feed)
        {
            Feeds.Remove(feed);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
