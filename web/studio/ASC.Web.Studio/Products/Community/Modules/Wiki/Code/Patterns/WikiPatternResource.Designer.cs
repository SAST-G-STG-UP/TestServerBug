﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Web.Community.Modules.Wiki.Code.Patterns {
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
    public class WikiPatternResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WikiPatternResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Web.Community.Modules.Wiki.Code.Patterns.WikiPatternResource", typeof(WikiPatternResource).Assembly);
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
        ///   Looks up a localized string similar to h1.New Wiki Page Added: &quot;$PageName&quot;:&quot;$URL&quot;
        ///
        ///$Date &quot;$UserName&quot;:&quot;$UserURL&quot; has created a new Wiki page: &quot;$PageName&quot;:&quot;$URL&quot;
        ///
        ///$PagePreview
        ///
        ///&quot;Read More&quot;:&quot;$URL&quot;
        ///
        ///^You receive this email because you are a registered user of the &quot;${__VirtualRootPath}&quot;:&quot;${__VirtualRootPath}&quot; portal. If you do not want to receive the notifications about new Wiki pages created, please manage your &quot;subscription settings&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.^.
        /// </summary>
        public static string pattern_1 {
            get {
                return ResourceManager.GetString("pattern_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.Wiki Page Edited: &quot;$PageName&quot;:&quot;$URL&quot;
        ///
        ///$Date &quot;$UserName&quot;:&quot;$UserURL&quot; has edited the Wiki page: &quot;$PageName&quot;:&quot;$URL&quot;
        ///
        ///$PagePreview
        ///
        ///&quot;Read More&quot;:&quot;$URL&quot;
        ///
        ///^You receive this email because you are a registered user of the &quot;${__VirtualRootPath}&quot;:&quot;${__VirtualRootPath}&quot; portal. If you do not want to receive the notifications about the changes of this Wiki page, please manage your &quot;subscription settings&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.^.
        /// </summary>
        public static string pattern_2 {
            get {
                return ResourceManager.GetString("pattern_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.New Comment to Wiki Page &quot;$PageName&quot;:&quot;$URL&quot;
        ///
        ///$Date &quot;$UserName&quot;:&quot;$UserURL&quot; has added a new comment to the &quot;$PageName&quot;:&quot;$URL&quot; Wiki page:
        ///
        ///$CommentBody
        ///
        ///&quot;Read More&quot;:&quot;$URL&quot;
        ///
        ///^You receive this email because you are a registered user of the &quot;${__VirtualRootPath}&quot;:&quot;${__VirtualRootPath}&quot; portal. If you do not want to receive the notifications about new comments added to this Wiki page, please manage your &quot;subscription settings&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.^ .
        /// </summary>
        public static string pattern_3 {
            get {
                return ResourceManager.GetString("pattern_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to h1.You were mentioned in comment to Wiki Page &quot;$PageName&quot;:&quot;$URL&quot;
        ///
        ///$Date &quot;$UserName&quot;:&quot;$UserURL&quot; mentioned you in the comment to the &quot;$PageName&quot;:&quot;$URL&quot; Wiki page:
        ///
        ///$CommentBody
        ///
        ///&quot;Read More&quot;:&quot;$URL&quot;
        ///
        ///^You receive this email because you are a registered user of the &quot;${__VirtualRootPath}&quot;:&quot;${__VirtualRootPath}&quot; portal. If you do not want to receive the notifications about new comments added to this Wiki page, please manage your &quot;subscription settings&quot;:&quot;$RecipientSubscriptionConfigURL&quot;.^.
        /// </summary>
        public static string pattern_MentionForWikiComment {
            get {
                return ResourceManager.GetString("pattern_MentionForWikiComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. New Wiki page added: $PageName.
        /// </summary>
        public static string subject_1 {
            get {
                return ResourceManager.GetString("subject_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. New Wiki page added: [$PageName]($URL).
        /// </summary>
        public static string subject_1_tg {
            get {
                return ResourceManager.GetString("subject_1_tg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. Wiki page edited: $PageName.
        /// </summary>
        public static string subject_2 {
            get {
                return ResourceManager.GetString("subject_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. Wiki page edited: [$PageName]($URL).
        /// </summary>
        public static string subject_2_tg {
            get {
                return ResourceManager.GetString("subject_2_tg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. New comment to Wiki page: $PageName.
        /// </summary>
        public static string subject_3 {
            get {
                return ResourceManager.GetString("subject_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. New comment to Wiki page: [$PageName]($URL).
        /// </summary>
        public static string subject_3_tg {
            get {
                return ResourceManager.GetString("subject_3_tg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. Mention in comment to Wiki page: $PageName.
        /// </summary>
        public static string subject_MentionForWikiComment {
            get {
                return ResourceManager.GetString("subject_MentionForWikiComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Community. Mention in comment to Wiki page: [$PageName]($URL).
        /// </summary>
        public static string subject_MentionForWikiComment_tg {
            get {
                return ResourceManager.GetString("subject_MentionForWikiComment_tg", resourceCulture);
            }
        }
    }
}
