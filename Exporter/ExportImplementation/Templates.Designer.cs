﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExportImplementation {
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
    public class Templates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Templates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExportImplementation.Templates", typeof(Templates).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;?mso-application progid=&quot;Excel.Sheet&quot;?&gt;
        ///&lt;Workbook xmlns=&quot;urn:schemas-microsoft-com:office:spreadsheet&quot;
        ///xmlns:o=&quot;urn:schemas-microsoft-com:office:office&quot;
        ///xmlns:x=&quot;urn:schemas-microsoft-com:office:excel&quot;
        ///xmlns:ss=&quot;urn:schemas-microsoft-com:office:spreadsheet&quot;
        ///xmlns:html=&quot;http://www.w3.org/TR/REC-html40&quot;&gt;
        ///&lt;DocumentProperties xmlns=&quot;urn:schemas-microsoft-com:office:office&quot;&gt;
        /// &lt;Author&gt;Andrei Ignat&lt;/Author&gt;
        /// &lt;LastAuthor&gt;Andrei Ignat&lt;/LastAuthor&gt;
        /// &lt;Created&gt;$DateCreated;format=&quot;yyyy- [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Excel2003File {
            get {
                return ResourceManager.GetString("Excel2003File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Row&gt;
        ///@foreach(var item in Model){
        ///   &lt;Cell&gt;&lt;Data ss:Type=&apos;String&apos;&gt;@item&lt;/Data&gt;&lt;/Cell&gt;
        ///} 
        ///&lt;/Row&gt;.
        /// </summary>
        public static string Excel2003Header {
            get {
                return ResourceManager.GetString("Excel2003Header", resourceCulture);
            }
        }
    }
}