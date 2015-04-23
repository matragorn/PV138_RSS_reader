using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader
{

    public class AtomReader :IFeedReader
    {
        public IEnumerable<IFeed> ReadFeeds(string uri)
        {
            throw new NotImplementedException();
        }
    }
}
