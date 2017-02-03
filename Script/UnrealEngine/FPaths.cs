using System.Runtime.CompilerServices;

namespace UnrealEngine
{
    public class FPaths
    {

        /**
	     * Should the "saved" directory structures be rooted in the user dir or relative to the "engine/game" 
	     */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool ShouldSaveToUserDir();

        /**
         * Returns the directory the application was launched from (useful for commandline utilities)
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string LaunchDir();

        /** 
         * Returns the base directory of the "core" engine that can be shared across
         * several games or across games & mods. Shaders and base localization files
         * e.g. reside in the engine directory.
         *
         * @return engine directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineDir();

        /**
        * Returns the root directory for user-specific engine files. Always writable.
        *
        * @return root user directory
        */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineUserDir();

        /**
        * Returns the root directory for user-specific engine files which can be shared between versions. Always writable.
        *
        * @return root user directory
        */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineVersionAgnosticUserDir();

        /** 
         * Returns the content directory of the "core" engine that can be shared across
         * several games or across games & mods. 
         *
         * @return engine content directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineContentDir();

        /**
         * Returns the directory the root configuration files are located.
         *
         * @return root config directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineConfigDir();

        /**
         * Returns the intermediate directory of the engine
         *
         * @return content directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineIntermediateDir();

        /**
         * Returns the saved directory of the engine
         *
         * @return Saved directory.
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EngineSavedDir();

        /**
         * Returns the plugins directory of the engine
         *
         * @return Plugins directory.
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string EnginePluginsDir();

        /**
         * Returns the root directory of the engine directory tree
         *
         * @return Root directory.
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string RootDir();

        /**
         * Returns the base directory of the current game by looking at FApp::GetGameName().
         * This is usually a subdirectory of the installation
         * root directory and can be overridden on the command line to allow self
         * contained mod support.
         *
         * @return base directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameDir();

        /**
        * Returns the root directory for user-specific game files.
        *
        * @return game user directory
        */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameUserDir();

        /**
         * Returns the content directory of the current game by looking at FApp::GetGameName().
         *
         * @return content directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameContentDir();

        /**
        * Returns the directory the root configuration files are located.
        *
        * @return root config directory
        */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameConfigDir();

        /**
         * Returns the saved directory of the current game by looking at FApp::GetGameName().
         *
         * @return saved directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameSavedDir();

        /**
         * Returns the intermediate directory of the current game by looking at FApp::GetGameName().
         *
         * @return intermediate directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameIntermediateDir();

        /**
         * Returns the plugins directory of the current game by looking at FApp::GetGameName().
         *
         * @return plugins directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GamePluginsDir();

        /*
        * Returns the writable directory for downloaded data that persists across play sessions.
        */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GamePersistentDownloadDir();

        /**
         * Returns the directory the engine uses to look for the source leaf ini files. This
         * can't be an .ini variable for obvious reasons.
         *
         * @return source config directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string SourceConfigDir();

        /**
         * Returns the directory the engine saves generated config files.
         *
         * @return config directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GeneratedConfigDir();

        /**
         * Returns the directory the engine stores sandbox output
         *
         * @return sandbox directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string SandboxesDir();

        /**
         * Returns the directory the engine uses to output profiling files.
         *
         * @return log directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string ProfilingDir();

        /**
         * Returns the directory the engine uses to output screenshot files.
         *
         * @return screenshot directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string ScreenShotDir();

        /**
         * Returns the directory the engine uses to output BugIt files.
         *
         * @return screenshot directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string BugItDir();

        /**
         * Returns the directory the engine uses to output user requested video capture files.
         *
         * @return Video capture directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string VideoCaptureDir();

        /**
         * Returns the directory the engine uses to output logs. This currently can't 
         * be an .ini setting as the game starts logging before it can read from .ini
         * files.
         *
         * @return log directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameLogDir();

        /**
         * @return The directory for automation save files
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string AutomationDir();

        /**
         * @return The directory for automation save files that are meant to be deleted every run
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string AutomationTransientDir();

        /**
        * @return The directory for automation log files.
        */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string AutomationLogDir();

        /**
         * @return The directory for local files used in cloud emulation or support
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string CloudDir();

        /**
	    * @return The directory that contains subfolders for developer-specific content
	    */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameDevelopersDir();

        /**
         * @return The directory that contains developer-specific content for the current user
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GameUserDeveloperDir();

        /**
         * @return The directory for temp files used for diff'ing
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string DiffDir();


        //  /** 
        //* Returns a list of engine-specific localization paths
        //*/
        //  static const TArray<FString>& GetEngineLocalizationPaths();

        //  /** 
        //   * Returns a list of editor-specific localization paths
        //   */
        //  static const TArray<FString>& GetEditorLocalizationPaths();

        //  /** 
        //   * Returns a list of property name localization paths
        //   */
        //  static const TArray<FString>& GetPropertyNameLocalizationPaths();

        //  /** 
        //* Returns a list of tool tip localization paths
        //*/
        //  static const TArray<FString>& GetToolTipLocalizationPaths();

        //  /** 
        //   * Returns a list of game-specific localization paths
        //   */
        //  static const TArray<FString>& GetGameLocalizationPaths();

