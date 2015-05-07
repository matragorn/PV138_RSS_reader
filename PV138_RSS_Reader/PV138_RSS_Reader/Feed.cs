using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public class Feed : IFeed
    {
        public string ID { get; private set; }

        public string Title { get; set; }

        public string WebLink { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

        public DateTime LastBuildDate { get; set; }


        public Feed (string id, string title, string url, string description)
        {
            if (id == null || title == null || url == null || description == null)
            {
                throw new ArgumentException("Couldn't create new feed; id, title, url and description are required");
            }

            this.ID = id;
            this.Title = title;
            this.WebLink = url;
            this.Description = description;
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }

        public override bool Equals (object obj)
        {
            return obj is IFeed && ((IFeed)obj).ID == this.ID;
        }
    
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
