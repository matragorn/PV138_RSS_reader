using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    class Article : IArticle
    {
        public string Title { get; private set; }

        public string URL { get; private set; }

        public string Description { get; private set; }

        public DateTime PubDate { get; private set; }

        public bool Read { get; set; }

        public IFeed ParentFeed { get; set; }

        public bool Starred { get; set; }

        /// <summary>
        /// vraci identifikator articlu pro porovnavani v metode equals
        /// </summary>
        public string Identificator
        {
            get { return this.Title + this.URL + this.Description; }
            set { /*nelze nastavit*/}
        }
        
       
        public Article(string title, string url, string description, DateTime pubDate, IFeed feed):this(title,url,description,pubDate)
        {
            ParentFeed = feed;
        }
        public Article(string title, string url, string description, DateTime pubDate)
        {
            Read = false;
            Starred = false;
            Description = description;
            PubDate = pubDate;
            Title = title;
            URL = url;
        }

        public string[] ToArray()
        {
           return new string[] { PubDate.ToString(), Title, (ParentFeed==null)?"null":ParentFeed.ToString() };
        }


        public override bool Equals(object obj)
        {
            return obj is IArticle && ((IArticle)obj).Identificator == this.Identificator;
        }

        public override int GetHashCode()
        {
            return this.Identificator.GetHashCode();
        }
    }
}
