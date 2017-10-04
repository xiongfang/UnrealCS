using System;
namespace UnrealEngine
{
	public partial class AWorldSettings:AInfo
	{
		public extern virtual void OnRep_WorldGravityZ();
		/// <summary>If true, enables CheckStillInWorld checks</summary>
		public bool bEnableWorldBoundsChecks;
		
		/// <summary>if set to false navigation system will not get created (and all navigation functionality won't be accessible)</summary>
		public bool bEnableNavigationSystem;
		
		/// <summary>if set to false AI system will not get created. Use it to disable all AI-related activity on a map</summary>
		public bool bEnableAISystem;
		
		/// <summary>
		/// Enables tools for composing a tiled world.
		/// Level has to be saved and all sub-levels removed before enabling this option.
		/// </summary>
		public bool bEnableWorldComposition;
		
		/// <summary>
		/// Enables client-side streaming volumes instead of server-side.
		/// Expected usage scenario: server has all streaming levels always loaded, clients independently stream levels in/out based on streaming volumes.
		/// </summary>
		public bool bUseClientSideLevelStreamingVolumes;
		
		/// <summary>World origin will shift to a camera position when camera goes far away from current origin</summary>
		public bool bEnableWorldOriginRebasing;
		
		/// <summary>if set to true, when we call GetGravityZ we assume WorldGravityZ has already been initialized and skip the lookup of DefaultGravityZ and GlobalGravityZ</summary>
		public bool bWorldGravitySet;
		
		/// <summary>If set to true we will use GlobalGravityZ instead of project setting DefaultGravityZ</summary>
		public bool bGlobalGravitySet;
		
		/// <summary>any actor falling below this level gets destroyed</summary>
		public float KillZ;
		
		/// <summary>The type of damage inflicted when a actor falls below KillZ</summary>
		public TSubclassOf<UDamageType>  KillZDamageType;
		
		/// <summary>current gravity actually being used</summary>
		public float WorldGravityZ;
		
		/// <summary>optional level specific gravity override set by level designer</summary>
		public float GlobalGravityZ;
		
		/// <summary>level specific default physics volume</summary>
		public TSubclassOf<ADefaultPhysicsVolume>  DefaultPhysicsVolumeClass;
		
		/// <summary>optional level specific collision handler</summary>
		public TSubclassOf<UPhysicsCollisionHandler>  PhysicsCollisionHandlerClass;
		
		/// <summary>The default GameMode to use when starting this map in the game. If this value is NULL, the INI setting for default game type is used.</summary>
		public TSubclassOf<AGameModeBase>  DefaultGameMode;
		
		/// <summary>Class of GameNetworkManager to spawn for network games</summary>
		public TSubclassOf<AGameNetworkManager>  GameNetworkManagerClass;
		
		/// <summary>Maximum size of textures for packed light and shadow maps</summary>
		public int PackedLightAndShadowMapTextureSize;
		
		/// <summary>
		/// Causes the BSP build to generate as few sections as possible.
		/// This is useful when you need to reduce draw calls but can reduce texture streaming efficiency and effective lightmap resolution.
		/// Note - changes require a rebuild to propagate.  Also, be sure to select all surfaces and make sure they all have the same flags to minimize section count.
		/// </summary>
		public bool bMinimizeBSPSections;
		
		/// <summary>Default color scale for the level</summary>
		public FVector DefaultColorScale;
		
		/// <summary>Max occlusion distance used by mesh distance fields, overridden if there is a movable skylight.</summary>
		public float DefaultMaxDistanceFieldOcclusionDistance;
		
		/// <summary>Distance from the camera that the global distance field should cover.</summary>
		public float GlobalDistanceFieldViewDistance;
		
		/// <summary>
		/// Controls the intensity of self-shadowing from capsule indirect shadows.
		/// These types of shadows use approximate occluder representations, so reducing self-shadowing intensity can hide those artifacts.
		/// </summary>
		public float DynamicIndirectShadowsSelfShadowingIntensity;
		
