using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Parser pre Atom format
    /// </summary>
    public class AtomParser : IParser
    {
        public bool IsDocThis(XDocument doc)
        {
            return doc.Root.Name.LocalName.ToLower() == "feed";
        }

        public IFeed CreateFeed(XDocument doc, string url)
        {
            XNamespace ns = doc.Root.GetDefaultNamespace();

            var link = doc.Descendants(ns + "link").Count() == 0 ? "" : doc.Descendants(ns + "link").First().Attribute("href").Value;
            var subtitle = doc.Descendants(ns + "subtitle").Count() == 0 ? "" : doc.Descendants(ns + "subtitle").First().Value;

            return new Feed
            (
                url,
                doc.Descendants(ns + "title").First().Value,
                link,
                subtitle
            );
        }

        public IEnumerable<IArticle> GetArticles(XDocument doc)
        {
            XNamespace ns = doc.Root.GetDefaultNamespace();

            return doc.Descendants(ns + "entry").Select(article => ArticleFromItem(article, ns));
        }


        public IArticle ArticleFromItem(XElement item, XNamespace ns)
        {
            if (item.Name.LocalName != "entry")
                throw new ArgumentException("item");

            string title = item.Descendants(ns + "title").First().Value;
            DateTime updated = DateTime.Parse(item.Descendants(ns + "updated").First().Value);
            string content = "";
            string link = item.Descendants(ns + "link").First().Attribute("href").Value;

            if (item.Descendants(ns + "content").Count() == 0)
	        {
		        if (item.Descendants(ns + "summary").Count() != 0)
	            {
		            content = item.Descendants(ns + "summary").First().Value;
	            }
	        }
            else
        	{
                content = item.Descendants(ns + "content").First().Value;
	        }


            return new Article(title, link, content, updated);
        }
    }
}
