using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public interface IStorageManager
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

        /// <summary>
        /// Nastavi clanku hodnotu ohviezdickovania
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma ohviezdickovanie nastavit</param>
        void SetStarred(IArticle article, bool setTo);

        /// <summary>
        /// Nastavi clanku hodnotu precitania
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma precitane nastavit</param>
        void SetRead(IArticle article, bool setTo);

        /// <summary>
        /// Vrati zoznam vsetkych kategorii
        /// </summary>
        /// <returns>Zoznam vsetkych kategorii</returns>
        List<Category> GetCategories();

        /// <summary>
        /// Prida novu kategoriu
        /// </summary>
        /// <param name="category">Kategoria</param>
        void AddCategory(Category category);

        /// <summary>
        /// Odstrani kategoriu
        /// </summary>
        /// <param name="category">Kategoria</param>
        void RemoveCategory(Category category);

        /// <summary>
        /// Vyhlada clanky, ktore maju v nadpise alebo popise frazu <paramref name="phrase"/>
        /// </summary>
        /// <param name="phrase">Vyhladavana fraza</param>
        /// <returns>Zoznam clankov</returns>
        List<IArticle> Search(string phrase);
    }
}
