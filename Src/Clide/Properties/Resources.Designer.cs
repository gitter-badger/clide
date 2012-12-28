﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clide.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Clide.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to In order to register command instance &apos;{command}&apos;, it must have a [Command] attribute..
        /// </summary>
        internal static string CommandManager_CommandAttributeMissing {
            get {
                return ResourceManager.GetString("CommandManager_CommandAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to register command filter instance &apos;{filter}&apos;, it must have a [CommandFilter] attribute..
        /// </summary>
        internal static string CommandManager_CommandFilterAttributeMissing {
            get {
                return ResourceManager.GetString("CommandManager_CommandFilterAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command type &apos;{type}&apos; does not have the required attribute &apos;{attribute}&apos;..
        /// </summary>
        internal static string CommandManager_OwningPackageAttributeRequired {
            get {
                return ResourceManager.GetString("CommandManager_OwningPackageAttributeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command type &apos;{type}&apos; specifies owning package with id &apos;{packageId}&apos; but it could not be found or loaded..
        /// </summary>
        internal static string CommandManager_OwningPackageNotFound {
            get {
                return ResourceManager.GetString("CommandManager_OwningPackageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command type &apos;{type}&apos; specifies owning package with id &apos;{packageId}&apos; which is not a valid service provider..
        /// </summary>
        internal static string CommandManager_OwningPackageNotServiceProvider {
            get {
                return ResourceManager.GetString("CommandManager_OwningPackageNotServiceProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to register all commands for a given package automatically, the owning package &apos;{package}&apos; must have a [Guid] attribute applied, which must match the commands&apos; corresponding [Command] attribute..
        /// </summary>
        internal static string CommandManager_PackageGuidMissing {
            get {
                return ResourceManager.GetString("CommandManager_PackageGuidMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{projectFile}&apos; must be based on MSBuild in order to support dynamic properties..
        /// </summary>
        internal static string ConfigProjectProperties_UnsupportedProject {
            get {
                return ResourceManager.GetString("ConfigProjectProperties_UnsupportedProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create output window for diagnostics traces..
        /// </summary>
        internal static string Diagnostics_FailedToCreateOutputWindow {
            get {
                return ResourceManager.GetString("Diagnostics_FailedToCreateOutputWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize host..
        /// </summary>
        internal static string Host_FailedToInitialize {
            get {
                return ResourceManager.GetString("Host_FailedToInitialize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hosting package &apos;{0}&apos; does not have the required [Guid] attribute..
        /// </summary>
        internal static string Host_MissingGuidAttribute {
            get {
                return ResourceManager.GetString("Host_MissingGuidAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported Visual Studio version. Please update Clide..
        /// </summary>
        internal static string Hosting_UnsupportedRuntime {
            get {
                return ResourceManager.GetString("Hosting_UnsupportedRuntime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified project &apos;{0}&apos; does not have a valid owning solution..
        /// </summary>
        internal static string IProjectNodeExtensions_BuildNoSolution {
            get {
                return ResourceManager.GetString("IProjectNodeExtensions_BuildNoSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load assemly reference &apos;{reference}&apos; from path &apos;{path}&apos;..
        /// </summary>
        internal static string IProjectNodeExtensions_FailedToLoadAssembly {
            get {
                return ResourceManager.GetString("IProjectNodeExtensions_FailedToLoadAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not retrieve the required type discovery services from the project..
        /// </summary>
        internal static string IProjectNodeExtensions_InvalidTypeContext {
            get {
                return ResourceManager.GetString("IProjectNodeExtensions_InvalidTypeContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve project types. Project is not a valid Visual Studio project, or the service provider cannot be retrieved from it..
        /// </summary>
        internal static string IProjectNodeExtensions_InvalidVsContext {
            get {
                return ResourceManager.GetString("IProjectNodeExtensions_InvalidVsContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building project &apos;{projectName}&apos; did not generate the expected output assembly &apos;{assemblyFile}&apos;..
        /// </summary>
        internal static string IProjectNodeExtensions_NoBuildOutput {
            get {
                return ResourceManager.GetString("IProjectNodeExtensions_NoBuildOutput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not determine the target assembly name for project &apos;{projectName}&apos;. The project TargetFileName and/or TargetDir properties are empty..
        /// </summary>
        internal static string IProjectNodeExtensions_NoTargetAssemblyName {
            get {
                return ResourceManager.GetString("IProjectNodeExtensions_NoTargetAssemblyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to register page &apos;{pageType}&apos;..
        /// </summary>
        internal static string OptionsManager_FailedToRegisterPage {
            get {
                return ResourceManager.GetString("OptionsManager_FailedToRegisterPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The owning package of a page must be a managed package, inheriting from &apos;{managedPackageBaseType}&apos;..
        /// </summary>
        internal static string OptionsManager_ManagedPackageRequired {
            get {
                return ResourceManager.GetString("OptionsManager_ManagedPackageRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options page specified package owner with Guid &apos;{owningPackageGuid}&apos;, but the package could not be found or loaded..
        /// </summary>
        internal static string OptionsManager_OwningPackageNotFound {
            get {
                return ResourceManager.GetString("OptionsManager_OwningPackageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options page of type &apos;{pageType}&apos; does not provide the required &apos;{owningPackageAttributeType}&apos; attribute..
        /// </summary>
        internal static string OptionsManager_OwningPackageRequired {
            get {
                return ResourceManager.GetString("OptionsManager_OwningPackageRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options page &apos;{pageType}&apos; must have a Category attribute that specifies the name of the root category node this page shows under in the Tools | Options dialog..
        /// </summary>
        internal static string OptionsManager_PageCategoryRequired {
            get {
                return ResourceManager.GetString("OptionsManager_PageCategoryRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options page &apos;{pageType}&apos; must have a DisplayName attribute that determines the name of the node under the specified category in the Tools | Options dialog tree..
        /// </summary>
        internal static string OptionsManager_PageDisplayNameRequired {
            get {
                return ResourceManager.GetString("OptionsManager_PageDisplayNameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tools options pages are not supported in this version of Visual Studio..
        /// </summary>
        internal static string OptionsManager_Unsupported {
            get {
                return ResourceManager.GetString("OptionsManager_Unsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clide.
        /// </summary>
        internal static string OutputPaneTitle {
            get {
                return ResourceManager.GetString("OutputPaneTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object has already been initialized..
        /// </summary>
        internal static string Settings_AlreadyInitialized {
            get {
                return ResourceManager.GetString("Settings_AlreadyInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndEdit invoked without corresponding BeginEdit..
        /// </summary>
        internal static string Settings_EndEditWithoutBeginEdit {
            get {
                return ResourceManager.GetString("Settings_EndEditWithoutBeginEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndInit invoked without corresponding BeginInit..
        /// </summary>
        internal static string Settings_EndInitWithoutBeginInit {
            get {
                return ResourceManager.GetString("Settings_EndInitWithoutBeginInit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to restore original state when editing was cancelled..
        /// </summary>
        internal static string Settings_FailedToRestore {
            get {
                return ResourceManager.GetString("Settings_FailedToRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings successfully saved..
        /// </summary>
        internal static string Settings_TraceSaved {
            get {
                return ResourceManager.GetString("Settings_TraceSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot persist setting value of type &apos;{0}&apos; from property &apos;{1}.{2}&apos;. An appropriate type converter that can convert the value to a string is required..
        /// </summary>
        internal static string SettingsManager_CannotSaveAsString {
            get {
                return ResourceManager.GetString("SettingsManager_CannotSaveAsString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read settings class &apos;{0}&apos; from the settings store..
        /// </summary>
        internal static string SettingsManager_FailedToRead {
            get {
                return ResourceManager.GetString("SettingsManager_FailedToRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot assign value of type &apos;{0}&apos; to property &apos;{1}.{2}&apos; of type &apos;{3}&apos;. An appropriate type converter is required..
        /// </summary>
        internal static string SettingsManager_InvalidValue {
            get {
                return ResourceManager.GetString("SettingsManager_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solution file is invalid..
        /// </summary>
        internal static string SolutionNode_InvalidSolutionFile {
            get {
                return ResourceManager.GetString("SolutionNode_InvalidSolutionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selecting element &apos;{itemPath}&apos; is not supported by the underlying project type..
        /// </summary>
        internal static string SolutionTreeNode_SelectionUnsupported {
            get {
                return ResourceManager.GetString("SolutionTreeNode_SelectionUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to execute command &apos;{commandText}&apos; ({commandType}) but current command status does not allow it..
        /// </summary>
        internal static string VsCommandExtensionAdapter_CannotExecute {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_CannotExecute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command did not execute successfully due to an unexpected exception. Please check the output window for additional information..
        /// </summary>
        internal static string VsCommandExtensionAdapter_ExecuteShieldMessage {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_ExecuteShieldMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing command &apos;{commandText}&apos; ({commandType})..
        /// </summary>
        internal static string VsCommandExtensionAdapter_ExecutingCommand {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_ExecutingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command could not determine its current status due to an unexpected exception. Please check the output window for additional information..
        /// </summary>
        internal static string VsCommandExtensionAdapter_QueryStatusShieldMessage {
            get {
                return ResourceManager.GetString("VsCommandExtensionAdapter_QueryStatusShieldMessage", resourceCulture);
            }
        }
    }
}
