﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SteveCadwallader.CodeMaid.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Progressing_ShowBuildProgressOnBuildStart {
            get {
                return ((bool)(this["Progressing_ShowBuildProgressOnBuildStart"]));
            }
            set {
                this["Progressing_ShowBuildProgressOnBuildStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Progressing_HideBuildProgressOnBuildStop {
            get {
                return ((bool)(this["Progressing_HideBuildProgressOnBuildStop"]));
            }
            set {
                this["Progressing_HideBuildProgressOnBuildStop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Reorganizing_AlphabetizeMembersOfTheSameGroup {
            get {
                return ((bool)(this["Reorganizing_AlphabetizeMembersOfTheSameGroup"]));
            }
            set {
                this["Reorganizing_AlphabetizeMembersOfTheSameGroup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Reorganizing_RunAtStartOfCleanup {
            get {
                return ((bool)(this["Reorganizing_RunAtStartOfCleanup"]));
            }
            set {
                this["Reorganizing_RunAtStartOfCleanup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".cpp .h ; .xaml .xaml.cs ; .xml .xsd")]
        public string Switching_RelatedFileExtensionsExpression {
            get {
                return ((string)(this["Switching_RelatedFileExtensionsExpression"]));
            }
            set {
                this["Switching_RelatedFileExtensionsExpression"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Digging_CenterOnWhole {
            get {
                return ((bool)(this["Digging_CenterOnWhole"]));
            }
            set {
                this["Digging_CenterOnWhole"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int Digging_ComplexityWarningThreshold {
            get {
                return ((int)(this["Digging_ComplexityWarningThreshold"]));
            }
            set {
                this["Digging_ComplexityWarningThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int Digging_ComplexityAlertThreshold {
            get {
                return ((int)(this["Digging_ComplexityAlertThreshold"]));
            }
            set {
                this["Digging_ComplexityAlertThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Digging_ShowMethodParameters {
            get {
                return ((bool)(this["Digging_ShowMethodParameters"]));
            }
            set {
                this["Digging_ShowMethodParameters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Digging_ShowItemComplexity {
            get {
                return ((bool)(this["Digging_ShowItemComplexity"]));
            }
            set {
                this["Digging_ShowItemComplexity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Digging_ShowItemMetadata {
            get {
                return ((bool)(this["Digging_ShowItemMetadata"]));
            }
            set {
                this["Digging_ShowItemMetadata"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_UpdateEndRegionDirectives {
            get {
                return ((bool)(this["Cleaning_UpdateEndRegionDirectives"]));
            }
            set {
                this["Cleaning_UpdateEndRegionDirectives"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_SortUsingStatements {
            get {
                return ((bool)(this["Cleaning_SortUsingStatements"]));
            }
            set {
                this["Cleaning_SortUsingStatements"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".*.Designer.cs ; .*.resx")]
        public string Cleaning_ExclusionExpression {
            get {
                return ((string)(this["Cleaning_ExclusionExpression"]));
            }
            set {
                this["Cleaning_ExclusionExpression"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeCPlusPlus {
            get {
                return ((bool)(this["Cleaning_IncludeCPlusPlus"]));
            }
            set {
                this["Cleaning_IncludeCPlusPlus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeCSharp {
            get {
                return ((bool)(this["Cleaning_IncludeCSharp"]));
            }
            set {
                this["Cleaning_IncludeCSharp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeCSS {
            get {
                return ((bool)(this["Cleaning_IncludeCSS"]));
            }
            set {
                this["Cleaning_IncludeCSS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeHTML {
            get {
                return ((bool)(this["Cleaning_IncludeHTML"]));
            }
            set {
                this["Cleaning_IncludeHTML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeJavaScript {
            get {
                return ((bool)(this["Cleaning_IncludeJavaScript"]));
            }
            set {
                this["Cleaning_IncludeJavaScript"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeXAML {
            get {
                return ((bool)(this["Cleaning_IncludeXAML"]));
            }
            set {
                this["Cleaning_IncludeXAML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_IncludeXML {
            get {
                return ((bool)(this["Cleaning_IncludeXML"]));
            }
            set {
                this["Cleaning_IncludeXML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_AutoCleanupOnFileSave {
            get {
                return ((bool)(this["Cleaning_AutoCleanupOnFileSave"]));
            }
            set {
                this["Cleaning_AutoCleanupOnFileSave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_AutoSaveAndCloseIfOpenedByCleanup {
            get {
                return ((bool)(this["Cleaning_AutoSaveAndCloseIfOpenedByCleanup"]));
            }
            set {
                this["Cleaning_AutoSaveAndCloseIfOpenedByCleanup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RunVisualStudioFormatDocumentCommand {
            get {
                return ((bool)(this["Cleaning_RunVisualStudioFormatDocumentCommand"]));
            }
            set {
                this["Cleaning_RunVisualStudioFormatDocumentCommand"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveUnusedUsingStatementsExceptDuringAutoCleanupOnSave {
            get {
                return ((bool)(this["Cleaning_RemoveUnusedUsingStatementsExceptDuringAutoCleanupOnSave"]));
            }
            set {
                this["Cleaning_RemoveUnusedUsingStatementsExceptDuringAutoCleanupOnSave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveUnusedUsingStatements {
            get {
                return ((bool)(this["Cleaning_RemoveUnusedUsingStatements"]));
            }
            set {
                this["Cleaning_RemoveUnusedUsingStatements"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveMultipleConsecutiveBlankLines {
            get {
                return ((bool)(this["Cleaning_RemoveMultipleConsecutiveBlankLines"]));
            }
            set {
                this["Cleaning_RemoveMultipleConsecutiveBlankLines"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveEndOfLineWhitespace {
            get {
                return ((bool)(this["Cleaning_RemoveEndOfLineWhitespace"]));
            }
            set {
                this["Cleaning_RemoveEndOfLineWhitespace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveBlankLinesBeforeClosingBrace {
            get {
                return ((bool)(this["Cleaning_RemoveBlankLinesBeforeClosingBrace"]));
            }
            set {
                this["Cleaning_RemoveBlankLinesBeforeClosingBrace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveBlankLinesAfterOpeningBrace {
            get {
                return ((bool)(this["Cleaning_RemoveBlankLinesAfterOpeningBrace"]));
            }
            set {
                this["Cleaning_RemoveBlankLinesAfterOpeningBrace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveBlankLinesAtTop {
            get {
                return ((bool)(this["Cleaning_RemoveBlankLinesAtTop"]));
            }
            set {
                this["Cleaning_RemoveBlankLinesAtTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_RemoveBlankLinesAtBottom {
            get {
                return ((bool)(this["Cleaning_RemoveBlankLinesAtBottom"]));
            }
            set {
                this["Cleaning_RemoveBlankLinesAtBottom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnStructs {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnStructs"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnStructs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnProperties {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnProperties"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnProperties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnMethods {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnMethods"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnMethods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnInterfaces {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnInterfaces"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnInterfaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnEvents {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnEvents"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnEnumerations {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnEnumerations"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnEnumerations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertExplicitAccessModifiersOnClasses {
            get {
                return ((bool)(this["Cleaning_InsertExplicitAccessModifiersOnClasses"]));
            }
            set {
                this["Cleaning_InsertExplicitAccessModifiersOnClasses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterStructs {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterStructs"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterStructs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeStructs {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeStructs"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeStructs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterProperties {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterProperties"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterProperties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeProperties {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeProperties"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeProperties"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterMethods {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterMethods"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterMethods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeMethods {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeMethods"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeMethods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterInterfaces {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterInterfaces"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterInterfaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeInterfaces {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeInterfaces"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeInterfaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterFieldsMultiLine {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterFieldsMultiLine"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterFieldsMultiLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeFieldsMultiLine {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeFieldsMultiLine"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeFieldsMultiLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterEvents {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterEvents"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeEvents {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeEvents"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterEnumerations {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterEnumerations"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterEnumerations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeEnumerations {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeEnumerations"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeEnumerations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterClasses {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterClasses"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterClasses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeClasses {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeClasses"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeClasses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterEndRegionTags {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterEndRegionTags"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterEndRegionTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeEndRegionTags {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeEndRegionTags"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeEndRegionTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterRegionTags {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterRegionTags"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterRegionTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeRegionTags {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeRegionTags"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeRegionTags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterNamespaces {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterNamespaces"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterNamespaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeNamespaces {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeNamespaces"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeNamespaces"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingAfterUsingStatementBlocks {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingAfterUsingStatementBlocks"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingAfterUsingStatementBlocks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Cleaning_InsertBlankLinePaddingBeforeUsingStatementBlocks {
            get {
                return ((bool)(this["Cleaning_InsertBlankLinePaddingBeforeUsingStatementBlocks"]));
            }
            set {
                this["Cleaning_InsertBlankLinePaddingBeforeUsingStatementBlocks"] = value;
            }
        }
    }
}
