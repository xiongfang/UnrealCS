// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _FPaths
	{
		/**
		* Should the "saved" directory structures be rooted in the user dir or relative to the "engine/game"
		*/
		static bool ShouldSaveToUserDir()
		{
			return FPaths::ShouldSaveToUserDir();
		}

		/**
		* Returns the directory the application was launched from (useful for commandline utilities)
		*/
		static MonoString* LaunchDir()
		{
			return FStringToMonoString(FPaths::LaunchDir());
		}

		/**
		* Returns the base directory of the "core" engine that can be shared across
		* several games or across games & mods. Shaders and base localization files
		* e.g. reside in the engine directory.
		*
		* @return engine directory
		*/
		static MonoString* EngineDir()
		{
			return FStringToMonoString(FPaths::EngineDir());
		}

		/**
		* Returns the root directory for user-specific engine files. Always writable.
		*
		* @return root user directory
		*/
		static MonoString* EngineUserDir()
		{
			return FStringToMonoString(FPaths::EngineUserDir());
		}

		/**
		* Returns the root directory for user-specific engine files which can be shared between versions. Always writable.
		*
		* @return root user directory
		*/
		static MonoString* EngineVersionAgnosticUserDir()
		{
			return FStringToMonoString(FPaths::EngineVersionAgnosticUserDir());
		}

		/**
		* Returns the content directory of the "core" engine that can be shared across
		* several games or across games & mods.
		*
		* @return engine content directory
		*/
		static MonoString* EngineContentDir()
		{
			return FStringToMonoString(FPaths::EngineContentDir());
		}

		/**
		* Returns the directory the root configuration files are located.
		*
		* @return root config directory
		*/
		static MonoString* EngineConfigDir()
		{
			return FStringToMonoString(FPaths::EngineConfigDir());
		}

		/**
		* Returns the intermediate directory of the engine
		*
		* @return content directory
		*/
		static MonoString* EngineIntermediateDir()
		{
			return FStringToMonoString(FPaths::EngineIntermediateDir());
		}

		/**
		* Returns the saved directory of the engine
		*
		* @return Saved directory.
		*/
		static MonoString* EngineSavedDir()
		{
			return FStringToMonoString(FPaths::EngineSavedDir());
		}

		/**
		* Returns the plugins directory of the engine
		*
		* @return Plugins directory.
		*/
		static MonoString* EnginePluginsDir()
		{
			return FStringToMonoString(FPaths::EnginePluginsDir());
		}

		/**
		* Returns the root directory of the engine directory tree
		*
		* @return Root directory.
		*/
		static MonoString* RootDir()
		{
			return FStringToMonoString(FPaths::RootDir());
		}

		/**
		* Returns the base directory of the current game by looking at FApp::GetGameName().
		* This is usually a subdirectory of the installation
		* root directory and can be overridden on the command line to allow self
		* contained mod support.
		*
		* @return base directory
		*/
		static MonoString* GameDir()
		{
			return FStringToMonoString(FPaths::GameDir());
		}

		/**
		* Returns the root directory for user-specific game files.
		*
		* @return game user directory
		*/
		static MonoString* GameUserDir()
		{
			return FStringToMonoString(FPaths::GameUserDir());
		}

		/**
		* Returns the content directory of the current game by looking at FApp::GetGameName().
		*
		* @return content directory
		*/
		static MonoString* GameContentDir()
		{
			return FStringToMonoString(FPaths::GameContentDir());
		}

		/**
		* Returns the directory the root configuration files are located.
		*
		* @return root config directory
		*/
		static MonoString* GameConfigDir()
		{
			return FStringToMonoString(FPaths::GameConfigDir());
		}

		/**
		* Returns the saved directory of the current game by looking at FApp::GetGameName().
		*
		* @return saved directory
		*/
		static MonoString* GameSavedDir()
		{
			return FStringToMonoString(FPaths::GameSavedDir());
		}

		/**
		* Returns the intermediate directory of the current game by looking at FApp::GetGameName().
		*
		* @return intermediate directory
		*/
		static MonoString* GameIntermediateDir()
		{
			return FStringToMonoString(FPaths::GameIntermediateDir());
		}

		/**
		* Returns the plugins directory of the current game by looking at FApp::GetGameName().
		*
		* @return plugins directory
		*/
		static MonoString* GamePluginsDir()
		{
			return FStringToMonoString(FPaths::GamePluginsDir());
		}

		/*
		* Returns the writable directory for downloaded data that persists across play sessions.
		*/
		static MonoString* GamePersistentDownloadDir()
		{
			return FStringToMonoString(FPaths::GamePersistentDownloadDir());
		}

		/**
		* Returns the directory the engine uses to look for the source leaf ini files. This
		* can't be an .ini variable for obvious reasons.
		*
		* @return source config directory
		*/
		static MonoString* SourceConfigDir()
		{
			return FStringToMonoString(FPaths::SourceConfigDir());
		}

		/**
		* Returns the directory the engine saves generated config files.
		*
		* @return config directory
		*/
		static MonoString* GeneratedConfigDir()
		{
			return FStringToMonoString(FPaths::GeneratedConfigDir());
		}

		/**
		* Returns the directory the engine stores sandbox output
		*
		* @return sandbox directory
		*/
		static MonoString* SandboxesDir()
		{
			return FStringToMonoString(FPaths::SandboxesDir());
		}

		/**
		* Returns the directory the engine uses to output profiling files.
		*
		* @return log directory
		*/
		static MonoString* ProfilingDir()
		{
			return FStringToMonoString(FPaths::ProfilingDir());
		}

		/**
		* Returns the directory the engine uses to output screenshot files.
		*
		* @return screenshot directory
		*/
		static MonoString* ScreenShotDir()
		{
			return FStringToMonoString(FPaths::ScreenShotDir());
		}

		/**
		* Returns the directory the engine uses to output BugIt files.
		*
		* @return screenshot directory
		*/
		static MonoString* BugItDir()
		{
			return FStringToMonoString(FPaths::BugItDir());
		}

		/**
		* Returns the directory the engine uses to output user requested video capture files.
		*
		* @return Video capture directory
		*/
		static MonoString* VideoCaptureDir()
		{
			return FStringToMonoString(FPaths::VideoCaptureDir());
		}

		/**
		* Returns the directory the engine uses to output logs. This currently can't
		* be an .ini setting as the game starts logging before it can read from .ini
		* files.
		*
		* @return log directory
		*/
		static MonoString* GameLogDir()
		{
			return FStringToMonoString(FPaths::GameLogDir());
		}

		/**
		* @return The directory for automation save files
		*/
		static MonoString* AutomationDir()
		{
			return FStringToMonoString(FPaths::AutomationDir());
		}

		/**
		* @return The directory for automation save files that are meant to be deleted every run
		*/
		static MonoString* AutomationTransientDir()
		{
			return FStringToMonoString(FPaths::AutomationTransientDir());
		}

		/**
		* @return The directory for automation log files.
		*/
		static MonoString* AutomationLogDir()
		{
			return FStringToMonoString(FPaths::AutomationLogDir());
		}

		/**
		* @return The directory for local files used in cloud emulation or support
		*/
		static MonoString* CloudDir()
		{
			return FStringToMonoString(FPaths::CloudDir());
		}

		/**
		* @return The directory that contains subfolders for developer-specific content
		*/
		static MonoString* GameDevelopersDir()
		{
			return FStringToMonoString(FPaths::GameDevelopersDir());
		}

		/**
		* @return The directory that contains developer-specific content for the current user
		*/
		static MonoString* GameUserDeveloperDir()
		{
			return FStringToMonoString(FPaths::GameUserDeveloperDir());
		}

		/**
		* @return The directory for temp files used for diff'ing
		*/
		static MonoString* DiffDir()
		{
			return FStringToMonoString(FPaths::DiffDir());
		}


		///**
		//* Returns a list of engine-specific localization paths
		//*/
		//static const TArray<FString>& GetEngineLocalizationPaths()
		//{
		//	return FPaths::GetEngineLocalizationPaths();
		//}

		///**
		//* Returns a list of editor-specific localization paths
		//*/
		//static const TArray<FString>& GetEditorLocalizationPaths()
		//{
		//	return FPaths::GetEditorLocalizationPaths();
		//}

		///**
		//* Returns a list of property name localization paths
		//*/
		//static const TArray<FString>& GetPropertyNameLocalizationPaths()
		//{
		//	return FPaths::GetPropertyNameLocalizationPaths();
		//}

		///**
		//* Returns a list of tool tip localization paths
		//*/
		//static const TArray<FString>& GetToolTipLocalizationPaths()
		//{
		//	return FPaths::GetToolTipLocalizationPaths();
		//}

		///**
		//* Returns a list of game-specific localization paths
		//*/
		//static const TArray<FString>& GetGameLocalizationPaths()
		//{
		//	return FPaths::GetGameLocalizationPaths();
		//}

		/**
		* Returns the saved directory that is not game specific. This is usually the same as
		* EngineSavedDir().
		*
		* @return saved directory
		*/
		static MonoString* GameAgnosticSavedDir()
		{
			return FStringToMonoString(FPaths::GameAgnosticSavedDir());
		}

		/**
		* @return The directory where engine source code files are kept
		*/
		static MonoString* EngineSourceDir()
		{
			return FStringToMonoString(FPaths::EngineSourceDir());
		}

		/**
		* @return The directory where game source code files are kept
		*/
		static MonoString* GameSourceDir()
		{
			return FStringToMonoString(FPaths::GameSourceDir());
		}

		/**
		* @return The directory where feature packs are kept
		*/
		static MonoString* FeaturePackDir()
		{
			return FStringToMonoString(FPaths::FeaturePackDir());
		}

		///**
		//* Checks whether the path to the project file, if any, is set.
		//*
		//* @return true if the path is set, false otherwise.
		//*/
		//static int32 IsProjectFilePathSet()
		//{
		//	return FPaths::IsProjectFilePathSet()!=0;
		//}

		///**
		//* Gets the path to the project file.
		//*
		//* @return Project file path.
		//*/
		//static MonoString* GetProjectFilePath()
		//{
		//	return FStringToMonoString(FPaths::GetProjectFilePath());
		//}

		///**
		//* Sets the path to the project file.
		//*
		//* @param NewGameProjectFilePath - The project file path to set.
		//*/
		//static void SetProjectFilePath(const FString& NewGameProjectFilePath);

		///**
		//* Gets the extension for this filename.
		//*
		//* @param	bIncludeDot		if true, includes the leading dot in the result
		//*
		//* @return	the extension of this filename, or an empty string if the filename doesn't have an extension.
		//*/
		//static FString GetExtension(const FString& InPath, bool bIncludeDot = false);

		//// Returns the filename (with extension), minus any path information.
		//static FString GetCleanFilename(const FString& InPath);

		//// Returns the filename (with extension), minus any path information.
		//static FString GetCleanFilename(FString&& InPath);

		//// Returns the same thing as GetCleanFilename, but without the extension
		//static FString GetBaseFilename(const FString& InPath, bool bRemovePath = true);

		// Returns the path in front of the filename
		//static MonoString* GetPath(const FString& InPath)
		//{
		//	return FStringToMonoString(FPaths::GetPath(InPath));
		//}

		// Returns the path in front of the filename
		//static FString GetPath(FString&& InPath);

		//// Changes the extension of the given filename
		//static FString ChangeExtension(const FString& InPath, const FString& InNewExtension);

		///** @return true if this file was found, false otherwise */
		//static bool FileExists(const FString& InPath);

		///** @return true if this directory was found, false otherwise */
		//static bool DirectoryExists(const FString& InPath);

		///** @return true if this path represents a drive */
		//static bool IsDrive(const FString& InPath);

		///** @return true if this path is relative */
		//static bool IsRelative(const FString& InPath);

		///** Convert all / and \ to TEXT("/") */
		//static void NormalizeFilename(FString& InPath);

		/**
		* Checks if two paths are the same.
		*
		* @param PathA First path to check.
		* @param PathB Second path to check.
		*
		* @returns True if both paths are the same. False otherwise.
		*/
		//static bool IsSamePath(const FString& PathA, const FString& PathB);

		/** Normalize all / and \ to TEXT("/") and remove any trailing TEXT("/") if the character before that is not a TEXT("/") or a colon */
		//static void NormalizeDirectoryName(FString& InPath);

		/**
		* Takes a fully pathed string and eliminates relative pathing (eg: annihilates ".." with the adjacent directory).
		* Assumes all slashes have been converted to TEXT('/').
		* For example, takes the string:
		*	BaseDirectory/SomeDirectory/../SomeOtherDirectory/Filename.ext
		* and converts it to:
		*	BaseDirectory/SomeOtherDirectory/Filename.ext
		*/
		static int32 CollapseRelativeDirectories(MonoString** InPath)
		{
			FString InPathStr = MonoStringToFString(*InPath);
			bool ret = FPaths::CollapseRelativeDirectories(InPathStr);
			*InPath = FStringToMonoString(InPathStr);
			return ret ? 1 : 0;
		}

		/**
		* Removes duplicate slashes in paths.
		* Assumes all slashes have been converted to TEXT('/').
		* For example, takes the string:
		*	BaseDirectory/SomeDirectory//SomeOtherDirectory////Filename.ext
		* and converts it to:
		*	BaseDirectory/SomeDirectory/SomeOtherDirectory/Filename.ext
		*/
		//static void RemoveDuplicateSlashes(FString& InPath);

		/**
		* Make fully standard "Unreal" pathname:
		*    - Normalizes path separators [NormalizeFilename]
		*    - Removes extraneous separators  [NormalizeDirectoryName, as well removing adjacent separators]
		*    - Collapses internal ..'s
		*    - Makes relative to Engine\Binaries\<Platform> (will ALWAYS start with ..\..\..)
		*/
		static void MakeStandardFilename(MonoString** InPath)
		{
			FString InPathStr = MonoStringToFString(*InPath);
			FPaths::MakeStandardFilename(InPathStr);
			*InPath = FStringToMonoString(InPathStr);
		}

		/** Takes an "Unreal" pathname and converts it to a platform filename. */
		static void MakePlatformFilename(MonoString** InPath)
		{
			FString InPathStr = MonoStringToFString(*InPath);
			FPaths::MakePlatformFilename(InPathStr);
			*InPath = FStringToMonoString(InPathStr);
		}

		/**
		* Assuming both paths (or filenames) are relative to the base dir, find the relative path to the InPath.
		*
		* @Param InPath Path to make this path relative to.
		* @return Path relative to InPath.
		*/
		//static bool MakePathRelativeTo(FString& InPath, const TCHAR* InRelativeTo);

		/**
		* Converts a relative path name to a fully qualified name relative to the process BaseDir().
		*/
		static MonoString* ConvertRelativePathToFull(MonoString* InPath)
		{
			FString InPathStr = MonoStringToFString(InPath);
			FPaths::ConvertRelativePathToFull(InPathStr);
			return FStringToMonoString(InPathStr);
		}

		/**
		* Converts a relative path name to a fully qualified name relative to the process BaseDir().
		*/
		//static FString ConvertRelativePathToFull(FString&& InPath);

		///**
		//* Converts a relative path name to a fully qualified name relative to the specified BasePath.
		//*/
		//static FString ConvertRelativePathToFull(const FString& BasePath, const FString& InPath);

		///**
		//* Converts a relative path name to a fully qualified name relative to the specified BasePath.
		//*/
		//static FString ConvertRelativePathToFull(const FString& BasePath, FString&& InPath);

		///**
		//* Converts a relative path name to a fully qualified name relative to the specified BasePath.
		//*/
		//static FString ConvertRelativePathToFull(FString&& BasePath, const FString& InPath);

		///**
		//* Converts a relative path name to a fully qualified name relative to the specified BasePath.
		//*/
		//static FString ConvertRelativePathToFull(FString&& BasePath, FString&& InPath);

		/**
		* Converts a normal path to a sandbox path (in Saved/Sandboxes).
		*
		* @param InSandboxName The name of the sandbox.
		*/
		//static FString ConvertToSandboxPath(const FString& InPath, const TCHAR* InSandboxName);

		/**
		* Converts a sandbox (in Saved/Sandboxes) path to a normal path.
		*
		* @param InSandboxName The name of the sandbox.
		*/
		//static FString ConvertFromSandboxPath(const FString& InPath, const TCHAR* InSandboxName);
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.FPaths::ShouldSaveToUserDir", (const void*)ShouldSaveToUserDir);
			mono_add_internal_call("UnrealEngine.FPaths::LaunchDir", (const void*)LaunchDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineDir", (const void*)EngineDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineUserDir", (const void*)EngineUserDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineVersionAgnosticUserDir", (const void*)EngineVersionAgnosticUserDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineContentDir", (const void*)EngineContentDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineConfigDir", (const void*)EngineConfigDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineIntermediateDir", (const void*)EngineIntermediateDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineSavedDir", (const void*)EngineSavedDir);
			mono_add_internal_call("UnrealEngine.FPaths::EnginePluginsDir", (const void*)EnginePluginsDir);
			mono_add_internal_call("UnrealEngine.FPaths::RootDir", (const void*)RootDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameDir", (const void*)GameDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameUserDir", (const void*)GameUserDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameContentDir", (const void*)GameContentDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameConfigDir", (const void*)GameConfigDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameSavedDir", (const void*)GameSavedDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameIntermediateDir", (const void*)GameIntermediateDir);
			mono_add_internal_call("UnrealEngine.FPaths::GamePluginsDir", (const void*)GamePluginsDir);
			mono_add_internal_call("UnrealEngine.FPaths::GamePersistentDownloadDir", (const void*)GamePersistentDownloadDir);
			mono_add_internal_call("UnrealEngine.FPaths::SourceConfigDir", (const void*)SourceConfigDir);

			mono_add_internal_call("UnrealEngine.FPaths::GeneratedConfigDir", (const void*)GeneratedConfigDir);
			mono_add_internal_call("UnrealEngine.FPaths::SandboxesDir", (const void*)SandboxesDir);
			mono_add_internal_call("UnrealEngine.FPaths::ProfilingDir", (const void*)ProfilingDir);
			mono_add_internal_call("UnrealEngine.FPaths::ScreenShotDir", (const void*)ScreenShotDir);
			mono_add_internal_call("UnrealEngine.FPaths::BugItDir", (const void*)BugItDir);
			mono_add_internal_call("UnrealEngine.FPaths::VideoCaptureDir", (const void*)VideoCaptureDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameLogDir", (const void*)GameLogDir);
			mono_add_internal_call("UnrealEngine.FPaths::AutomationDir", (const void*)AutomationDir);
			mono_add_internal_call("UnrealEngine.FPaths::AutomationTransientDir", (const void*)AutomationTransientDir);
			mono_add_internal_call("UnrealEngine.FPaths::AutomationLogDir", (const void*)AutomationLogDir);

			mono_add_internal_call("UnrealEngine.FPaths::CloudDir", (const void*)CloudDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameDevelopersDir", (const void*)GameDevelopersDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameUserDeveloperDir", (const void*)GameUserDeveloperDir);
			mono_add_internal_call("UnrealEngine.FPaths::DiffDir", (const void*)DiffDir);


			mono_add_internal_call("UnrealEngine.FPaths::GameAgnosticSavedDir", (const void*)GameAgnosticSavedDir);
			mono_add_internal_call("UnrealEngine.FPaths::EngineSourceDir", (const void*)EngineSourceDir);
			mono_add_internal_call("UnrealEngine.FPaths::GameSourceDir", (const void*)GameSourceDir);
			mono_add_internal_call("UnrealEngine.FPaths::FeaturePackDir", (const void*)FeaturePackDir);
			mono_add_internal_call("UnrealEngine.FPaths::CollapseRelativeDirectories", (const void*)CollapseRelativeDirectories);
			mono_add_internal_call("UnrealEngine.FPaths::MakeStandardFilename", (const void*)MakeStandardFilename);
			mono_add_internal_call("UnrealEngine.FPaths::MakePlatformFilename", (const void*)MakePlatformFilename);
			mono_add_internal_call("UnrealEngine.FPaths::ConvertRelativePathToFull", (const void*)ConvertRelativePathToFull);
		}
	};
}