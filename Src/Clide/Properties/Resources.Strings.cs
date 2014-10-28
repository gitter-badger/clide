//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Globalization;

namespace Clide.Properties
{
	///	<summary>
	///	Provides access to string resources.
	///	</summary>
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	static partial class Strings
	{
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class CommandManager
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	In order to register command instance '{command}', it must have a [Command] attribute.
			/// </summary>
			public static string CommandAttributeMissing(object command)
			{
				return Resources.CommandManager_CommandAttributeMissing.FormatWith(new 
				{
					command = command,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	In order to register command filter instance '{filter}', it must have a [CommandFilter] attribute.
			/// </summary>
			public static string CommandFilterAttributeMissing(object filter)
			{
				return Resources.CommandManager_CommandFilterAttributeMissing.FormatWith(new 
				{
					filter = filter,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	In order to register command interceptor instance '{interceptor}', it must have a [CommandInterceptor] attribute.
			/// </summary>
			public static string CommandInterceptorAttributeMissing(object interceptor)
			{
				return Resources.CommandManager_CommandInterceptorAttributeMissing.FormatWith(new 
				{
					interceptor = interceptor,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Package '{packageId}' does not provide a command with group identifier '{groupId}' and command identifier '{commandId}'.
			/// </summary>
			public static string CommandNotFound(object packageId, object groupId, object commandId)
			{
				return Resources.CommandManager_CommandNotFound.FormatWith(new 
				{
					packageId = packageId,
					groupId = groupId,
					commandId = commandId,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command to filter does not provide the required BeforeQueryStatus event (typically inherited from OleMenuCommand). Filtering cannot be performed. (Package Id: '{packageId}', Group Id: '{groupId}', Command Id '{commandId}')
			/// </summary>
			public static string CommandNotOle(object packageId, object groupId, object commandId)
			{
				return Resources.CommandManager_CommandNotOle.FormatWith(new 
				{
					packageId = packageId,
					groupId = groupId,
					commandId = commandId,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Loaded package with identifier '{packageId}' that owns the command to filter is not a service provider.
			/// </summary>
			public static string CommandPackageNotServiceProvider(object packageId)
			{
				return Resources.CommandManager_CommandPackageNotServiceProvider.FormatWith(new 
				{
					packageId = packageId,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Registered command {commandText} ({commandType}). 
			/// </summary>
			public static string CommandRegistered(object commandText, object commandType)
			{
				return Resources.CommandManager_CommandRegistered.FormatWith(new 
				{
					commandText = commandText,
					commandType = commandType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command with id '{id}' and group '{group}' has already been registered with the menu command service.
			/// </summary>
			public static string DuplicateCommand(object id, object group)
			{
				return Resources.CommandManager_DuplicateCommand.FormatWith(new 
				{
					id = id,
					group = group,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command filter {filter} caused an unexpected exception: {exception}.
			/// </summary>
			public static string FilterFailed(object filter, object exception)
			{
				return Resources.CommandManager_FilterFailed.FormatWith(new 
				{
					filter = filter,
					exception = exception,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command interceptor {interceptor} caused an unexpected exception: {exception}.
			/// </summary>
			public static string InterceptorFailed(object interceptor, object exception)
			{
				return Resources.CommandManager_InterceptorFailed.FormatWith(new 
				{
					interceptor = interceptor,
					exception = exception,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Could not retrieve the menu command service from the package with identifier '{packageId}' that owns the command to filter.
			/// </summary>
			public static string NoMenuCommandService(object packageId)
			{
				return Resources.CommandManager_NoMenuCommandService.FormatWith(new 
				{
					packageId = packageId,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command type '{type}' does not have the required attribute '{attribute}'.
			/// </summary>
			public static string OwningPackageAttributeRequired(object type, object attribute)
			{
				return Resources.CommandManager_OwningPackageAttributeRequired.FormatWith(new 
				{
					type = type,
					attribute = attribute,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command type '{type}' specifies owning package with id '{packageId}' but it could not be found or loaded.
			/// </summary>
			public static string OwningPackageNotFound(object type, object packageId)
			{
				return Resources.CommandManager_OwningPackageNotFound.FormatWith(new 
				{
					type = type,
					packageId = packageId,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command type '{type}' specifies owning package with id '{packageId}' which is not a valid service provider.
			/// </summary>
			public static string OwningPackageNotServiceProvider(object type, object packageId)
			{
				return Resources.CommandManager_OwningPackageNotServiceProvider.FormatWith(new 
				{
					type = type,
					packageId = packageId,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	In order to register all commands for a given package automatically, the owning package '{package}' must have a [Guid] attribute applied, which must match the commands' corresponding [Command] attribute.
			/// </summary>
			public static string PackageGuidMissing(object package)
			{
				return Resources.CommandManager_PackageGuidMissing.FormatWith(new 
				{
					package = package,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Diagnostics
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to create output window for diagnostics traces.
			/// </summary>
			public static string FailedToCreateOutputWindow { get { return Resources.Diagnostics_FailedToCreateOutputWindow; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Hosting
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Unsupported Visual Studio version. Please update Clide.
			/// </summary>
			public static string UnsupportedRuntime { get { return Resources.Hosting_UnsupportedRuntime; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Host
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to initialize host.
			/// </summary>
			public static string FailedToInitialize { get { return Resources.Host_FailedToInitialize; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class General
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Hosting package '{packageType}' does not have the required [Guid] attribute.
			/// </summary>
			public static string MissingGuidAttribute(object packageType)
			{
				return Resources.General_MissingGuidAttribute.FormatWith(new 
				{
					packageType = packageType,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class OptionsManager
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to register page '{pageType}'.
			/// </summary>
			public static string FailedToRegisterPage(object pageType)
			{
				return Resources.OptionsManager_FailedToRegisterPage.FormatWith(new 
				{
					pageType = pageType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The owning package of a page must be a managed package, inheriting from '{managedPackageBaseType}'.
			/// </summary>
			public static string ManagedPackageRequired(object managedPackageBaseType)
			{
				return Resources.OptionsManager_ManagedPackageRequired.FormatWith(new 
				{
					managedPackageBaseType = managedPackageBaseType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Options page specified package owner with Guid '{owningPackageGuid}', but the package could not be found or loaded.
			/// </summary>
			public static string OwningPackageNotFound(object owningPackageGuid)
			{
				return Resources.OptionsManager_OwningPackageNotFound.FormatWith(new 
				{
					owningPackageGuid = owningPackageGuid,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Options page of type '{pageType}' does not provide the required '{owningPackageAttributeType}' attribute.
			/// </summary>
			public static string OwningPackageRequired(object pageType, object owningPackageAttributeType)
			{
				return Resources.OptionsManager_OwningPackageRequired.FormatWith(new 
				{
					pageType = pageType,
					owningPackageAttributeType = owningPackageAttributeType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Options page '{pageType}' must have a Category attribute that specifies the name of the root category node this page shows under in the Tools | Options dialog.
			/// </summary>
			public static string PageCategoryRequired(object pageType)
			{
				return Resources.OptionsManager_PageCategoryRequired.FormatWith(new 
				{
					pageType = pageType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Options page '{pageType}' must have a DisplayName attribute that determines the name of the node under the specified category in the Tools | Options dialog tree.
			/// </summary>
			public static string PageDisplayNameRequired(object pageType)
			{
				return Resources.OptionsManager_PageDisplayNameRequired.FormatWith(new 
				{
					pageType = pageType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Could not find reference to Microsoft.VisualStudio.Shell (either 10.0 or 11.0) on the given package type {packageType}.
			/// </summary>
			public static string ShellReferenceNotFound(object packageType)
			{
				return Resources.OptionsManager_ShellReferenceNotFound.FormatWith(new 
				{
					packageType = packageType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Tools options pages are not supported in this version of Visual Studio.
			/// </summary>
			public static string Unsupported { get { return Resources.OptionsManager_Unsupported; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Trace
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	66893206-0EF5-4A16-AA10-6EC6B6319F92
			/// </summary>
			public static string OutputPaneId { get { return Resources.Trace_OutputPaneId; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Clide
			/// </summary>
			public static string OutputPaneTitle { get { return Resources.Trace_OutputPaneTitle; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Clide
			/// </summary>
			public static string RootSource { get { return Resources.Trace_RootSource; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class SettingsManager
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Cannot persist setting value of type '{valueType}' from property '{owningType}.{propertyName}'. An appropriate type converter that can convert the value to a string is required.
			/// </summary>
			public static string CannotSaveAsString(object valueType, object owningType, object propertyName)
			{
				return Resources.SettingsManager_CannotSaveAsString.FormatWith(new 
				{
					valueType = valueType,
					owningType = owningType,
					propertyName = propertyName,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to read settings class '{settingsType}' from the settings store.
			/// </summary>
			public static string FailedToRead(object settingsType)
			{
				return Resources.SettingsManager_FailedToRead.FormatWith(new 
				{
					settingsType = settingsType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Cannot assign value of type '{valueType}' to property '{owningType}.{propertyName}' of type '{propertyType}'. An appropriate type converter is required.
			/// </summary>
			public static string InvalidValue(object valueType, object owningType, object propertyName, object propertyType)
			{
				return Resources.SettingsManager_InvalidValue.FormatWith(new 
				{
					valueType = valueType,
					owningType = owningType,
					propertyName = propertyName,
					propertyType = propertyType,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class Settings
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Object has already been initialized.
			/// </summary>
			public static string AlreadyInitialized { get { return Resources.Settings_AlreadyInitialized; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	EndEdit invoked without corresponding BeginEdit.
			/// </summary>
			public static string EndEditWithoutBeginEdit { get { return Resources.Settings_EndEditWithoutBeginEdit; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	EndInit invoked without corresponding BeginInit.
			/// </summary>
			public static string EndInitWithoutBeginInit { get { return Resources.Settings_EndInitWithoutBeginInit; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to restore original state when editing was cancelled.
			/// </summary>
			public static string FailedToRestore { get { return Resources.Settings_FailedToRestore; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Settings successfully saved.
			/// </summary>
			public static string TraceSaved { get { return Resources.Settings_TraceSaved; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class SolutionNode
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The solution file is invalid.
			/// </summary>
			public static string InvalidSolutionFile { get { return Resources.SolutionNode_InvalidSolutionFile; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class VsCommandExtensionAdapter
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Attempted to execute command '{commandText}' ({commandType}) but current command status does not allow it.
			/// </summary>
			public static string CannotExecute(object commandText, object commandType)
			{
				return Resources.VsCommandExtensionAdapter_CannotExecute.FormatWith(new 
				{
					commandText = commandText,
					commandType = commandType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command did not execute successfully due to an unexpected exception. Please check the output window for additional information.
			/// </summary>
			public static string ExecuteShieldMessage { get { return Resources.VsCommandExtensionAdapter_ExecuteShieldMessage; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Executing command '{commandText}' ({commandType}).
			/// </summary>
			public static string ExecutingCommand(object commandText, object commandType)
			{
				return Resources.VsCommandExtensionAdapter_ExecutingCommand.FormatWith(new 
				{
					commandText = commandText,
					commandType = commandType,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Command could not determine its current status due to an unexpected exception. Please check the output window for additional information.
			/// </summary>
			public static string QueryStatusShieldMessage { get { return Resources.VsCommandExtensionAdapter_QueryStatusShieldMessage; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class ConfigProjectProperties
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Project '{project}' is not based on MSBuild. Configuration-specific properties cannot be retrieved or set using the standard dynamic properties.
			/// </summary>
			public static string NonMsBuildProject(object project)
			{
				return Resources.ConfigProjectProperties_NonMsBuildProject.FormatWith(new 
				{
					project = project,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Attempted to set property '{property}' for configuration '{configuration}' on project '{project}' which is not based on MSBuild. Configuration-specific user properties cannot be retrieved or set using the standard dynamic properties.
			/// </summary>
			public static string SetNonMsBuildProject(object property, object configuration, object project)
			{
				return Resources.ConfigProjectProperties_SetNonMsBuildProject.FormatWith(new 
				{
					property = property,
					configuration = configuration,
					project = project,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class SolutionTreeNode
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Selecting element '{itemPath}' is not supported by the underlying project type.
			/// </summary>
			public static string SelectionUnsupported(object itemPath)
			{
				return Resources.SolutionTreeNode_SelectionUnsupported.FormatWith(new 
				{
					itemPath = itemPath,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class IProjectNodeExtensions
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to invoke build.
			/// </summary>
			public static string BuildException { get { return Resources.IProjectNodeExtensions_BuildException; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The specified project '{project}' does not have a valid owning solution.
			/// </summary>
			public static string BuildNoSolution(object project)
			{
				return Resources.IProjectNodeExtensions_BuildNoSolution.FormatWith(new 
				{
					project = project,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to load assemly reference '{reference}' from path '{path}'.
			/// </summary>
			public static string FailedToLoadAssembly(object reference, object path)
			{
				return Resources.IProjectNodeExtensions_FailedToLoadAssembly.FormatWith(new 
				{
					reference = reference,
					path = path,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Could not retrieve the required type discovery services from the project.
			/// </summary>
			public static string InvalidTypeContext { get { return Resources.IProjectNodeExtensions_InvalidTypeContext; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Cannot retrieve project types. Project is not a valid Visual Studio project, or the service provider cannot be retrieved from it.
			/// </summary>
			public static string InvalidVsContext { get { return Resources.IProjectNodeExtensions_InvalidVsContext; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Building project '{projectName}' did not generate the expected output assembly '{assemblyFile}'.
			/// </summary>
			public static string NoBuildOutput(object projectName, object assemblyFile)
			{
				return Resources.IProjectNodeExtensions_NoBuildOutput.FormatWith(new 
				{
					projectName = projectName,
					assemblyFile = assemblyFile,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Could not determine the target assembly name for project '{projectName}'. The project TargetFileName and/or TargetDir properties are empty.
			/// </summary>
			public static string NoTargetAssemblyName(object projectName)
			{
				return Resources.IProjectNodeExtensions_NoTargetAssemblyName.FormatWith(new 
				{
					projectName = projectName,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class DevEnvFactory
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	{clideAssembly} cannot be exported as a MEF component in the hosting extension manifest.
			/// </summary>
			public static string ClideCantBeMefComponent(object clideAssembly)
			{
				return Resources.DevEnvFactory_ClideCantBeMefComponent.FormatWith(new 
				{
					clideAssembly = clideAssembly,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The following assemblies are specified as both Clide components and MEF components in the package manifest '{packageManifest}': {assemblies}. This is typically an error and could result in duplicate exports to the global composition container in Visual Studio. If you want to export some components only as MEF components or Clide components, place them in separate assemblies and configure them separately in the manifest.
			/// </summary>
			public static string ClideComponentAlsoMefComponent(object packageManifest, object assemblies)
			{
				return Resources.DevEnvFactory_ClideComponentAlsoMefComponent.FormatWith(new 
				{
					packageManifest = packageManifest,
					assemblies = assemblies,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Found Clide component '{component}' to register for composition at '{componentAssembly}'.
			/// </summary>
			public static string ClideComponentDeclared(object component, object componentAssembly)
			{
				return Resources.DevEnvFactory_ClideComponentDeclared.FormatWith(new 
				{
					component = component,
					componentAssembly = componentAssembly,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The extension manifest file '{packageManifest}' specified a Clide component '{clideComponent}' that was not found at '{assemblyFile}'.
			/// </summary>
			public static string ClideComponentNotFound(object packageManifest, object clideComponent, object assemblyFile)
			{
				return Resources.DevEnvFactory_ClideComponentNotFound.FormatWith(new 
				{
					packageManifest = packageManifest,
					clideComponent = clideComponent,
					assemblyFile = assemblyFile,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The Clide main assembly does not need to be added as Clide component in the extension manifest file '{packageManifest}'.
			/// </summary>
			public static string ClideNotNecessaryAsComponent(object packageManifest)
			{
				return Resources.DevEnvFactory_ClideNotNecessaryAsComponent.FormatWith(new 
				{
					packageManifest = packageManifest,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Composition errors prevented the successfull creation of the development environment API. All {primaryRejectionCount} primary rejection errors will be logged.
			/// </summary>
			public static string CompositionErrors(object primaryRejectionCount)
			{
				return Resources.DevEnvFactory_CompositionErrors.FormatWith(new 
				{
					primaryRejectionCount = primaryRejectionCount,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Initializing development environment composition.
			/// </summary>
			public static string CreatingComposition { get { return Resources.DevEnvFactory_CreatingComposition; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Detected hosting package installation path at '{installPath}'.
			/// </summary>
			public static string DetectedInstallPath(object installPath)
			{
				return Resources.DevEnvFactory_DetectedInstallPath.FormatWith(new 
				{
					installPath = installPath,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Extension manifest for hosting package found at '{manifestFile}'.
			/// </summary>
			public static string ExtensionManifestFound(object manifestFile)
			{
				return Resources.DevEnvFactory_ExtensionManifestFound.FormatWith(new 
				{
					manifestFile = manifestFile,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Extension manifest for hosting package not found at expected location '{manifestFile}'.
			/// </summary>
			public static string ExtensionManifestNotFound(object manifestFile)
			{
				return Resources.DevEnvFactory_ExtensionManifestNotFound.FormatWith(new 
				{
					manifestFile = manifestFile,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class IServiceProviderExtensions
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Specified package type '{packageType}' does not have the required [Guid] attribute.
			/// </summary>
			public static string MissingGuidAttribute(object packageType)
			{
				return Resources.IServiceProviderExtensions_MissingGuidAttribute.FormatWith(new 
				{
					packageType = packageType,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class ComponentModelExtensions
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The given export provider '{provider}' does not implement the required ICompositionService interface.
			/// </summary>
			public static string ExportProviderIsNotCompositionService(object provider)
			{
				return Resources.ComponentModelExtensions_ExportProviderIsNotCompositionService.FormatWith(new 
				{
					provider = provider,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class ISolutionNodeExtensions
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to invoke build.
			/// </summary>
			public static string BuildException { get { return Resources.ISolutionNodeExtensions_BuildException; } }
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	The specified solution does not support builds.
			/// </summary>
			public static string BuildNotSupported { get { return Resources.ISolutionNodeExtensions_BuildNotSupported; } }
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class CompositionSource
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	In order to retrieve the multiple components of type {componentType} from Visual Studio composition, the [ImportMany] annotation has to be used.
			/// </summary>
			public static string ImportManyRequired(object componentType)
			{
				return Resources.CompositionSource_ImportManyRequired.FormatWith(new 
				{
					componentType = componentType,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class OutputWindowManager
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Creating output pane '{title}' since it doesn't exist already.
			/// </summary>
			public static string CreatingPane(object title)
			{
				return Resources.OutputWindowManager_CreatingPane.FormatWith(new 
				{
					title = title,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Failed to create output window pane '{title}'.
			/// </summary>
			public static string FailedToCreatePane(object title)
			{
				return Resources.OutputWindowManager_FailedToCreatePane.FormatWith(new 
				{
					title = title,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Retrieving potentially existing output pane '{title}'.
			/// </summary>
			public static string RetrievingPane(object title)
			{
				return Resources.OutputWindowManager_RetrievingPane.FormatWith(new 
				{
					title = title,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Initializing trace output pane '{title}'.
			/// </summary>
			public static string TraceInitializing(object title)
			{
				return Resources.OutputWindowManager_TraceInitializing.FormatWith(new 
				{
					title = title,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class UserProjectProperties
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Project '{project}' is not based on MSBuild. User properties cannot be retrieved or set using the standard dynamic properties.
			/// </summary>
			public static string NonMsBuildProject(object project)
			{
				return Resources.UserProjectProperties_NonMsBuildProject.FormatWith(new 
				{
					project = project,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Attempted to set property '{property}' on project '{project}' which is not based on MSBuild. User properties cannot be retrieved or set using the standard dynamic properties.
			/// </summary>
			public static string SetNonMsBuildProject(object property, object project)
			{
				return Resources.UserProjectProperties_SetNonMsBuildProject.FormatWith(new 
				{
					property = property,
					project = project,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class ConfigUserProjectProperties
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Project '{project}' is not based on MSBuild. Configuration-specific properties for '{configuration}' cannot be retrieved or set using the standard dynamic properties.
			/// </summary>
			public static string NonMsBuildProject(object project, object configuration)
			{
				return Resources.ConfigUserProjectProperties_NonMsBuildProject.FormatWith(new 
				{
					project = project,
					configuration = configuration,
				});
			}
		
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Attempted to set property '{property}' for configuration '{configuration}' on project '{project}' which is not based on MSBuild. Configuration-specific user properties cannot be retrieved or set using the standard dynamic properties.
			/// </summary>
			public static string SetNonMsBuildProject(object property, object configuration, object project)
			{
				return Resources.ConfigUserProjectProperties_SetNonMsBuildProject.FormatWith(new 
				{
					property = property,
					configuration = configuration,
					project = project,
				});
			}
		}
		
		///	<summary>
		///	Provides access to string resources.
		///	</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("netfx-System.Strings", "1.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public static partial class ISolutionExplorerNodeExtensions
		{
			/// <summary>
			/// Looks up a localized string similar to: 
			///	Node '{ancestor}' is not an ancestor of '{descendent}'.
			/// </summary>
			public static string NotAncestor(object ancestor, object descendent)
			{
				return Resources.ISolutionExplorerNodeExtensions_NotAncestor.FormatWith(new 
				{
					ancestor = ancestor,
					descendent = descendent,
				});
			}
		}
	}
}