		/// <summary>
		/// Whether to place visibility cells inside Precomputed Visibility Volumes and along camera tracks in this level.
		/// Precomputing visibility reduces rendering thread time at the cost of some runtime memory and somewhat increased lighting build times.
		/// </summary>
		public bool bPrecomputeVisibility;
		
		/// <summary>Whether to place visibility cells only along camera tracks or only above shadow casting surfaces.</summary>
		public bool bPlaceCellsOnlyAlongCameraTracks;
		
		/// <summary>
		/// World space size of precomputed visibility cells in x and y.
		/// Smaller sizes produce more effective occlusion culling at the cost of increased runtime memory usage and lighting build times.
		/// </summary>
		public int VisibilityCellSize;
		
		/// <summary>
		/// Determines how aggressive precomputed visibility should be.
		/// More aggressive settings cull more objects but also cause more visibility errors like popping.
		/// </summary>
		public EVisibilityAggressiveness VisibilityAggressiveness;
		
		/// <summary>
		/// Whether to force lightmaps and other precomputed lighting to not be created even when the engine thinks they are needed.
		/// This is useful for improving iteration in levels with fully dynamic lighting and shadowing.
		/// Note that any lighting and shadowing interactions that are usually precomputed will be lost if this is enabled.
		/// </summary>
		public bool bForceNoPrecomputedLighting;
		
		public FLightmassWorldInfoSettings LightmassSettings;
		
		/// <summary>Default reverb settings used by audio volumes.</summary>
		public FReverbSettings DefaultReverbSettings;
		
		/// <summary>Default interior settings used by audio volumes.</summary>
		public FInteriorSettings DefaultAmbientZoneSettings;
		
		/// <summary>Default Base SoundMix.</summary>
		public USoundMix DefaultBaseSoundMix;
		
		/// <summary>if set to true, hierarchical LODs will be built, which will create hierarchical LODActors</summary>
		public bool bEnableHierarchicalLODSystem;
		
		public int NumHLODLevels;
		
		/// <summary>scale of 1uu to 1m in real world measurements, for HMD and other physically tracked devices (e.g. 1uu = 1cm would be 100.0)</summary>
		public float WorldToMeters;
		
		/// <summary>Distance from the player after which content will be rendered in mono if monoscopic far field rendering is activated</summary>
		public float MonoCullingDistance;
		
		/// <summary>Level Bookmarks: 10 should be MAX_BOOKMARK_NUMBER @fixmeconst</summary>
		public UBookMark BookMarks;
		
		/// <summary>
		/// Normally 1 - scales real time passage.
		/// Warning - most use cases should use GetEffectiveTimeDilation() instead of reading from this directly
		/// </summary>
		public float TimeDilation;
		
		/// <summary>
		/// Additional time dilation used by Matinee (or Sequencer) slomo track.  Transient because this is often
		/// temporarily modified by the editor when previewing slow motion effects, yet we don't want it saved or loaded from level packages.
		/// </summary>
		public float MatineeTimeDilation;
		
		/// <summary>Additional TimeDilation used to control demo playback speed</summary>
		public float DemoPlayTimeDilation;
		
		/// <summary>Lowest acceptable global time dilation.</summary>
		public float MinGlobalTimeDilation;
		
		/// <summary>Highest acceptable global time dilation.</summary>
		public float MaxGlobalTimeDilation;
		
		/// <summary>Smallest possible frametime, not considering dilation. Equiv to 1/FastestFPS.</summary>
		public float MinUndilatedFrameTime;
		
		/// <summary>Largest possible frametime, not considering dilation. Equiv to 1/SlowestFPS.</summary>
		public float MaxUndilatedFrameTime;
		
		/// <summary>If paused, FName of person pausing the game.</summary>
		public APlayerState Pauser;
		
		/// <summary>when this flag is set, more time is allocated to background loading (replicated)</summary>
		public bool bHighPriorityLoading;
		
		/// <summary>copy of bHighPriorityLoading that is not replicated, for clientside-only loading operations</summary>
		public bool bHighPriorityLoadingLocal;
		
		
	}
	
}
