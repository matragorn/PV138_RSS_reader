using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PV138_RSS_Reader.Validation;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Parser pre RSS format
    /// </summary>
    public class RssParser : IParser
    {
        /// <summary>
        /// Zisti, ci je XDokument validny voci RSS formatu
        /// </summary>
        /// <param name="doc">Testovany XDocument</param>
        /// <returns>True/False</returns>
        public bool IsDocThis(XDocument doc)
        {
            return doc.ValidateStringXSD(Properties.Resources.RSS_XSD);
        }

        /// <summary>
        /// Z RSS dokumentu vytvori IFeed
        /// </summary>
        /// <param name="doc">RSS dokument</param>
        /// <param name="url">URL feedu</param>
        /// <returns>Novy IFeed</returns>
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

        /// <summary>
        /// Z XElementu jednotliveho clanku v RSS subore vytvori IArticle
        /// </summary>
        /// <param name="item">XElement clanku</param>
        /// <param name="ns">Pouzita namespace</param>
        /// <returns>Novy IArticle</returns>
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

        /// <summary>
        /// Vrati kolekciu vsetkych clankov v RSS dokumente
        /// </summary>
        /// <param name="doc">RSS dokument</param>
        /// <returns>Kolekcia clankov</returns>
        public IEnumerable<IArticle> GetArticles(XDocument doc)
        {
            XNamespace ns = doc.Root.GetDefaultNamespace();

            return doc.Descendants(ns + "item").Select(article => ArticleFromItem(article, ns));
        }
    }
}
