using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV138_RSS_Reader.Exceptions
{
    /// <summary>
    /// Exception, ktora obsahuje spravu pre uzivatela, ktora sa ma zobrazit
    /// </summary>
    [Serializable]
    public class InformUserException : Exception
    {
        public InformUserException() { }
        public InformUserException(string message) : base(message) { }
        public InformUserException(string message, Exception inner) : base(message, inner) { }
        protected InformUserException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
