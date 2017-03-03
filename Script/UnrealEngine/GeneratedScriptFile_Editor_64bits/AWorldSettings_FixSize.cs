#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Actor containing all script accessible world properties.</summary>
	public partial class AWorldSettings
	{
		static readonly int bEnableWorldBoundsChecks__Offset;
		/// <summary>If true, enables CheckStillInWorld checks</summary>
		public bool bEnableWorldBoundsChecks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableWorldBoundsChecks__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableWorldBoundsChecks__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableNavigationSystem__Offset;
		/// <summary>if set to false navigation system will not get created (and all navigation functionality won't be accessible)</summary>
		public bool bEnableNavigationSystem
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableNavigationSystem__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableNavigationSystem__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableAISystem__Offset;
		/// <summary>if set to false AI system will not get created. Use it to disable all AI-related activity on a map</summary>
		public bool bEnableAISystem
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAISystem__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAISystem__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableWorldComposition__Offset;
		/// <summary>
		/// Enables tools for composing a tiled world.
		/// Level has to be saved and all sub-levels removed before enabling this option.
		/// </summary>
		public bool bEnableWorldComposition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableWorldComposition__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableWorldComposition__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseClientSideLevelStreamingVolumes__Offset;
		/// <summary>
		/// Enables client-side streaming volumes instead of server-side.
		/// Expected usage scenario: server has all streaming levels always loaded, clients independently stream levels in/out based on streaming volumes.
		/// </summary>
		public bool bUseClientSideLevelStreamingVolumes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseClientSideLevelStreamingVolumes__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseClientSideLevelStreamingVolumes__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bEnableWorldOriginRebasing__Offset;
		/// <summary>World origin will shift to a camera position when camera goes far away from current origin</summary>
		public bool bEnableWorldOriginRebasing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableWorldOriginRebasing__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableWorldOriginRebasing__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bWorldGravitySet__Offset;
		/// <summary>if set to true, when we call GetGravityZ we assume WorldGravityZ has already been initialized and skip the lookup of DefaultGravityZ and GlobalGravityZ</summary>
		public bool bWorldGravitySet
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWorldGravitySet__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bGlobalGravitySet__Offset;
		/// <summary>If set to true we will use GlobalGravityZ instead of project setting DefaultGravityZ</summary>
		public bool bGlobalGravitySet
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGlobalGravitySet__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGlobalGravitySet__Offset, 1,0,128,128);}
			
		}
		
		static readonly int KillZ__Offset;
		/// <summary>any actor falling below this level gets destroyed</summary>
		public float KillZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+KillZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+KillZ__Offset, false);}
			
		}
		
		static readonly int KillZDamageType__Offset;
		/// <summary>The type of damage inflicted when a actor falls below KillZ</summary>
		public TSubclassOf<UDamageType>  KillZDamageType
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + KillZDamageType__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + KillZDamageType__Offset, value); }
			
		}
		
		static readonly int WorldGravityZ__Offset;
		/// <summary>current gravity actually being used</summary>
		public float WorldGravityZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WorldGravityZ__Offset, typeof(float));}
			
		}
		
		static readonly int GlobalGravityZ__Offset;
		/// <summary>optional level specific gravity override set by level designer</summary>
		public float GlobalGravityZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GlobalGravityZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GlobalGravityZ__Offset, false);}
			
		}
		
		static readonly int DefaultPhysicsVolumeClass__Offset;
		/// <summary>level specific default physics volume</summary>
		public TSubclassOf<ADefaultPhysicsVolume>  DefaultPhysicsVolumeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPhysicsVolumeClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultPhysicsVolumeClass__Offset, value); }
			
		}
		
		static readonly int PhysicsCollisionHandlerClass__Offset;
		/// <summary>optional level specific collision handler</summary>
		public TSubclassOf<UPhysicsCollisionHandler>  PhysicsCollisionHandlerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsCollisionHandlerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PhysicsCollisionHandlerClass__Offset, value); }
			
		}
		
		static readonly int DefaultGameMode__Offset;
		/// <summary>The default GameMode to use when starting this map in the game. If this value is NULL, the INI setting for default game type is used.</summary>
		public TSubclassOf<AGameModeBase>  DefaultGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultGameMode__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultGameMode__Offset, value); }
			
		}
		
		static readonly int GameNetworkManagerClass__Offset;
		/// <summary>Class of GameNetworkManager to spawn for network games</summary>
		public TSubclassOf<AGameNetworkManager>  GameNetworkManagerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameNetworkManagerClass__Offset); return v; }
			
		}
		
		static readonly int PackedLightAndShadowMapTextureSize__Offset;
		/// <summary>Maximum size of textures for packed light and shadow maps</summary>
		public int PackedLightAndShadowMapTextureSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PackedLightAndShadowMapTextureSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PackedLightAndShadowMapTextureSize__Offset, false);}
			
		}
		
		static readonly int bMinimizeBSPSections__Offset;
		/// <summary>
		/// Causes the BSP build to generate as few sections as possible.
		/// This is useful when you need to reduce draw calls but can reduce texture streaming efficiency and effective lightmap resolution.
		/// Note - changes require a rebuild to propagate.  Also, be sure to select all surfaces and make sure they all have the same flags to minimize section count.
		/// </summary>
		public bool bMinimizeBSPSections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMinimizeBSPSections__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMinimizeBSPSections__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DefaultColorScale__Offset;
		/// <summary>Default color scale for the level</summary>
		public FVector DefaultColorScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+DefaultColorScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultColorScale__Offset, false);}
			
		}
		
		static readonly int DefaultMaxDistanceFieldOcclusionDistance__Offset;
		/// <summary>Max occlusion distance used by mesh distance fields, overridden if there is a movable skylight.</summary>
		public float DefaultMaxDistanceFieldOcclusionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultMaxDistanceFieldOcclusionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultMaxDistanceFieldOcclusionDistance__Offset, false);}
			
		}
		
		static readonly int GlobalDistanceFieldViewDistance__Offset;
		/// <summary>Distance from the camera that the global distance field should cover.</summary>
		public float GlobalDistanceFieldViewDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GlobalDistanceFieldViewDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GlobalDistanceFieldViewDistance__Offset, false);}
			
		}
		
		static readonly int DynamicIndirectShadowsSelfShadowingIntensity__Offset;
		/// <summary>
		/// Controls the intensity of self-shadowing from capsule indirect shadows.
		/// These types of shadows use approximate occluder representations, so reducing self-shadowing intensity can hide those artifacts.
		/// </summary>
		public float DynamicIndirectShadowsSelfShadowingIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicIndirectShadowsSelfShadowingIntensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicIndirectShadowsSelfShadowingIntensity__Offset, false);}
			
		}
		
		static readonly int bPrecomputeVisibility__Offset;
		/// <summary>
		/// Whether to place visibility cells inside Precomputed Visibility Volumes and along camera tracks in this level.
		/// Precomputing visibility reduces rendering thread time at the cost of some runtime memory and somewhat increased lighting build times.
		/// </summary>
		public bool bPrecomputeVisibility
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPrecomputeVisibility__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPrecomputeVisibility__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPlaceCellsOnlyAlongCameraTracks__Offset;
		/// <summary>Whether to place visibility cells only along camera tracks or only above shadow casting surfaces.</summary>
		public bool bPlaceCellsOnlyAlongCameraTracks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlaceCellsOnlyAlongCameraTracks__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlaceCellsOnlyAlongCameraTracks__Offset, 1,0,2,2);}
			
		}
		
		static readonly int VisibilityCellSize__Offset;
		/// <summary>
		/// World space size of precomputed visibility cells in x and y.
		/// Smaller sizes produce more effective occlusion culling at the cost of increased runtime memory usage and lighting build times.
		/// </summary>
		public int VisibilityCellSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VisibilityCellSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VisibilityCellSize__Offset, false);}
			
		}
		
		static readonly int VisibilityAggressiveness__Offset;
		/// <summary>
		/// Determines how aggressive precomputed visibility should be.
		/// More aggressive settings cull more objects but also cause more visibility errors like popping.
		/// </summary>
		public EVisibilityAggressiveness VisibilityAggressiveness
		{
			get{ CheckIsValid();return (EVisibilityAggressiveness)Marshal.PtrToStructure(_this.Get()+VisibilityAggressiveness__Offset, typeof(EVisibilityAggressiveness));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VisibilityAggressiveness__Offset, false);}
			
		}
		
		static readonly int bForceNoPrecomputedLighting__Offset;
		/// <summary>
		/// Whether to force lightmaps and other precomputed lighting to not be created even when the engine thinks they are needed.
		/// This is useful for improving iteration in levels with fully dynamic lighting and shadowing.
		/// Note that any lighting and shadowing interactions that are usually precomputed will be lost if this is enabled.
		/// </summary>
		public bool bForceNoPrecomputedLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceNoPrecomputedLighting__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceNoPrecomputedLighting__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LightmassSettings__Offset;
		public FLightmassWorldInfoSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassWorldInfoSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassWorldInfoSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static readonly int DefaultReverbSettings__Offset;
		/// <summary>Default reverb settings used by audio volumes.</summary>
		public FReverbSettings DefaultReverbSettings
		{
			get{ CheckIsValid();return (FReverbSettings)Marshal.PtrToStructure(_this.Get()+DefaultReverbSettings__Offset, typeof(FReverbSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultReverbSettings__Offset, false);}
			
		}
		
		static readonly int DefaultAmbientZoneSettings__Offset;
		/// <summary>Default interior settings used by audio volumes.</summary>
		public FInteriorSettings DefaultAmbientZoneSettings
		{
			get{ CheckIsValid();return (FInteriorSettings)Marshal.PtrToStructure(_this.Get()+DefaultAmbientZoneSettings__Offset, typeof(FInteriorSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultAmbientZoneSettings__Offset, false);}
			
		}
		
		static readonly int DefaultBaseSoundMix__Offset;
		/// <summary>Default Base SoundMix.</summary>
		public USoundMix DefaultBaseSoundMix
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultBaseSoundMix__Offset); if (v == IntPtr.Zero)return null; USoundMix retValue = new USoundMix(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DefaultBaseSoundMix__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DefaultBaseSoundMix__Offset, value._this.Get()); }
			
		}
		
		static readonly int bEnableHierarchicalLODSystem__Offset;
		/// <summary>if set to true, hierarchical LODs will be built, which will create hierarchical LODActors</summary>
		public bool bEnableHierarchicalLODSystem
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableHierarchicalLODSystem__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableHierarchicalLODSystem__Offset, 1,0,1,1);}
			
		}
		
		static readonly int HierarchicalLODSetup__Offset;
		/// <summary>Hierarchical LOD Setup</summary>
		public TStructArray<FHierarchicalSimplification> HierarchicalLODSetup
		{
			get{ CheckIsValid();return new TStructArray<FHierarchicalSimplification>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HierarchicalLODSetup__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HierarchicalLODSetup__Offset, false);}
			
		}
		
		static readonly int NumHLODLevels__Offset;
		public int NumHLODLevels
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumHLODLevels__Offset, typeof(int));}
			
		}
		
		static readonly int WorldToMeters__Offset;
		/// <summary>scale of 1uu to 1m in real world measurements, for HMD and other physically tracked devices (e.g. 1uu = 1cm would be 100.0)</summary>
		public float WorldToMeters
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WorldToMeters__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WorldToMeters__Offset, false);}
			
		}
		
		static readonly int MonoCullingDistance__Offset;
		/// <summary>Distance from the player after which content will be rendered in mono if monoscopic far field rendering is activated</summary>
		public float MonoCullingDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MonoCullingDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MonoCullingDistance__Offset, false);}
			
		}
		
		static readonly int BookMarks__Offset;
		/// <summary>Level Bookmarks: 10 should be MAX_BOOKMARK_NUMBER @fixmeconst</summary>
		public UBookMark BookMarks
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BookMarks__Offset); if (v == IntPtr.Zero)return null; UBookMark retValue = new UBookMark(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TimeDilation__Offset;
		/// <summary>
		/// Normally 1 - scales real time passage.
		/// Warning - most use cases should use GetEffectiveTimeDilation() instead of reading from this directly
		/// </summary>
		public float TimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int MatineeTimeDilation__Offset;
		/// <summary>
		/// Additional time dilation used by Matinee (or Sequencer) slomo track.  Transient because this is often
		/// temporarily modified by the editor when previewing slow motion effects, yet we don't want it saved or loaded from level packages.
		/// </summary>
		public float MatineeTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MatineeTimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int DemoPlayTimeDilation__Offset;
		/// <summary>Additional TimeDilation used to control demo playback speed</summary>
		public float DemoPlayTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DemoPlayTimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int MinGlobalTimeDilation__Offset;
		/// <summary>Lowest acceptable global time dilation.</summary>
		public float MinGlobalTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinGlobalTimeDilation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinGlobalTimeDilation__Offset, false);}
			
		}
		
		static readonly int MaxGlobalTimeDilation__Offset;
		/// <summary>Highest acceptable global time dilation.</summary>
		public float MaxGlobalTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxGlobalTimeDilation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxGlobalTimeDilation__Offset, false);}
			
		}
		
		static readonly int MinUndilatedFrameTime__Offset;
		/// <summary>Smallest possible frametime, not considering dilation. Equiv to 1/FastestFPS.</summary>
		public float MinUndilatedFrameTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinUndilatedFrameTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinUndilatedFrameTime__Offset, false);}
			
		}
		
		static readonly int MaxUndilatedFrameTime__Offset;
		/// <summary>Largest possible frametime, not considering dilation. Equiv to 1/SlowestFPS.</summary>
		public float MaxUndilatedFrameTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxUndilatedFrameTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxUndilatedFrameTime__Offset, false);}
			
		}
		
		static readonly int Pauser__Offset;
		/// <summary>If paused, FName of person pausing the game.</summary>
		public APlayerState Pauser
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Pauser__Offset); if (v == IntPtr.Zero)return null; APlayerState retValue = new APlayerState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bHighPriorityLoading__Offset;
		/// <summary>when this flag is set, more time is allocated to background loading (replicated)</summary>
		public bool bHighPriorityLoading
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHighPriorityLoading__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHighPriorityLoadingLocal__Offset;
		/// <summary>copy of bHighPriorityLoading that is not replicated, for clientside-only loading operations</summary>
		public bool bHighPriorityLoadingLocal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHighPriorityLoadingLocal__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int ReplicationViewers__Offset;
		/// <summary>
		/// valid only during replication - information about the player(s) being replicated to
		/// (there could be more than one in the case of a splitscreen client)
		/// </summary>
		public TStructArray<FNetViewer> ReplicationViewers
		{
			get{ CheckIsValid();return new TStructArray<FNetViewer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ReplicationViewers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ReplicationViewers__Offset, false);}
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the asset</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static AWorldSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WorldSettings");
			bEnableWorldBoundsChecks__Offset=GetPropertyOffset(NativeClassPtr,"bEnableWorldBoundsChecks");
			bEnableNavigationSystem__Offset=GetPropertyOffset(NativeClassPtr,"bEnableNavigationSystem");
			bEnableAISystem__Offset=GetPropertyOffset(NativeClassPtr,"bEnableAISystem");
			bEnableWorldComposition__Offset=GetPropertyOffset(NativeClassPtr,"bEnableWorldComposition");
			bUseClientSideLevelStreamingVolumes__Offset=GetPropertyOffset(NativeClassPtr,"bUseClientSideLevelStreamingVolumes");
			bEnableWorldOriginRebasing__Offset=GetPropertyOffset(NativeClassPtr,"bEnableWorldOriginRebasing");
			bWorldGravitySet__Offset=GetPropertyOffset(NativeClassPtr,"bWorldGravitySet");
			bGlobalGravitySet__Offset=GetPropertyOffset(NativeClassPtr,"bGlobalGravitySet");
			KillZ__Offset=GetPropertyOffset(NativeClassPtr,"KillZ");
			KillZDamageType__Offset=GetPropertyOffset(NativeClassPtr,"KillZDamageType");
			WorldGravityZ__Offset=GetPropertyOffset(NativeClassPtr,"WorldGravityZ");
			GlobalGravityZ__Offset=GetPropertyOffset(NativeClassPtr,"GlobalGravityZ");
			DefaultPhysicsVolumeClass__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPhysicsVolumeClass");
			PhysicsCollisionHandlerClass__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsCollisionHandlerClass");
			DefaultGameMode__Offset=GetPropertyOffset(NativeClassPtr,"DefaultGameMode");
			GameNetworkManagerClass__Offset=GetPropertyOffset(NativeClassPtr,"GameNetworkManagerClass");
			PackedLightAndShadowMapTextureSize__Offset=GetPropertyOffset(NativeClassPtr,"PackedLightAndShadowMapTextureSize");
			bMinimizeBSPSections__Offset=GetPropertyOffset(NativeClassPtr,"bMinimizeBSPSections");
			DefaultColorScale__Offset=GetPropertyOffset(NativeClassPtr,"DefaultColorScale");
			DefaultMaxDistanceFieldOcclusionDistance__Offset=GetPropertyOffset(NativeClassPtr,"DefaultMaxDistanceFieldOcclusionDistance");
			GlobalDistanceFieldViewDistance__Offset=GetPropertyOffset(NativeClassPtr,"GlobalDistanceFieldViewDistance");
			DynamicIndirectShadowsSelfShadowingIntensity__Offset=GetPropertyOffset(NativeClassPtr,"DynamicIndirectShadowsSelfShadowingIntensity");
			bPrecomputeVisibility__Offset=GetPropertyOffset(NativeClassPtr,"bPrecomputeVisibility");
			bPlaceCellsOnlyAlongCameraTracks__Offset=GetPropertyOffset(NativeClassPtr,"bPlaceCellsOnlyAlongCameraTracks");
			VisibilityCellSize__Offset=GetPropertyOffset(NativeClassPtr,"VisibilityCellSize");
			VisibilityAggressiveness__Offset=GetPropertyOffset(NativeClassPtr,"VisibilityAggressiveness");
			bForceNoPrecomputedLighting__Offset=GetPropertyOffset(NativeClassPtr,"bForceNoPrecomputedLighting");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			DefaultReverbSettings__Offset=GetPropertyOffset(NativeClassPtr,"DefaultReverbSettings");
			DefaultAmbientZoneSettings__Offset=GetPropertyOffset(NativeClassPtr,"DefaultAmbientZoneSettings");
			DefaultBaseSoundMix__Offset=GetPropertyOffset(NativeClassPtr,"DefaultBaseSoundMix");
			bEnableHierarchicalLODSystem__Offset=GetPropertyOffset(NativeClassPtr,"bEnableHierarchicalLODSystem");
			HierarchicalLODSetup__Offset=GetPropertyOffset(NativeClassPtr,"HierarchicalLODSetup");
			NumHLODLevels__Offset=GetPropertyOffset(NativeClassPtr,"NumHLODLevels");
			WorldToMeters__Offset=GetPropertyOffset(NativeClassPtr,"WorldToMeters");
			MonoCullingDistance__Offset=GetPropertyOffset(NativeClassPtr,"MonoCullingDistance");
			BookMarks__Offset=GetPropertyOffset(NativeClassPtr,"BookMarks");
			TimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"TimeDilation");
			MatineeTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"MatineeTimeDilation");
			DemoPlayTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"DemoPlayTimeDilation");
			MinGlobalTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"MinGlobalTimeDilation");
			MaxGlobalTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"MaxGlobalTimeDilation");
			MinUndilatedFrameTime__Offset=GetPropertyOffset(NativeClassPtr,"MinUndilatedFrameTime");
			MaxUndilatedFrameTime__Offset=GetPropertyOffset(NativeClassPtr,"MaxUndilatedFrameTime");
			Pauser__Offset=GetPropertyOffset(NativeClassPtr,"Pauser");
			bHighPriorityLoading__Offset=GetPropertyOffset(NativeClassPtr,"bHighPriorityLoading");
			bHighPriorityLoadingLocal__Offset=GetPropertyOffset(NativeClassPtr,"bHighPriorityLoadingLocal");
			ReplicationViewers__Offset=GetPropertyOffset(NativeClassPtr,"ReplicationViewers");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			
		}
		
	}
	
}
#endif
#endif
