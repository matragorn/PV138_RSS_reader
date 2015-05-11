using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PV138_RSS_Reader
{
    interface IParser
    {
        /// <summary>
        /// Skontroluje dokument <paramref name="doc"/>, ci sa jedna o format, ktory vieme spracovat
        /// </summary>
        /// <param name="doc">XML dokument</param>
        /// <returns>Vieme spracovat <paramref name="doc"/>?</returns>
        bool IsDocThis(XDocument doc);

        /// <summary>
        /// Z xml dokumentu vytvori IFeed
        /// </summary>
        /// <param name="doc">XML dokument</param>
        /// <param name="url">Url feedu</param>
        /// <returns>Feed</returns>
        IFeed CreateFeed(XDocument doc, string url);

        /// <summary>
        /// Vytvori zoznam clankov z xml dokumentu
        /// </summary>
        /// <param name="doc">XML dokument</param>
        /// <returns>Zoznam clankov</returns>
        IEnumerable<IArticle> GetArticles(XDocument doc);

        /// <summary>
        /// Preparsuje jeden XElement na Article
        /// </summary>
        /// <param name="item">XML element, obsahujuci jeden clanok</param>
        /// <param name="ns">Namespace pouzity v dokumente</param>
        /// <returns>Article</returns>
        IArticle ArticleFromItem(XElement item, XNamespace ns);
    }
}
