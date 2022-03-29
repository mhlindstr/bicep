﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bicep.LanguageServer {
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
    public class LangServerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LangServerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bicep.LanguageServer.LangServerResources", typeof(LangServerResources).Assembly);
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
        ///   Looks up a localized string similar to Deployment failed for {0}..
        /// </summary>
        public static string DeploymentFailedMessage {
            get {
                return ResourceManager.GetString("DeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}. {1}.
        /// </summary>
        public static string DeploymentFailedWithExceptionMessage {
            get {
                return ResourceManager.GetString("DeploymentFailedWithExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment succeeded for {0}..
        /// </summary>
        public static string DeploymentSucceededMessage {
            get {
                return ResourceManager.GetString("DeploymentSucceededMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disable {0} for this line.
        /// </summary>
        public static string DisableDiagnosticForThisLine {
            get {
                return ResourceManager.GetString("DisableDiagnosticForThisLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit {0} in bicepconfig.json.
        /// </summary>
        internal static string EditLinterRuleActionTitle {
            get {
                return ResourceManager.GetString("EditLinterRuleActionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed. Please fix the following issues in the parameter file: {0}.
        /// </summary>
        public static string InvalidParameterFileDeploymentFailedMessage {
            get {
                return ResourceManager.GetString("InvalidParameterFileDeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deployment failed for {0}. Please provide a valid location..
        /// </summary>
        public static string MissingLocationDeploymentFailedMessage {
            get {
                return ResourceManager.GetString("MissingLocationDeploymentFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported target scope: {0}..
        /// </summary>
        public static string UnsupportedTargetScopeMessage {
            get {
                return ResourceManager.GetString("UnsupportedTargetScopeMessage", resourceCulture);
            }
        }
    }
}
