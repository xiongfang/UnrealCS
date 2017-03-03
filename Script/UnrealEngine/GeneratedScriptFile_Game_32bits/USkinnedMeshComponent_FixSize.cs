#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkinnedMeshComponent
	{
		static readonly int SkeletalMesh__Offset;
		public USkeletalMesh SkeletalMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SkeletalMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SkeletalMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SkeletalMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int bUseBoundsFromMasterPoseComponent__Offset;
		public bool bUseBoundsFromMasterPoseComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseBoundsFromMasterPoseComponent__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseBoundsFromMasterPoseComponent__Offset, 1,0,1,1);}
			
		}
		
		static readonly int PhysicsAssetOverride__Offset;
		public UPhysicsAsset PhysicsAssetOverride
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsAssetOverride__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysicsAssetOverride__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysicsAssetOverride__Offset, value._this.Get()); }
			
		}
		
		static readonly int ForcedLodModel__Offset;
		public int ForcedLodModel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ForcedLodModel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForcedLodModel__Offset, false);}
			
		}
		
		static readonly int MinLodModel__Offset;
		public int MinLodModel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinLodModel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinLodModel__Offset, false);}
			
		}
		
		static readonly int LODInfo__Offset;
		public TStructArray<FSkelMeshComponentLODInfo> LODInfo
		{
			get{ CheckIsValid();return new TStructArray<FSkelMeshComponentLODInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODInfo__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODInfo__Offset, false);}
			
		}
		
		static readonly int StreamingDistanceMultiplier__Offset;
		public float StreamingDistanceMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StreamingDistanceMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingDistanceMultiplier__Offset, false);}
			
		}
		
		static readonly int WireframeColor__Offset;
		public FColor WireframeColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+WireframeColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WireframeColor__Offset, false);}
			
		}
		
		static readonly int bForceWireframe__Offset;
		public bool bForceWireframe
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceWireframe__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDisplayBones__Offset;
		public bool bDisplayBones
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisplayBones__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisableMorphTarget__Offset;
		public bool bDisableMorphTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMorphTarget__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMorphTarget__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bHideSkin__Offset;
		public bool bHideSkin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHideSkin__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bPerBoneMotionBlur__Offset;
		public bool bPerBoneMotionBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPerBoneMotionBlur__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPerBoneMotionBlur__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bComponentUseFixedSkelBounds__Offset;
		public bool bComponentUseFixedSkelBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bComponentUseFixedSkelBounds__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bComponentUseFixedSkelBounds__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bConsiderAllBodiesForBounds__Offset;
		public bool bConsiderAllBodiesForBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConsiderAllBodiesForBounds__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConsiderAllBodiesForBounds__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MeshComponentUpdateFlag__Offset;
		public EMeshComponentUpdateFlag MeshComponentUpdateFlag
		{
			get{ CheckIsValid();return (EMeshComponentUpdateFlag)Marshal.PtrToStructure(_this.Get()+MeshComponentUpdateFlag__Offset, typeof(EMeshComponentUpdateFlag));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MeshComponentUpdateFlag__Offset, false);}
			
		}
		
		static readonly int bForceMeshObjectUpdate__Offset;
		public bool bForceMeshObjectUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMeshObjectUpdate__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCanHighlightSelectedSections__Offset;
		public bool bCanHighlightSelectedSections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanHighlightSelectedSections__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bRecentlyRendered__Offset;
		public bool bRecentlyRendered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRecentlyRendered__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int CustomSortAlternateIndexMode__Offset;
		public byte CustomSortAlternateIndexMode
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+CustomSortAlternateIndexMode__Offset, typeof(byte));}
			
		}
		
		static readonly int bCastCapsuleDirectShadow__Offset;
		public bool bCastCapsuleDirectShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastCapsuleDirectShadow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastCapsuleDirectShadow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCastCapsuleIndirectShadow__Offset;
		public bool bCastCapsuleIndirectShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastCapsuleIndirectShadow__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastCapsuleIndirectShadow__Offset, 1,0,2,2);}
			
		}
		
		static readonly int CapsuleIndirectShadowMinVisibility__Offset;
		public float CapsuleIndirectShadowMinVisibility
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CapsuleIndirectShadowMinVisibility__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CapsuleIndirectShadowMinVisibility__Offset, false);}
			
		}
		
		static readonly int bCPUSkinning__Offset;
		public bool bCPUSkinning
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCPUSkinning__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CachedLocalBounds__Offset;
		public FBoxSphereBounds CachedLocalBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+CachedLocalBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int bCachedLocalBoundsUpToDate__Offset;
		public bool bCachedLocalBoundsUpToDate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCachedLocalBoundsUpToDate__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEnableUpdateRateOptimizations__Offset;
		public bool bEnableUpdateRateOptimizations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableUpdateRateOptimizations__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableUpdateRateOptimizations__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDisplayDebugUpdateRateOptimizations__Offset;
		public bool bDisplayDebugUpdateRateOptimizations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisplayDebugUpdateRateOptimizations__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisplayDebugUpdateRateOptimizations__Offset, 1,0,1,255);}
			
		}
		
		static USkinnedMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkinnedMeshComponent");
			SkeletalMesh__Offset=GetPropertyOffset(NativeClassPtr,"SkeletalMesh");
			bUseBoundsFromMasterPoseComponent__Offset=GetPropertyOffset(NativeClassPtr,"bUseBoundsFromMasterPoseComponent");
			PhysicsAssetOverride__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsAssetOverride");
			ForcedLodModel__Offset=GetPropertyOffset(NativeClassPtr,"ForcedLodModel");
			MinLodModel__Offset=GetPropertyOffset(NativeClassPtr,"MinLodModel");
			LODInfo__Offset=GetPropertyOffset(NativeClassPtr,"LODInfo");
			StreamingDistanceMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"StreamingDistanceMultiplier");
			WireframeColor__Offset=GetPropertyOffset(NativeClassPtr,"WireframeColor");
			bForceWireframe__Offset=GetPropertyOffset(NativeClassPtr,"bForceWireframe");
			bDisplayBones__Offset=GetPropertyOffset(NativeClassPtr,"bDisplayBones");
			bDisableMorphTarget__Offset=GetPropertyOffset(NativeClassPtr,"bDisableMorphTarget");
			bHideSkin__Offset=GetPropertyOffset(NativeClassPtr,"bHideSkin");
			bPerBoneMotionBlur__Offset=GetPropertyOffset(NativeClassPtr,"bPerBoneMotionBlur");
			bComponentUseFixedSkelBounds__Offset=GetPropertyOffset(NativeClassPtr,"bComponentUseFixedSkelBounds");
			bConsiderAllBodiesForBounds__Offset=GetPropertyOffset(NativeClassPtr,"bConsiderAllBodiesForBounds");
			MeshComponentUpdateFlag__Offset=GetPropertyOffset(NativeClassPtr,"MeshComponentUpdateFlag");
			bForceMeshObjectUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bForceMeshObjectUpdate");
			bCanHighlightSelectedSections__Offset=GetPropertyOffset(NativeClassPtr,"bCanHighlightSelectedSections");
			bRecentlyRendered__Offset=GetPropertyOffset(NativeClassPtr,"bRecentlyRendered");
			CustomSortAlternateIndexMode__Offset=GetPropertyOffset(NativeClassPtr,"CustomSortAlternateIndexMode");
			bCastCapsuleDirectShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastCapsuleDirectShadow");
			bCastCapsuleIndirectShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastCapsuleIndirectShadow");
			CapsuleIndirectShadowMinVisibility__Offset=GetPropertyOffset(NativeClassPtr,"CapsuleIndirectShadowMinVisibility");
			bCPUSkinning__Offset=GetPropertyOffset(NativeClassPtr,"bCPUSkinning");
			CachedLocalBounds__Offset=GetPropertyOffset(NativeClassPtr,"CachedLocalBounds");
			bCachedLocalBoundsUpToDate__Offset=GetPropertyOffset(NativeClassPtr,"bCachedLocalBoundsUpToDate");
			bEnableUpdateRateOptimizations__Offset=GetPropertyOffset(NativeClassPtr,"bEnableUpdateRateOptimizations");
			bDisplayDebugUpdateRateOptimizations__Offset=GetPropertyOffset(NativeClassPtr,"bDisplayDebugUpdateRateOptimizations");
			
		}
		
	}
	
}
#endif
#endif
