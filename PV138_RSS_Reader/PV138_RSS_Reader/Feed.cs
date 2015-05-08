using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public class Feed : IFeed
    {
        public string Title { get; private set; }

        public string MainPageLink { get; private set; }

        public string FeedURL { get; private set; }

        public string Description { get; private set; }


        public Feed (string url, string title, string mainLink, string description)
        {
            if (url == null || title == null)
            {
                throw new ArgumentException("Nepodarilo sa vytvorit novy feed");
            }

            this.FeedURL = url;
            this.Title = title;
            this.MainPageLink = mainLink;
            this.Description = description;
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }

        public override bool Equals (object obj)
        {
            return obj is IFeed && ((IFeed)obj).FeedURL == this.FeedURL;
        }
    
        public override int GetHashCode()
        {
            return FeedURL.GetHashCode();
        }

    }
}
