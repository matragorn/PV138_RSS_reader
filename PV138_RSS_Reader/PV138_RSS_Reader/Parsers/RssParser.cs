using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Parser pre rss format
    /// </summary>
    public class RssParser : IParser
    {
        public bool IsDocThis(XDocument doc)
        {
            // TODO: pouzit sablonu
            return doc.Root.Name.LocalName.ToLower() == "rss";
        }

        public IFeed CreateFeed(XDocument doc, string url)
        {
            XNamespace ns = doc.Root.GetDefaultNamespace();

            return new Feed
            (
                url,
                doc.Descendants(ns + "channel").Descendants(ns + "title").First().Value,
                doc.Descendants(ns + "channel").Descendants(ns + "link").First().Value,
                doc.Descendants(ns + "channel").Descendants(ns + "description").First().Value
            );
        }

        public IArticle ArticleFromItem(XElement item, XNamespace ns)
        {
            if(item.Name.LocalName != "item")
                throw new ArgumentException("item");

            string title = item.Descendants(ns + "title").Count() == 0 ? "" : item.Descendants(ns + "title").First().Value;
            string description = item.Descendants(ns + "description").Count() == 0 ? "" : item.Descendants(ns + "description").First().Value;
            DateTime pubDate = item.Descendants(ns + "pubDate").Count() == 0 ? DateTime.Now : DateTime.Parse(item.Descendants(ns + "pubDate").First().Value);
            string url = item.Descendants(ns + "link").Count() == 0 ? "" : item.Descendants(ns + "link").First().Value;

            if (title == null)
                throw new FormatException("Clanok musi mat zadany aspon nadpis");

            return new Article(title, url, description, pubDate);

        }


        public IEnumerable<IArticle> GetArticles(XDocument doc)
        {
            XNamespace ns = doc.Root.GetDefaultNamespace();

            return doc.Descendants(ns + "item").Select(article => ArticleFromItem(article, ns));
        }
    }
}
