using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public class FeedComparer : IEqualityComparer<IFeed>
    {
        public bool Equals(IFeed x, IFeed y)
        {
            return x.GetHashCode() == y.GetHashCode();
        }

        public int GetHashCode(IFeed obj)
        {
            return obj.FeedURL.GetHashCode();
        }
    }


    /// <summary>
    /// reprezentuje jednotlivý feed ziskaný z rss, mel by obsahovat
    /// plno datovych polozek jako nazev, tatum, kanal atd...
    /// </summary>
    public interface IFeed
    {
        /// <summary>
        /// Nadpis feedu
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Url hlavnej stranky
        /// </summary>
        string MainPageLink { get; }

        /// <summary>
        /// Url nacitavania feedu
        /// </summary>
        string FeedURL { get; }

        /// <summary>
        /// Popis feedu
        /// </summary>
        string Description { get; }



    }
}
