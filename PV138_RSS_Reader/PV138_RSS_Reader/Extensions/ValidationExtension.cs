using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace PV138_RSS_Reader.Extensions
{
    public static class ValidationExtension
    {
        /// <summary>
        /// Zisti, ci je XDocument validny podla XML Schema ulozenom v stringu
        /// </summary>
        /// <param name="doc">XDocument, ktory sa ma validovat</param>
        /// <param name="xsdString">XML Schema</param>
        /// <returns>True/False</returns>
        public static bool ValidateStringXSD(this XDocument doc, string xsdString)
        {
            bool ret = true;

            // Nastavenia validatoru
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += (o, e) => ret = false;

            // Pridanie XSD
            using (StringReader stringReader = new StringReader(xsdString))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader))
                {
                    settings.Schemas.Add(null, xmlReader);
                }
            }

            // Validacia XDocumentu
            using (XmlReader xmlReader = XmlReader.Create(doc.CreateReader(), settings))
            {
                while (xmlReader.Read() && ret) { }
            }

            return ret;
        }
    }
}
