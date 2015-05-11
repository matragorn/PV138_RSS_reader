﻿using System;
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

        public bool Starred { get; set; }

        public Article(string title, string url, string description, DateTime pubDate)
        {
            Read = false;
            Starred = false;
            Description = description;
            PubDate = pubDate;
            Title = title;
            URL = url;
        }
    }
}
