using System;
namespace UnrealEngine
{
	public partial class ULevelStreaming:UObject
	{
		/// <summary>Returns the Level Script Actor of the level if the level is loaded and valid</summary>
		public extern ALevelScriptActor GetLevelScriptActor();
		/// <summary>Returns whether level has streaming state change pending</summary>
		public extern bool IsStreamingStatePending();
		/// <summary>Returns whether streaming level is loaded</summary>
		public extern bool IsLevelLoaded();
		/// <summary>Returns whether streaming level is visible</summary>
		public extern bool IsLevelVisible();
		/// <summary>Deprecated name of the package containing the level to load. Use GetWorldAsset() or GetWorldAssetPackageFName() instead.</summary>
		public FName PackageName;
		
		/// <summary>If this isn't Name_None, then we load from this package on disk to the new package named PackageName</summary>
		public FName PackageNameToLoad;
		
		/// <summary>Transform applied to actors after loading.</summary>
		public FTransform LevelTransform;
		
		/// <summary>Whether this level should be visible in the Editor</summary>
		public bool bShouldBeVisibleInEditor;
		
		/// <summary>Whether this level is locked; that is, its actors are read-only.</summary>
		public bool bLocked;
		
		/// <summary>Whether the level should be loaded</summary>
		public bool bShouldBeLoaded;
		
		/// <summary>Whether the level should be visible if it is loaded</summary>
		public bool bShouldBeVisible;
		
		/// <summary>
		/// Whether this level only contains static actors that aren't affected by gameplay or replication.
		/// If true, the engine can make certain optimizations and will add this level to the StaticLevels collection.
		/// </summary>
		public bool bIsStatic;
		
		/// <summary>Whether we want to force a blocking load</summary>
		public bool bShouldBlockOnLoad;
		
		/// <summary>Requested LOD. Non LOD sub-levels have Index = -1</summary>
		public int LevelLODIndex;
		
		/// <summary>
		/// Whether this level streaming object should be ignored by world composition distance streaming,
		/// so streaming state can be controlled by other systems (ex: in blueprints)
		/// </summary>
		public bool bDisableDistanceStreaming;
		
		/// <summary>If true, will be drawn on the 'level streaming status' map (STAT LEVELMAP console command)</summary>
		public bool bDrawOnLevelStatusMap;
		
		/// <summary>Deprecated level color used for visualization.</summary>
		public FColor DrawColor;
		
		/// <summary>The level color used for visualization. (Show -> Advanced -> Level Coloration)</summary>
		public FLinearColor LevelColor;
		
		/// <summary>Cooldown time in seconds between volume-based unload requests.  Used in preventing spurious unload requests.</summary>
		public float MinTimeBetweenVolumeUnloadRequests;
		
		/// <summary>Pointer to Level object if currently loaded/ streamed in.</summary>
		public ULevel LoadedLevel;
		
		/// <summary>Pointer to a Level object that was previously active and was replaced with a new LoadedLevel (for LOD switching)</summary>
		public ULevel PendingUnloadLevel;
		
		
	}
	
}
