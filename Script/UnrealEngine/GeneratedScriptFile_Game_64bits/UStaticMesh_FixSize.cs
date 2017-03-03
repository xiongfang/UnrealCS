#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UStaticMesh
	{
		static readonly int MinLOD__Offset;
		public int MinLOD
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinLOD__Offset, typeof(int));}
			
		}
		
		static readonly int Materials__Offset;
		public TObjectArray<UMaterialInterface>  Materials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Materials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Materials__Offset, false);}
			
		}
		
		static readonly int StaticMaterials__Offset;
		public TStructArray<FStaticMaterial> StaticMaterials
		{
			get{ CheckIsValid();return new TStructArray<FStaticMaterial>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StaticMaterials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StaticMaterials__Offset, false);}
			
		}
		
		static readonly int LightmapUVDensity__Offset;
		public float LightmapUVDensity
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightmapUVDensity__Offset, typeof(float));}
			
		}
		
		static readonly int LightMapResolution__Offset;
		public int LightMapResolution
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LightMapResolution__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightMapResolution__Offset, false);}
			
		}
		
		static readonly int LightMapCoordinateIndex__Offset;
		public int LightMapCoordinateIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LightMapCoordinateIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightMapCoordinateIndex__Offset, false);}
			
		}
		
		static readonly int bGenerateMeshDistanceField__Offset;
		public bool bGenerateMeshDistanceField
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateMeshDistanceField__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateMeshDistanceField__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BodySetup__Offset;
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + BodySetup__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + BodySetup__Offset, value._this.Get()); }
			
		}
		
		static readonly int LODForCollision__Offset;
		public int LODForCollision
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LODForCollision__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODForCollision__Offset, false);}
			
		}
		
		static readonly int bStripComplexCollisionForConsole__Offset;
		public bool bStripComplexCollisionForConsole
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStripComplexCollisionForConsole__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasNavigationData__Offset;
		public bool bHasNavigationData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasNavigationData__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHasNavigationData__Offset, 1,0,2,2);}
			
		}
		
		static readonly int LpvBiasMultiplier__Offset;
		public float LpvBiasMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LpvBiasMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LpvBiasMultiplier__Offset, false);}
			
		}
		
		static readonly int bAllowCPUAccess__Offset;
		public bool bAllowCPUAccess
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowCPUAccess__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowCPUAccess__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Sockets__Offset;
		public TObjectArray<UStaticMeshSocket>  Sockets
		{
					get{ CheckIsValid();return new TObjectArray<UStaticMeshSocket>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sockets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sockets__Offset, false);}
			
		}
		
		static readonly int PositiveBoundsExtension__Offset;
		public FVector PositiveBoundsExtension
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PositiveBoundsExtension__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PositiveBoundsExtension__Offset, false);}
			
		}
		
		static readonly int NegativeBoundsExtension__Offset;
		public FVector NegativeBoundsExtension
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NegativeBoundsExtension__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NegativeBoundsExtension__Offset, false);}
			
		}
		
		static readonly int ExtendedBounds__Offset;
		public FBoxSphereBounds ExtendedBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+ExtendedBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int ElementToIgnoreForTexFactor__Offset;
		public int ElementToIgnoreForTexFactor
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ElementToIgnoreForTexFactor__Offset, typeof(int));}
			
		}
		
		static readonly int AssetUserData__Offset;
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int NavCollision__Offset;
		public UNavCollision NavCollision
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavCollision__Offset); if (v == IntPtr.Zero)return null; UNavCollision retValue = new UNavCollision(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + NavCollision__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + NavCollision__Offset, value._this.Get()); }
			
		}
		
		static UStaticMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StaticMesh");
			MinLOD__Offset=GetPropertyOffset(NativeClassPtr,"MinLOD");
			Materials__Offset=GetPropertyOffset(NativeClassPtr,"Materials");
			StaticMaterials__Offset=GetPropertyOffset(NativeClassPtr,"StaticMaterials");
			LightmapUVDensity__Offset=GetPropertyOffset(NativeClassPtr,"LightmapUVDensity");
			LightMapResolution__Offset=GetPropertyOffset(NativeClassPtr,"LightMapResolution");
			LightMapCoordinateIndex__Offset=GetPropertyOffset(NativeClassPtr,"LightMapCoordinateIndex");
			bGenerateMeshDistanceField__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateMeshDistanceField");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			LODForCollision__Offset=GetPropertyOffset(NativeClassPtr,"LODForCollision");
			bStripComplexCollisionForConsole__Offset=GetPropertyOffset(NativeClassPtr,"bStripComplexCollisionForConsole");
			bHasNavigationData__Offset=GetPropertyOffset(NativeClassPtr,"bHasNavigationData");
			LpvBiasMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"LpvBiasMultiplier");
			bAllowCPUAccess__Offset=GetPropertyOffset(NativeClassPtr,"bAllowCPUAccess");
			Sockets__Offset=GetPropertyOffset(NativeClassPtr,"Sockets");
			PositiveBoundsExtension__Offset=GetPropertyOffset(NativeClassPtr,"PositiveBoundsExtension");
			NegativeBoundsExtension__Offset=GetPropertyOffset(NativeClassPtr,"NegativeBoundsExtension");
			ExtendedBounds__Offset=GetPropertyOffset(NativeClassPtr,"ExtendedBounds");
			ElementToIgnoreForTexFactor__Offset=GetPropertyOffset(NativeClassPtr,"ElementToIgnoreForTexFactor");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			NavCollision__Offset=GetPropertyOffset(NativeClassPtr,"NavCollision");
			
		}
		
	}
	
}
#endif
#endif
