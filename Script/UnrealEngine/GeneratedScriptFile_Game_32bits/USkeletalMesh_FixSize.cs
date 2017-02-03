#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeletalMesh
	{
		static readonly int Skeleton__Offset;
		public USkeleton Skeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Skeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, value._this.Get()); }
			
		}
		
		static readonly int ImportedBounds__Offset;
		public FBoxSphereBounds ImportedBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+ImportedBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int ExtendedBounds__Offset;
		public FBoxSphereBounds ExtendedBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+ExtendedBounds__Offset, typeof(FBoxSphereBounds));}
			
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
		
		static readonly int Materials__Offset;
		public TStructArray<FSkeletalMaterial> Materials
		{
			get{ CheckIsValid();return new TStructArray<FSkeletalMaterial>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Materials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Materials__Offset, false);}
			
		}
		
		static readonly int SkelMirrorTable__Offset;
		public TStructArray<FBoneMirrorInfo> SkelMirrorTable
		{
			get{ CheckIsValid();return new TStructArray<FBoneMirrorInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SkelMirrorTable__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SkelMirrorTable__Offset, false);}
			
		}
		
		static readonly int SkelMirrorAxis__Offset;
		public EAxis SkelMirrorAxis
		{
			get{ CheckIsValid();return (EAxis)Marshal.PtrToStructure(_this.Get()+SkelMirrorAxis__Offset, typeof(EAxis));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SkelMirrorAxis__Offset, false);}
			
		}
		
		static readonly int SkelMirrorFlipAxis__Offset;
		public EAxis SkelMirrorFlipAxis
		{
			get{ CheckIsValid();return (EAxis)Marshal.PtrToStructure(_this.Get()+SkelMirrorFlipAxis__Offset, typeof(EAxis));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SkelMirrorFlipAxis__Offset, false);}
			
		}
		
		static readonly int LODInfo__Offset;
		public TStructArray<FSkeletalMeshLODInfo> LODInfo
		{
			get{ CheckIsValid();return new TStructArray<FSkeletalMeshLODInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODInfo__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODInfo__Offset, false);}
			
		}
		
		static readonly int bUseFullPrecisionUVs__Offset;
		public bool bUseFullPrecisionUVs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFullPrecisionUVs__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFullPrecisionUVs__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bHasBeenSimplified__Offset;
		public bool bHasBeenSimplified
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasBeenSimplified__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bHasVertexColors__Offset;
		public bool bHasVertexColors
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasVertexColors__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bEnablePerPolyCollision__Offset;
		public bool bEnablePerPolyCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePerPolyCollision__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePerPolyCollision__Offset, 1,0,8,8);}
			
		}
		
		static readonly int BodySetup__Offset;
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PhysicsAsset__Offset;
		public UPhysicsAsset PhysicsAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsAsset__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysicsAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysicsAsset__Offset, value._this.Get()); }
			
		}
		
		static readonly int ShadowPhysicsAsset__Offset;
		public UPhysicsAsset ShadowPhysicsAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShadowPhysicsAsset__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ShadowPhysicsAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ShadowPhysicsAsset__Offset, value._this.Get()); }
			
		}
		
		static readonly int MorphTargets__Offset;
		public TObjectArray<UMorphTarget>  MorphTargets
		{
					get{ CheckIsValid();return new TObjectArray<UMorphTarget>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MorphTargets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MorphTargets__Offset, false);}
			
		}
		
		static readonly int ClothingAssets__Offset;
		public TStructArray<FClothingAssetData> ClothingAssets
		{
			get{ CheckIsValid();return new TStructArray<FClothingAssetData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ClothingAssets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ClothingAssets__Offset, false);}
			
		}
		
		static readonly int PostProcessAnimBlueprint__Offset;
		public TSubclassOf<UAnimInstance>  PostProcessAnimBlueprint
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PostProcessAnimBlueprint__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PostProcessAnimBlueprint__Offset, value); }
			
		}
		
		static readonly int AssetUserData__Offset;
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int Sockets__Offset;
		public TObjectArray<USkeletalMeshSocket>  Sockets
		{
					get{ CheckIsValid();return new TObjectArray<USkeletalMeshSocket>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sockets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sockets__Offset, false);}
			
		}
		
		static USkeletalMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalMesh");
			Skeleton__Offset=GetPropertyOffset(NativeClassPtr,"Skeleton");
			ImportedBounds__Offset=GetPropertyOffset(NativeClassPtr,"ImportedBounds");
			ExtendedBounds__Offset=GetPropertyOffset(NativeClassPtr,"ExtendedBounds");
			PositiveBoundsExtension__Offset=GetPropertyOffset(NativeClassPtr,"PositiveBoundsExtension");
			NegativeBoundsExtension__Offset=GetPropertyOffset(NativeClassPtr,"NegativeBoundsExtension");
			Materials__Offset=GetPropertyOffset(NativeClassPtr,"Materials");
			SkelMirrorTable__Offset=GetPropertyOffset(NativeClassPtr,"SkelMirrorTable");
			SkelMirrorAxis__Offset=GetPropertyOffset(NativeClassPtr,"SkelMirrorAxis");
			SkelMirrorFlipAxis__Offset=GetPropertyOffset(NativeClassPtr,"SkelMirrorFlipAxis");
			LODInfo__Offset=GetPropertyOffset(NativeClassPtr,"LODInfo");
			bUseFullPrecisionUVs__Offset=GetPropertyOffset(NativeClassPtr,"bUseFullPrecisionUVs");
			bHasBeenSimplified__Offset=GetPropertyOffset(NativeClassPtr,"bHasBeenSimplified");
			bHasVertexColors__Offset=GetPropertyOffset(NativeClassPtr,"bHasVertexColors");
			bEnablePerPolyCollision__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePerPolyCollision");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			PhysicsAsset__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsAsset");
			ShadowPhysicsAsset__Offset=GetPropertyOffset(NativeClassPtr,"ShadowPhysicsAsset");
			MorphTargets__Offset=GetPropertyOffset(NativeClassPtr,"MorphTargets");
			ClothingAssets__Offset=GetPropertyOffset(NativeClassPtr,"ClothingAssets");
			PostProcessAnimBlueprint__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessAnimBlueprint");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			Sockets__Offset=GetPropertyOffset(NativeClassPtr,"Sockets");
			
		}
		
	}
	
}
#endif
#endif
