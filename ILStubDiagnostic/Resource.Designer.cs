﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILStubDiagnostic {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ILStubDiagnostic.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Do not have enough access authorization. Please run as administrator..
        /// </summary>
        internal static string Err_UnauthorizedAccess {
            get {
                return ResourceManager.GetString("Err_UnauthorizedAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Helper function in the StubHelpers..
        /// </summary>
        internal static string Msg_DefaultAPIDescription {
            get {
                return ResourceManager.GetString("Msg_DefaultAPIDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation of filter &apos;{0}&apos; is null..
        /// </summary>
        internal static string Wrn_FilterOperationIsNull {
            get {
                return ResourceManager.GetString("Wrn_FilterOperationIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation &apos;{0}&apos; of filter &apos;{1}&apos; is not support..
        /// </summary>
        internal static string Wrn_FilterOperationNotSupport {
            get {
                return ResourceManager.GetString("Wrn_FilterOperationNotSupport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of filter &apos;{0}&apos; is null..
        /// </summary>
        internal static string Wrn_FilterValueIsNull {
            get {
                return ResourceManager.GetString("Wrn_FilterValueIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; of filter &apos;{1}&apos; is not an integer..
        /// </summary>
        internal static string Wrn_FilterValueNotInteger {
            get {
                return ResourceManager.GetString("Wrn_FilterValueNotInteger", resourceCulture);
            }
        }
    }
}