﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PV138_RSS_Reader.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PV138_RSS_Reader.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to body
        ///{
        ///    font: 13px Microsoft Sans Serif, sans-serif;
        ///}
        ///
        ///a
        ///{
        ///    text-decoration: underline;
        ///    color: #1e5694;
        ///}
        ///
        ///a:hover
        ///{
        ///    text-decoration: none;
        ///}
        ///
        ///a h1
        ///{
        ///    color: black;
        ///    text-decoration: none;
        ///}.
        /// </summary>
        internal static string ARTICLE_CSS {
            get {
                return ResourceManager.GetString("ARTICLE_CSS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;xs:schema elementFormDefault=&quot;qualified&quot;
        ///	attributeFormDefault=&quot;unqualified&quot;
        ///  targetNamespace=&quot;http://www.w3.org/2005/Atom&quot;
        ///	xmlns:atom=&quot;http://www.w3.org/2005/Atom&quot; 
        ///	xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///	xmlns:xml=&quot;http://www.w3.org/XML/1998/namespace&quot;&gt;
        ///	&lt;xs:annotation&gt;
        ///		&lt;xs:documentation&gt;
        ///			This version of the Atom schema is based on version 1.0 of the format specifications,
        ///			found here http://www.atomenabled.org/developers/syndication/atom-f [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ATOM_XSD {
            get {
                return ResourceManager.GetString("ATOM_XSD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///
        ///&lt;reader-database&gt;
        ///  
        ///&lt;/reader-database&gt;.
        /// </summary>
        internal static string BLANK_DATABASE_XML {
            get {
                return ResourceManager.GetString("BLANK_DATABASE_XML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema id=&quot;XMLSchema1&quot;
        ///    xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;
        ///&gt;
        ///
        ///  &lt;xs:element name=&quot;reader-database&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;xs:choice maxOccurs=&quot;unbounded&quot;&gt;
        ///          &lt;xs:element name=&quot;feed&quot; type=&quot;feed&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot; /&gt;
        ///          &lt;xs:element name=&quot;category&quot; type=&quot;category&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot; /&gt;
        ///        &lt;/xs:choice&gt;
        ///      &lt;/xs:sequence&gt;
        ///    &lt;/xs:complexType&gt;
        ///  &lt;/xs:element&gt;
        ///
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DATABASE_XSD {
            get {
                return ResourceManager.GetString("DATABASE_XSD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap noStar {
            get {
                object obj = ResourceManager.GetObject("noStar", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;!--
        ///    XML Schema for RSS v2.0
        ///    Copyright (C) 2003-2008  Jorgen Thelin
        ///
        ///Microsoft Public License (Ms-PL)
        ///
        ///This license governs use of the accompanying software. 
        ///If you use the software, you accept this license. 
        ///If you do not accept the license, do not use the software.
        ///
        ///1. Definitions
        ///
        ///The terms &quot;reproduce,&quot; &quot;reproduction,&quot; &quot;derivative works,&quot; and &quot;distribution&quot; have the same meaning here as under U.S. copyright law.
        ///
        ///    A &quot;contribution&quot; is the o [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RSS_XSD {
            get {
                return ResourceManager.GetString("RSS_XSD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Star {
            get {
                object obj = ResourceManager.GetObject("Star", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
