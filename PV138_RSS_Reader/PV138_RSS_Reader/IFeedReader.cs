using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{

    public interface IFeedReader
    {
        /// <summary>
        /// precte feedy ze zadane URI
        /// </summary>
        /// <param name="uri">adresa RSS/ATOM zdroje</param>
        /// <returns>kolekce Feedů</returns>
        /// <remarks>muzeme to klidne predela na List aby to nebylo tak obecny...</remarks>
        IEnumerable<IFeed> ReadFeeds(string uri);
    }
}
