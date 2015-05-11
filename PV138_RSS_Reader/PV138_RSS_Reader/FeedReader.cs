using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Spracuje xml dokument podla spravneho parsera
    /// </summary>
    public static class FeedReader
    {
        /// <summary>
        /// Zoznam parserov, nastaveny v konstruktore
        /// </summary>
        private static IEnumerable<IParser> Parsers { get; set; }

        static FeedReader()
        {
            Parsers = new List<IParser>() {new AtomParser(), new RssParser()};
        }

        /// <summary>
        /// Preparsuje xml na IFeed
        /// </summary>
        /// <param name="doc">XML dokument</param>
        /// <returns>Feed</returns>
        public static IFeed CreateFeed(XDocument doc, string url)
        {
            foreach (IParser parser in Parsers)
            {
                if (parser.IsDocThis(doc))
                {
                    return parser.CreateFeed(doc, url);
                }
            }

            throw new ArgumentException("The document doesn't contain any recognizable feed.");
        }
        
        /// <summary>
        /// Zparsuje z xml clanky mladsie ako <paramref name="date"/>
        /// </summary>
        /// <param name="doc">XML dokument</param>
        /// <returns></returns>
        public static IEnumerable<IArticle> GetArticles(XDocument doc)
        {
            foreach (IParser parser in Parsers)
            {
                if (parser.IsDocThis(doc))
                {
                    return parser.GetArticles(doc);
                }
            }

            throw new ArgumentException("The document doesn't contain any recognizable feed.");
        }
    }
}
