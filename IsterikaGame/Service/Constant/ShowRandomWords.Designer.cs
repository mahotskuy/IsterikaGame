﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.Constant {
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
    internal class ShowRandomWords {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ShowRandomWords() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Service.Constant.ShowRandomWords", typeof(ShowRandomWords).Assembly);
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
        ///   Looks up a localized string similar to Basket Words is emty.
        /// </summary>
        internal static string AllWordIsExplained {
            get {
                return ResourceManager.GetString("AllWordIsExplained", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is a list.
        /// </summary>
        internal static string ForShowingListOfExplainedWordByPlayer {
            get {
                return ResourceManager.GetString("ForShowingListOfExplainedWordByPlayer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command {0}.
        /// </summary>
        internal static string ForShowingNameOfCommand {
            get {
                return ResourceManager.GetString("ForShowingNameOfCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} explain {1} words.
        /// </summary>
        internal static string ShowHowManyWordExplainedByPlayer {
            get {
                return ResourceManager.GetString("ShowHowManyWordExplainedByPlayer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ////////////////////////////////////////////////////////////////////
        ///Win command {0} with amount of goals {1}
        ///////////////////////////////////////////////////////////////////////.
        /// </summary>
        internal static string ShowWiner {
            get {
                return ResourceManager.GetString("ShowWiner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pleas play {0} 
        ///Pleas put enter to continue.
        /// </summary>
        internal static string WaitNextPlayer {
            get {
                return ResourceManager.GetString("WaitNextPlayer", resourceCulture);
            }
        }
    }
}
