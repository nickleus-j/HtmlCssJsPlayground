﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPlayground.Wpf {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebPlayground.Wpf.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to a{
        ///  font-size:120%;
        ///  color:#207621}.
        /// </summary>
        internal static string CssContent {
            get {
                return ResourceManager.GetString("CssContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div&gt;
        /// &lt;svg xmlns:svg=&quot;http://www.w3.org/2000/svg&quot; xmlns=&quot;http://www.w3.org/2000/svg&quot; version=&quot;1.1&quot; width=&quot;800&quot; height=&quot;420&quot; id=&quot;svg&quot;&gt;&lt;image height=&quot;420&quot; width=&quot;800&quot; xmlns:xlink=&quot;http://www.w3.org/1999/xlink&quot; xlink:href=&quot;https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/The_Sun_by_the_Atmospheric_Imaging_Assembly_of_NASA%27s_Solar_Dynamics_Observatory_-_20100819.jpg/1280px-The_Sun_by_the_Atmospheric_Imaging_Assembly_of_NASA%27s_Solar_Dynamics_Observatory_-_20100819.jpg&quot; transform=&quot;matrix(1 0 0 1 0  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HtmlBody {
            get {
                return ResourceManager.GetString("HtmlBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var svg = document.getElementsByTagName(&apos;svg&apos;)[0];
        ///var svg_xml = (new XMLSerializer()).serializeToString(svg),
        ///    blob = new Blob([svg_xml], {type:&apos;image/svg+xml;charset=utf-8&apos;}),
        ///    url = window.URL.createObjectURL(blob);
        ///
        ///canvg(&apos;canvas2&apos;, svg_xml);
        ///var a = document.getElementById(&apos;imgId&apos;);
        ///
        ///function dlCanvas() {
        ///    var dt = canvas2.toDataURL(&apos;image/png&apos;);
        ///    this.href = dt;
        ///};
        ///a.addEventListener(&apos;click&apos;, dlCanvas, false);.
        /// </summary>
        internal static string JSContent {
            get {
                return ResourceManager.GetString("JSContent", resourceCulture);
            }
        }
    }
}