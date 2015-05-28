using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Kategoria
    /// </summary>
    public class Category
    {
        /// <summary>
        /// ID je null, az kym sa kategoria neulozi do Storage
        /// </summary>
        public int? ID { get; set; }
        public string Name { get; set; }
        public List<IFeed> Feeds { get; set; }


        /// <summary>
        /// Vytvori novu kategoriu
        /// </summary>
        public Category()
        {
            Feeds = new List<IFeed>();
        }

        /// <summary>
        /// Vytvori novu kategoriu
        /// </summary>
        /// <param name="feeds">Zoznam feedov v kategorii</param>
        public Category(List<IFeed> feeds)
        {
            Feeds = feeds;
        }

        /// <summary>
        /// Vytvori novu kategoriu
        /// </summary>
        /// <param name="feeds">Zoznam feedov v kategorii</param>
        /// <param name="id">ID kategorie</param>
        public Category(List<IFeed> feeds, int id) : this(feeds)
        {
            ID = id;
        }

        /// <summary>
        /// Prida novy feed do kategorie
        /// </summary>
        /// <param name="feed">Feed</param>
        public void AddFeed(IFeed feed)
        {
            Feeds.Add(feed);
        }

        /// <summary>
        /// Odstrani feed z kategorie
        /// </summary>
        /// <param name="feed">Feed</param>
        public void RemoveFeed(IFeed feed)
        {
            Feeds.Remove(feed);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
