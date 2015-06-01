using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader.Exceptions
{
    /// <summary>
    /// Exception ktera se vyhazuje pokud neni Item v databazi
    /// </summary>
    [Serializable]
    public class NoSuchItemInDatabase : Exception
    {
        public NoSuchItemInDatabase() { }
        public NoSuchItemInDatabase(string message) : base(message) { }

    }
}
