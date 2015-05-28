using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Feed
    /// </summary>
    public class Feed : IFeed
    {
        public string Title { get; private set; }

        public string MainPageLink { get; private set; }

        public string FeedURL { get; private set; }

        public string Description { get; private set; }

        /// <summary>
        /// Vytvori novy feed
        /// </summary>
        /// <param name="url">URL feedu</param>
        /// <param name="title">Nazov feedu</param>
        /// <param name="mainLink">Link na hlavnu stranku</param>
        /// <param name="description">Popis feedu</param>
        public Feed (string url, string title, string mainLink, string description)
        {
            if (url == null)
            {
                throw new ArgumentNullException("url", "Nepodarilo sa vytvorit novy feed");
            }
            if (title == null)
            {
                throw new ArgumentNullException("title", "Nepodarilo sa vytvorit novy feed");
            }

            this.FeedURL = url;
            this.Title = title;
            this.MainPageLink = mainLink;
            this.Description = description;
        }

        public override string ToString()
        {
            //TODO:
            return Title;
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
