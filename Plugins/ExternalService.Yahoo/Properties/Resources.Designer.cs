﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternalService.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExternalService.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to error getting Lat Long:.
        /// </summary>
        internal static string warning_LatLong {
            get {
                return ResourceManager.GetString("warning_LatLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://query.yahooapis.com/v1/public/yql?q=select%20centroid%20from%20geo.places(1)%20where%20woeid%20in%20(select%20WOEID%20from%20pm.location.zip.region(1)%20where%20zip%3D%22{0}%22%20and%20region%3D%22us%22)&amp;format=json&amp;env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&amp;callback=.
        /// </summary>
        internal static string Yahoo_LatLong_Url {
            get {
                return ResourceManager.GetString("Yahoo_LatLong_Url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://query.yahooapis.com/v1/public/yql?q=select%20astronomy%20from%20weather.forecast%20where%20woeid%20in%20(select%20content%20from%20pm.location.zip.region%20where%20zip%3D%22{0}%22%20and%20region%3D%22us%22)&amp;format=json&amp;env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&amp;callback=.
        /// </summary>
        internal static string Yahoo_SRS_Url {
            get {
                return ResourceManager.GetString("Yahoo_SRS_Url", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://query.yahooapis.com/v1/public/yql?q=select%20item.condition%2C%20item.description%20from%20weather.forecast(1)%20where%20woeid%20in%20(select%20content%20from%20pm.location.zip.region(1)%20where%20zip%3D%22{0}%22%20and%20region%3D%22us%22)&amp;format=json&amp;env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&amp;callback=.
        /// </summary>
        internal static string Yahoo_Weather_Url {
            get {
                return ResourceManager.GetString("Yahoo_Weather_Url", resourceCulture);
            }
        }
    }
}
