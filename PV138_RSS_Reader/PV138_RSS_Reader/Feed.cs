using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public class Feed : IFeed
    {
        public string Title { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

        public DateTime LastBuildDate { get; set; }


        public Feed (string title, string url, string description, DateTime lastBuildDate)
        {
            if (title == null || url == null || description == null)
            {
                throw new ArgumentException("Couldn't create new feed; title, url and description are required");
            }

            this.Title = title;
            this.URL = url;
            this.Description = description;
            this.LastBuildDate = lastBuildDate;
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }

    }
}
