using System;
namespace UnrealEngine
{
	public partial class ULevel:UObject
	{
		/// <summary>
		/// The World that has this level in its Levels array.
		/// This is not the same as GetOuter(), because GetOuter() for a streaming level is a vestigial world that is not used.
		/// It should not be accessed during BeginDestroy(), just like any other UObject references, since GC may occur in any order.
		/// </summary>
		public UWorld OwningWorld;
		
		/// <summary>BSP UModel.</summary>
		public UModel Model;
		
		/// <summary>Reference to the blueprint for level scripting</summary>
		public ULevelScriptBlueprint LevelScriptBlueprint;
		
		/// <summary>Num of components missing valid texture streaming data. Updated in map check.</summary>
		public int NumTextureStreamingUnbuiltComponents;
		
		/// <summary>Num of resources that have changed since the last texture streaming build. Updated in map check.</summary>
		public int NumTextureStreamingDirtyResources;
		
		/// <summary>The level scripting actor, created by instantiating the class from LevelScriptBlueprint.  This handles all level scripting</summary>
		public ALevelScriptActor LevelScriptActor;
		
		/// <summary>
		/// Start and end of the navigation list for this level, used for quickly fixing up
		/// when streaming this level in/out. @TODO DEPRECATED - DELETE
		/// </summary>
		public ANavigationObjectBase NavListStart;
		
		public ANavigationObjectBase NavListEnd;
		
		/// <summary>Total number of KB used for lightmap textures in the level.</summary>
		public float LightmapTotalSize;
		
		/// <summary>Total number of KB used for shadowmap textures in the level.</summary>
		public float ShadowmapTotalSize;
		
		/// <summary>
		/// Whether the level is a lighting scenario.  Lighting is built separately for each lighting scenario level with all other scenario levels hidden.
		/// Only one lighting scenario level should be visible at a time for correct rendering, and lightmaps from that level will be used on the rest of the world.
		/// Note: When a lighting scenario level is present, lightmaps for all streaming levels are placed in the scenario's _BuildData package.
		///              This means that lightmaps for those streaming levels will not be streamed with them.
		/// </summary>
		public bool bIsLightingScenario;
		
		/// <summary>Identifies map build data specific to this level, eg lighting volume samples.</summary>
		public FGuid LevelBuildDataId;
		
		/// <summary>Registry for data from the map build.  This is stored in a separate package from the level to speed up saving / autosaving.</summary>
		public UMapBuildDataRegistry MapBuildData;
		
		/// <summary>Level offset at time when lighting was built</summary>
		public FIntVector LightBuildLevelOffset;
		
		/// <summary>Whether a level transform rotation was applied since the texture streaming builds. Invalidates the precomputed streaming bounds.</summary>
		public bool bTextureStreamingRotationChanged;
		
		/// <summary>Whether the level is currently visible/ associated with the world</summary>
		public bool bIsVisible;
		
		/// <summary>
		/// Whether this level is locked; that is, its actors are read-only
		///     Used by WorldBrowser to lock a level when corresponding ULevelStreaming does not exist
		/// </summary>
		public bool bLocked;
		
		/// <summary>Level simplification settings for each LOD</summary>
		public FLevelSimplificationDetails LevelSimplification;
		
		/// <summary>
		/// The level color used for visualization. (Show -> Advanced -> Level Coloration)
		/// Used only in world composition mode
		/// </summary>
		public FLinearColor LevelColor;
		
		public AWorldSettings WorldSettings;
		
		
	}
	
}
