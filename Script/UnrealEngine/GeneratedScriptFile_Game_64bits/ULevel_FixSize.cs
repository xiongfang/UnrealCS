#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULevel
	{
		static readonly int OwningWorld__Offset;
		public UWorld OwningWorld
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwningWorld__Offset); if (v == IntPtr.Zero)return null; UWorld retValue = new UWorld(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Model__Offset;
		public UModel Model
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Model__Offset); if (v == IntPtr.Zero)return null; UModel retValue = new UModel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ModelComponents__Offset;
		public TObjectArray<UModelComponent>  ModelComponents
		{
					get{ CheckIsValid();return new TObjectArray<UModelComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ModelComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ModelComponents__Offset, false);}
			
		}
		
		static readonly int NumTextureStreamingUnbuiltComponents__Offset;
		public int NumTextureStreamingUnbuiltComponents
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumTextureStreamingUnbuiltComponents__Offset, typeof(int));}
			
		}
		
		static readonly int NumTextureStreamingDirtyResources__Offset;
		public int NumTextureStreamingDirtyResources
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumTextureStreamingDirtyResources__Offset, typeof(int));}
			
		}
		
		static readonly int LevelScriptActor__Offset;
		public ALevelScriptActor LevelScriptActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelScriptActor__Offset); if (v == IntPtr.Zero)return null; ALevelScriptActor retValue = new ALevelScriptActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavListStart__Offset;
		public ANavigationObjectBase NavListStart
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavListStart__Offset); if (v == IntPtr.Zero)return null; ANavigationObjectBase retValue = new ANavigationObjectBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavListEnd__Offset;
		public ANavigationObjectBase NavListEnd
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavListEnd__Offset); if (v == IntPtr.Zero)return null; ANavigationObjectBase retValue = new ANavigationObjectBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavDataChunks__Offset;
		public TObjectArray<UNavigationDataChunk>  NavDataChunks
		{
					get{ CheckIsValid();return new TObjectArray<UNavigationDataChunk>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NavDataChunks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NavDataChunks__Offset, false);}
			
		}
		
		static readonly int LightmapTotalSize__Offset;
		public float LightmapTotalSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightmapTotalSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmapTotalSize__Offset, false);}
			
		}
		
		static readonly int ShadowmapTotalSize__Offset;
		public float ShadowmapTotalSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowmapTotalSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowmapTotalSize__Offset, false);}
			
		}
		
		static readonly int StaticNavigableGeometry__Offset;
		public TStructArray<FVector> StaticNavigableGeometry
		{
			get{ CheckIsValid();return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StaticNavigableGeometry__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StaticNavigableGeometry__Offset, false);}
			
		}
		
		static readonly int StreamingTextureGuids__Offset;
		public TStructArray<FGuid> StreamingTextureGuids
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingTextureGuids__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingTextureGuids__Offset, false);}
			
		}
		
		static readonly int bIsLightingScenario__Offset;
		public bool bIsLightingScenario
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsLightingScenario__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int LevelBuildDataId__Offset;
		public FGuid LevelBuildDataId
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LevelBuildDataId__Offset, typeof(FGuid));}
			
		}
		
		static readonly int MapBuildData__Offset;
		public UMapBuildDataRegistry MapBuildData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MapBuildData__Offset); if (v == IntPtr.Zero)return null; UMapBuildDataRegistry retValue = new UMapBuildDataRegistry(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LightBuildLevelOffset__Offset;
		public FIntVector LightBuildLevelOffset
		{
			get{ CheckIsValid();return (FIntVector)Marshal.PtrToStructure(_this.Get()+LightBuildLevelOffset__Offset, typeof(FIntVector));}
			
		}
		
		static readonly int bTextureStreamingRotationChanged__Offset;
		public bool bTextureStreamingRotationChanged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTextureStreamingRotationChanged__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsVisible__Offset;
		public bool bIsVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVisible__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bLocked__Offset;
		public bool bLocked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLocked__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int WorldSettings__Offset;
		public AWorldSettings WorldSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WorldSettings__Offset); if (v == IntPtr.Zero)return null; AWorldSettings retValue = new AWorldSettings(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AssetUserData__Offset;
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static ULevel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Level");
			OwningWorld__Offset=GetPropertyOffset(NativeClassPtr,"OwningWorld");
			Model__Offset=GetPropertyOffset(NativeClassPtr,"Model");
			ModelComponents__Offset=GetPropertyOffset(NativeClassPtr,"ModelComponents");
			NumTextureStreamingUnbuiltComponents__Offset=GetPropertyOffset(NativeClassPtr,"NumTextureStreamingUnbuiltComponents");
			NumTextureStreamingDirtyResources__Offset=GetPropertyOffset(NativeClassPtr,"NumTextureStreamingDirtyResources");
			LevelScriptActor__Offset=GetPropertyOffset(NativeClassPtr,"LevelScriptActor");
			NavListStart__Offset=GetPropertyOffset(NativeClassPtr,"NavListStart");
			NavListEnd__Offset=GetPropertyOffset(NativeClassPtr,"NavListEnd");
			NavDataChunks__Offset=GetPropertyOffset(NativeClassPtr,"NavDataChunks");
			LightmapTotalSize__Offset=GetPropertyOffset(NativeClassPtr,"LightmapTotalSize");
			ShadowmapTotalSize__Offset=GetPropertyOffset(NativeClassPtr,"ShadowmapTotalSize");
			StaticNavigableGeometry__Offset=GetPropertyOffset(NativeClassPtr,"StaticNavigableGeometry");
			StreamingTextureGuids__Offset=GetPropertyOffset(NativeClassPtr,"StreamingTextureGuids");
			bIsLightingScenario__Offset=GetPropertyOffset(NativeClassPtr,"bIsLightingScenario");
			LevelBuildDataId__Offset=GetPropertyOffset(NativeClassPtr,"LevelBuildDataId");
			MapBuildData__Offset=GetPropertyOffset(NativeClassPtr,"MapBuildData");
			LightBuildLevelOffset__Offset=GetPropertyOffset(NativeClassPtr,"LightBuildLevelOffset");
			bTextureStreamingRotationChanged__Offset=GetPropertyOffset(NativeClassPtr,"bTextureStreamingRotationChanged");
			bIsVisible__Offset=GetPropertyOffset(NativeClassPtr,"bIsVisible");
			bLocked__Offset=GetPropertyOffset(NativeClassPtr,"bLocked");
			WorldSettings__Offset=GetPropertyOffset(NativeClassPtr,"WorldSettings");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			
		}
		
	}
	
}
#endif
#endif
