using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace PV138_RSS_Reader.Validation
{
    public static class StringXSDExtension
    {
        public static bool ValidateStringXSD(this XDocument doc, string xsdString)
        {
            bool ret = true;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += (o, e) => ret = false;

            using (StringReader stringReader = new StringReader(xsdString))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader))
                {
                    settings.Schemas.Add(null, xmlReader);
                }
            }

            using (XmlReader xmlReader = XmlReader.Create(doc.CreateReader(), settings))
            {
                while (xmlReader.Read()) { }
            }

            return ret;
        }
    }
}