        /**
         * Returns the saved directory that is not game specific. This is usually the same as
         * EngineSavedDir().
         *
         * @return saved directory
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern string GameAgnosticSavedDir();

        /**
         * @return The directory where engine source code files are kept
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern string EngineSourceDir();

        /**
         * @return The directory where game source code files are kept
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern string GameSourceDir();

        /**
         * @return The directory where feature packs are kept
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern string FeaturePackDir();

        //       /**
        //        * Checks whether the path to the project file, if any, is set.
        //        *
        //        * @return true if the path is set, false otherwise.
        //        */
        //       static bool IsProjectFilePathSet();

        //       /**
        //        * Gets the path to the project file.
        //        *
        //        * @return Project file path.
        //        */
        //       static const FString& GetProjectFilePath();

        //       /**
        //        * Sets the path to the project file.
        //        *
        //        * @param NewGameProjectFilePath - The project file path to set.
        //        */
        //       static void SetProjectFilePath( const FString& NewGameProjectFilePath );

        ///**
        // * Gets the extension for this filename.
        // *
        // * @param	bIncludeDot		if true, includes the leading dot in the result
        // *
        // * @return	the extension of this filename, or an empty string if the filename doesn't have an extension.
        // */
        //static FString GetExtension( const FString& InPath, bool bIncludeDot = false );

        //       // Returns the filename (with extension), minus any path information.
        //       static FString GetCleanFilename(const FString& InPath);

        //// Returns the filename (with extension), minus any path information.
        //static FString GetCleanFilename(FString&& InPath);

        //       // Returns the same thing as GetCleanFilename, but without the extension
        //       static FString GetBaseFilename( const FString& InPath, bool bRemovePath = true );

        //       // Returns the path in front of the filename
        //       static FString GetPath(const FString& InPath);

        //// Returns the path in front of the filename
        //static FString GetPath(FString&& InPath);

        //       // Changes the extension of the given filename
        //       static FString ChangeExtension(const FString& InPath, const FString& InNewExtension);

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

        //       /**
        //        * Checks if two paths are the same.
        //        *
        //        * @param PathA First path to check.
        //        * @param PathB Second path to check.
        //        *
        //        * @returns True if both paths are the same. False otherwise.
        //        */
        //       static bool IsSamePath(const FString& PathA, const FString& PathB);

        ///** Normalize all / and \ to TEXT("/") and remove any trailing TEXT("/") if the character before that is not a TEXT("/") or a colon */
        //static void NormalizeDirectoryName(FString& InPath);

        /**
         * Takes a fully pathed string and eliminates relative pathing (eg: annihilates ".." with the adjacent directory).
         * Assumes all slashes have been converted to TEXT('/').
         * For example, takes the string:
         *	BaseDirectory/SomeDirectory/../SomeOtherDirectory/Filename.ext
         * and converts it to:
         *	BaseDirectory/SomeOtherDirectory/Filename.ext
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        static extern int CollapseRelativeDirectories(ref string InPath);

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
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void MakeStandardFilename(ref string InPath);

        /** Takes an "Unreal" pathname and converts it to a platform filename. */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern void MakePlatformFilename(ref string InPath);

        /** 
         * Assuming both paths (or filenames) are relative to the base dir, find the relative path to the InPath.
         *
         * @Param InPath Path to make this path relative to.
         * @return Path relative to InPath.
         */
        //static bool MakePathRelativeTo(FString& InPath, const TCHAR* InRelativeTo );

        /**
         * Converts a relative path name to a fully qualified name relative to the process BaseDir().
         */
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public static extern string ConvertRelativePathToFull(string InPath);

        ///**
        // * Converts a relative path name to a fully qualified name relative to the process BaseDir().
        // */
        //static FString ConvertRelativePathToFull(FString&& InPath);

        //       /**
        //        * Converts a relative path name to a fully qualified name relative to the specified BasePath.
        //        */
        //       static FString ConvertRelativePathToFull(const FString& BasePath, const FString& InPath);

        ///**
        // * Converts a relative path name to a fully qualified name relative to the specified BasePath.
        // */
        //static FString ConvertRelativePathToFull(const FString& BasePath, FString&& InPath);

        ///**
        // * Converts a relative path name to a fully qualified name relative to the specified BasePath.
        // */
        //static FString ConvertRelativePathToFull(FString&& BasePath, const FString& InPath);

        ///**
        // * Converts a relative path name to a fully qualified name relative to the specified BasePath.
        // */
        //static FString ConvertRelativePathToFull(FString&& BasePath, FString&& InPath);

        //       /**
        //        * Converts a normal path to a sandbox path (in Saved/Sandboxes).
        //        *
        //        * @param InSandboxName The name of the sandbox.
        //        */
        //       static FString ConvertToSandboxPath( const FString& InPath, const TCHAR* InSandboxName );

        //       /**
        //        * Converts a sandbox (in Saved/Sandboxes) path to a normal path.
        //        *
        //        * @param InSandboxName The name of the sandbox.
        //        */
        //       static FString ConvertFromSandboxPath( const FString& InPath, const TCHAR* InSandboxName );
    }
}
