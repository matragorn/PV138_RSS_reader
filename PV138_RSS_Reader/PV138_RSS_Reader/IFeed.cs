using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// reprezentuje jednotlivý feed ziskaný z rss, mel by obsahovat plno datovych polozek jako nazev, tatum, kanal atd...
    /// </summary>
    public interface IFeed
    {
        /// <summary>
        /// Unikatne ID feedu
        /// </summary>
        string ID { get; }

        /// <summary>
        /// Nadpis feedu
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Url hlavnej stranky
        /// </summary>
        string WebLink { get; }

        /// <summary>
        /// Url nacitavania feedu
        /// </summary>
        string URL { get; }

        /// <summary>
        /// Popis feedu
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Kedy bol feed naposledy zmeneny
        /// </summary>
        DateTime LastBuildDate { get; set; }

        /// <summary>
        /// pro potřeby seznamu feedů v hlavním oknu, v listview, jednotlivé pole uvadi stringovou reprezentaci co se má pro daný feed 
        /// vypisovat ve sloupci, např. "datum", "název",...
        /// </summary>
        /// <returns></returns>
        string[] ToArray();


    }
}
