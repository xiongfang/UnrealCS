#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AWorldSettings
	{
		static readonly int bEnableWorldBoundsChecks__Offset;
		public bool bEnableWorldBoundsChecks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableWorldBoundsChecks__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableWorldBoundsChecks__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableNavigationSystem__Offset;
		public bool bEnableNavigationSystem
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableNavigationSystem__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableNavigationSystem__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableAISystem__Offset;
		public bool bEnableAISystem
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAISystem__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAISystem__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableWorldComposition__Offset;
		public bool bEnableWorldComposition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableWorldComposition__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableWorldComposition__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bUseClientSideLevelStreamingVolumes__Offset;
		public bool bUseClientSideLevelStreamingVolumes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseClientSideLevelStreamingVolumes__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseClientSideLevelStreamingVolumes__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bEnableWorldOriginRebasing__Offset;
		public bool bEnableWorldOriginRebasing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableWorldOriginRebasing__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableWorldOriginRebasing__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bWorldGravitySet__Offset;
		public bool bWorldGravitySet
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWorldGravitySet__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bGlobalGravitySet__Offset;
		public bool bGlobalGravitySet
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGlobalGravitySet__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGlobalGravitySet__Offset, 1,0,128,128);}
			
		}
		
		static readonly int KillZ__Offset;
		public float KillZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+KillZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+KillZ__Offset, false);}
			
		}
		
		static readonly int KillZDamageType__Offset;
		public TSubclassOf<UDamageType>  KillZDamageType
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + KillZDamageType__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + KillZDamageType__Offset, value); }
			
		}
		
		static readonly int WorldGravityZ__Offset;
		public float WorldGravityZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WorldGravityZ__Offset, typeof(float));}
			
		}
		
		static readonly int GlobalGravityZ__Offset;
		public float GlobalGravityZ
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GlobalGravityZ__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GlobalGravityZ__Offset, false);}
			
		}
		
		static readonly int DefaultPhysicsVolumeClass__Offset;
		public TSubclassOf<ADefaultPhysicsVolume>  DefaultPhysicsVolumeClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultPhysicsVolumeClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultPhysicsVolumeClass__Offset, value); }
			
		}
		
		static readonly int PhysicsCollisionHandlerClass__Offset;
		public TSubclassOf<UPhysicsCollisionHandler>  PhysicsCollisionHandlerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsCollisionHandlerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PhysicsCollisionHandlerClass__Offset, value); }
			
		}
		
		static readonly int DefaultGameMode__Offset;
		public TSubclassOf<AGameModeBase>  DefaultGameMode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultGameMode__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DefaultGameMode__Offset, value); }
			
		}
		
		static readonly int GameNetworkManagerClass__Offset;
		public TSubclassOf<AGameNetworkManager>  GameNetworkManagerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameNetworkManagerClass__Offset); return v; }
			
		}
		
		static readonly int PackedLightAndShadowMapTextureSize__Offset;
		public int PackedLightAndShadowMapTextureSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PackedLightAndShadowMapTextureSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PackedLightAndShadowMapTextureSize__Offset, false);}
			
		}
		
		static readonly int bMinimizeBSPSections__Offset;
		public bool bMinimizeBSPSections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMinimizeBSPSections__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMinimizeBSPSections__Offset, 1,0,1,1);}
			
		}
		
		static readonly int DefaultColorScale__Offset;
		public FVector DefaultColorScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+DefaultColorScale__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultColorScale__Offset, false);}
			
		}
		
		static readonly int DefaultMaxDistanceFieldOcclusionDistance__Offset;
		public float DefaultMaxDistanceFieldOcclusionDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultMaxDistanceFieldOcclusionDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultMaxDistanceFieldOcclusionDistance__Offset, false);}
			
		}
		
		static readonly int GlobalDistanceFieldViewDistance__Offset;
		public float GlobalDistanceFieldViewDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GlobalDistanceFieldViewDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GlobalDistanceFieldViewDistance__Offset, false);}
			
		}
		
		static readonly int DynamicIndirectShadowsSelfShadowingIntensity__Offset;
		public float DynamicIndirectShadowsSelfShadowingIntensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DynamicIndirectShadowsSelfShadowingIntensity__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DynamicIndirectShadowsSelfShadowingIntensity__Offset, false);}
			
		}
		
		static readonly int bPrecomputeVisibility__Offset;
		public bool bPrecomputeVisibility
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPrecomputeVisibility__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPrecomputeVisibility__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPlaceCellsOnlyAlongCameraTracks__Offset;
		public bool bPlaceCellsOnlyAlongCameraTracks
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlaceCellsOnlyAlongCameraTracks__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlaceCellsOnlyAlongCameraTracks__Offset, 1,0,2,2);}
			
		}
		
		static readonly int VisibilityCellSize__Offset;
		public int VisibilityCellSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VisibilityCellSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VisibilityCellSize__Offset, false);}
			
		}
		
		static readonly int VisibilityAggressiveness__Offset;
		public EVisibilityAggressiveness VisibilityAggressiveness
		{
			get{ CheckIsValid();return (EVisibilityAggressiveness)Marshal.PtrToStructure(_this.Get()+VisibilityAggressiveness__Offset, typeof(EVisibilityAggressiveness));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VisibilityAggressiveness__Offset, false);}
			
		}
		
		static readonly int bForceNoPrecomputedLighting__Offset;
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
		public FReverbSettings DefaultReverbSettings
		{
			get{ CheckIsValid();return (FReverbSettings)Marshal.PtrToStructure(_this.Get()+DefaultReverbSettings__Offset, typeof(FReverbSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultReverbSettings__Offset, false);}
			
		}
		
		static readonly int DefaultAmbientZoneSettings__Offset;
		public FInteriorSettings DefaultAmbientZoneSettings
		{
			get{ CheckIsValid();return (FInteriorSettings)Marshal.PtrToStructure(_this.Get()+DefaultAmbientZoneSettings__Offset, typeof(FInteriorSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultAmbientZoneSettings__Offset, false);}
			
		}
		
		static readonly int DefaultBaseSoundMix__Offset;
		public USoundMix DefaultBaseSoundMix
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultBaseSoundMix__Offset); if (v == IntPtr.Zero)return null; USoundMix retValue = new USoundMix(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + DefaultBaseSoundMix__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + DefaultBaseSoundMix__Offset, value._this.Get()); }
			
		}
		
		static readonly int WorldToMeters__Offset;
		public float WorldToMeters
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WorldToMeters__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WorldToMeters__Offset, false);}
			
		}
		
		static readonly int MonoCullingDistance__Offset;
		public float MonoCullingDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MonoCullingDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MonoCullingDistance__Offset, false);}
			
		}
		
		static readonly int BookMarks__Offset;
		public UBookMark BookMarks
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BookMarks__Offset); if (v == IntPtr.Zero)return null; UBookMark retValue = new UBookMark(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TimeDilation__Offset;
		public float TimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int MatineeTimeDilation__Offset;
		public float MatineeTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MatineeTimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int DemoPlayTimeDilation__Offset;
		public float DemoPlayTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DemoPlayTimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int MinGlobalTimeDilation__Offset;
		public float MinGlobalTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinGlobalTimeDilation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinGlobalTimeDilation__Offset, false);}
			
		}
		
		static readonly int MaxGlobalTimeDilation__Offset;
		public float MaxGlobalTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxGlobalTimeDilation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxGlobalTimeDilation__Offset, false);}
			
		}
		
		static readonly int MinUndilatedFrameTime__Offset;
		public float MinUndilatedFrameTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinUndilatedFrameTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinUndilatedFrameTime__Offset, false);}
			
		}
		
		static readonly int MaxUndilatedFrameTime__Offset;
		public float MaxUndilatedFrameTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxUndilatedFrameTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxUndilatedFrameTime__Offset, false);}
			
		}
		
		static readonly int Pauser__Offset;
		public APlayerState Pauser
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Pauser__Offset); if (v == IntPtr.Zero)return null; APlayerState retValue = new APlayerState(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bHighPriorityLoading__Offset;
		public bool bHighPriorityLoading
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHighPriorityLoading__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHighPriorityLoadingLocal__Offset;
		public bool bHighPriorityLoadingLocal
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHighPriorityLoadingLocal__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int ReplicationViewers__Offset;
		public TStructArray<FNetViewer> ReplicationViewers
		{
			get{ CheckIsValid();return new TStructArray<FNetViewer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ReplicationViewers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ReplicationViewers__Offset, false);}
			
		}
		
		static readonly int AssetUserData__Offset;
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
