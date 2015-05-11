using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    interface IStorageManager
    {
        /// <summary>
        /// Vrati zoznam vsetkych feedov
        /// </summary>
        /// <returns>Zoznam feedov</returns>
        List<IFeed> GetFeeds();

        /// <summary>
        /// Vrati zoznam vsetkych clankov pre dany feed
        /// </summary>
        /// <param name="feed">Feed</param>
        /// <returns>Zoznam clankov</returns>
        List<IArticle> GetArticles(IFeed feed);

        /// <summary>
        /// Prida novy feed
        /// </summary>
        /// <param name="feed">Feed</param>
        void AddFeed(IFeed feed);

        /// <summary>
        /// Odstrani feed
        /// </summary>
        /// <param name="feed">Feed</param>
        void RemoveFeed(IFeed feed);

        /// <summary>
        /// Prida zoznam clankov
        /// </summary>
        /// <param name="articles">Zoznam clankov</param>
        /// <param name="feed">Feed</param>
        void AddArticles(IEnumerable<IArticle> articles, IFeed feed);

        IArticle GetArticleByTitle(string title);

        void SetStarred(IArticle article, bool setTo);

        void SetRead(IArticle article, bool setTo);
    }
}
