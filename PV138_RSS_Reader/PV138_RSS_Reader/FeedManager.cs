using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PV138_RSS_Reader
{
    /// <summary>
    /// Hlavny spravca logiky programu
    /// </summary>
    class FeedManager
    {
        private IStorageManager Storage { get; set; }

        /// <summary>
        /// Vrati List vsetkych prihlasenych feedov
        /// </summary>
        /// <returns>List prihlasenych feedov</returns>
        public List<IFeed> Feeds
        {
            get { return Storage.GetFeeds(); }
        }


        public FeedManager(IStorageManager storage)
        {
            if (storage == null)
                throw new ArgumentNullException("storage");

            Storage = storage;
        }

        /// <summary>
        /// Prihlasi sa na odber na <paramref name="url"/>
        /// </summary>
        /// <param name="url">Url feedu na spracovanie</param>
        /// <returns>Nacitany feed</returns>
        public IFeed SubscribeToURL(string url)
        {
            XDocument doc = XDocument.Parse(new WebClient().DownloadStringAwareOfEncoding(url));

            Feed feed = (Feed)FeedReader.CreateFeed(doc, url);

            Storage.AddFeed(feed);

            UpdateFeed(feed);

            return feed;
        }

        /// <summary>
        /// Odhlasi sa z odberu
        /// </summary>
        /// <param name="feed">Feed, ktory sa ma vymazat</param>
        public void Unsubscribe(IFeed feed)
        {
            Storage.RemoveFeed(feed);
        }

        /// <summary>
        /// Vrati List clankov pre dany feed
        /// </summary>
        /// <param name="feed">feed</param>
        /// <returns>Zoznam clankov vo feede</returns>
        public List<IArticle> Articles(IFeed feed)
        {
            return Storage.GetArticles(feed);
        }
        
        /// <summary>
        /// Aktualizuje feedy
        /// </summary>
        public void UpdateAllFeeds()
        {
            foreach (var feed in Feeds)
            {
                UpdateFeed(feed);
            }
        }

        /// <summary>
        /// Aktualizuje jeden feed
        /// </summary>
        /// <param name="feed">Feed, ktory sa ma aktualizovat</param>
        public void UpdateFeed(IFeed feed)
        {
            var c = new WebClient();
            //c.Encoding = Encoding.UTF8;

            XDocument doc = XDocument.Parse(c.DownloadStringAwareOfEncoding(feed.FeedURL));

            var newArticles = FeedReader.GetArticles(doc).Except(Storage.GetArticles(feed), new ArticleComparer());

            Storage.AddArticles(newArticles, feed);

            // TODO: Daj vediet GUIcku?
        }

        /// <summary>
        /// Zmeni clanku hodnotu precitania
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma zmenit</param>
        public void SetRead(IArticle article, bool setTo)
        {
            Storage.SetRead(article, setTo);
        }

        /// <summary>
        /// Zmeni clanku hodnotu ohviezdickovania
        /// </summary>
        /// <param name="article">Clanok</param>
        /// <param name="setTo">Hodnota, na ktoru sa ma zmenit</param>
        public void SetStarred(IArticle article, bool setTo)
        {
            Storage.SetStarred(article, setTo);
        }

        public IArticle ArticleByTitle(string title)
        {
            return Storage.GetArticleByTitle(title);
        }

        
    }

    

    /// <summary>
    /// DownloadStringAwareOfEncoding od Konamiman
    /// zo http://stackoverflow.com/questions/4716470/webclient-downloadstring-returns-string-with-peculiar-characters
    /// 
    /// Nacita string z url v spravnom encodingu
    /// 
    /// TODO: Mozeme pouzivat kod zo stackoverflow?
    /// </summary>
    public static class WebUtils
    {
        public static Encoding GetEncodingFrom(
            NameValueCollection responseHeaders,
            Encoding defaultEncoding = null)
        {
            if (responseHeaders == null)
                throw new ArgumentNullException("responseHeaders");

            //Note that key lookup is case-insensitive
            var contentType = responseHeaders["Content-Type"];
            if (contentType == null)
                return defaultEncoding;

            var contentTypeParts = contentType.Split(';');
            if (contentTypeParts.Length <= 1)
                return defaultEncoding;

            var charsetPart =
                contentTypeParts.Skip(1).FirstOrDefault(
                    p => p.TrimStart().StartsWith("charset", StringComparison.InvariantCultureIgnoreCase));
            if (charsetPart == null)
                return defaultEncoding;

            var charsetPartParts = charsetPart.Split('=');
            if (charsetPartParts.Length != 2)
                return defaultEncoding;

            var charsetName = charsetPartParts[1].Trim();
            if (charsetName == "")
                return defaultEncoding;

            try
            {
                return Encoding.GetEncoding(charsetName);
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException(
                    "The server returned data in an unknown encoding: " + charsetName,
                    ex);
            }
        }
    }

    public static class WebClientExtensions
    {
        public static string DownloadStringAwareOfEncoding(this WebClient webClient, string uri)
        {
            var rawData = webClient.DownloadData(uri);
            var encoding = WebUtils.GetEncodingFrom(webClient.ResponseHeaders, Encoding.UTF8);
            return encoding.GetString(rawData);
        }
    }
}
