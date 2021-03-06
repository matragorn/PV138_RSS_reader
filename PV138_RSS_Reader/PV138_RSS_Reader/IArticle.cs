﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{
    public class ArticleComparer : IEqualityComparer<IArticle>
    {
        public bool Equals(IArticle x, IArticle y)
        {
            return x.Identificator == y.Identificator;
        }

        public int GetHashCode(IArticle obj)
        {
            return (obj.Title + obj.URL + obj.Description).GetHashCode();
        }
    }

    public interface IArticle
    {
        /// <summary>
        /// URL clanku
        /// </summary>
        string URL { get; }

        /// <summary>
        /// Nadpis clanku
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Popis clanku
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Datum publikovania clanku
        /// </summary>
        DateTime PubDate { get; }

        /// <summary>
        /// Je clanok precitany?
        /// </summary>
        bool Read { get; set; }

        /// <summary>
        /// Ma clanok hviezdicku?
        /// </summary>
        bool Starred { get; set; }

        /// <summary>
        /// Vraci identifikator articlu pro porovnavani
        /// </summary>
        string Identificator { get; set; }

        /// <summary>
        /// Feed ze ktereho članek pochazí
        /// </summary>
        IFeed ParentFeed { get; set; }

        /// <summary>
        /// pro potřeby seznamu articlů v hlavním oknu, v listview, jednotlivé pole uvadi stringovou reprezentaci co se má pro daný feed 
        /// vypisovat ve sloupci, např. "datum", "název",...
        /// </summary>
        /// <returns></returns>
        string[] ToArray();

    }
}
