#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// SkeletalMesh is geometry bound to a hierarchical skeleton of bones which can be animated for the purpose of deforming the mesh.
	/// Skeletal Meshes are built up of two parts; a set of polygons composed to make up the surface of the mesh, and a hierarchical skeleton which can be used to animate the polygons.
	/// The 3D models, rigging, and animations are created in an external modeling and animation application (3DSMax, Maya, Softimage, etc).
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/SkeletalMeshes/
	/// </summary>
	public partial class USkeletalMesh
	{
		static readonly int Skeleton__Offset;
		/// <summary>Skeleton of this skeletal mesh *</summary>
		public USkeleton Skeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Skeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Skeleton__Offset, value._this.Get()); }
			
		}
		
		static readonly int ImportedBounds__Offset;
		/// <summary>Original imported mesh bounds</summary>
		public FBoxSphereBounds ImportedBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+ImportedBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int ExtendedBounds__Offset;
		/// <summary>Bounds extended by user values below</summary>
		public FBoxSphereBounds ExtendedBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+ExtendedBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int PositiveBoundsExtension__Offset;
		/// <summary>
		/// Bound extension values in addition to imported bound in the positive direction of XYZ,
		///     positive value increases bound size and negative value decreases bound size.
		///     The final bound would be from [Imported Bound - Negative Bound] to [Imported Bound + Positive Bound].
		/// </summary>
		public FVector PositiveBoundsExtension
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PositiveBoundsExtension__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PositiveBoundsExtension__Offset, false);}
			
		}
		
		static readonly int NegativeBoundsExtension__Offset;
		/// <summary>
		/// Bound extension values in addition to imported bound in the negative direction of XYZ,
		///     positive value increases bound size and negative value decreases bound size.
		///     The final bound would be from [Imported Bound - Negative Bound] to [Imported Bound + Positive Bound].
		/// </summary>
		public FVector NegativeBoundsExtension
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NegativeBoundsExtension__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NegativeBoundsExtension__Offset, false);}
			
		}
		
		static readonly int Materials__Offset;
		/// <summary>List of materials applied to this mesh.</summary>
		public TStructArray<FSkeletalMaterial> Materials
		{
			get{ CheckIsValid();return new TStructArray<FSkeletalMaterial>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Materials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Materials__Offset, false);}
			
		}
		
		static readonly int SkelMirrorTable__Offset;
		/// <summary>List of bones that should be mirrored.</summary>
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
		/// <summary>Struct containing information for each LOD level, such as materials to use, and when use the LOD.</summary>
		public TStructArray<FSkeletalMeshLODInfo> LODInfo
		{
			get{ CheckIsValid();return new TStructArray<FSkeletalMeshLODInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODInfo__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODInfo__Offset, false);}
			
		}
		
		static readonly int bUseFullPrecisionUVs__Offset;
		/// <summary>If true, use 32 bit UVs. If false, use 16 bit UVs to save memory</summary>
		public bool bUseFullPrecisionUVs
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFullPrecisionUVs__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFullPrecisionUVs__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bHasBeenSimplified__Offset;
		/// <summary>true if this mesh has ever been simplified with Simplygon.</summary>
		public bool bHasBeenSimplified
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasBeenSimplified__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bHasVertexColors__Offset;
		/// <summary>Whether or not the mesh has vertex colors</summary>
		public bool bHasVertexColors
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasVertexColors__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bEnablePerPolyCollision__Offset;
		/// <summary>Uses skinned data for collision data. Per poly collision cannot be used for simulation, in most cases you are better off using the physics asset</summary>
		public bool bEnablePerPolyCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePerPolyCollision__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePerPolyCollision__Offset, 1,0,8,8);}
			
		}
		
		static readonly int BodySetup__Offset;
		/// <summary>Physics data for the per poly collision case. In 99% of cases you will not need this and are better off using simple ragdoll collision (physics asset)</summary>
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PhysicsAsset__Offset;
		/// <summary>
		/// Physics and collision information used for this USkeletalMesh, set up in PhAT.
		/// This is used for per-bone hit detection, accurate bounding box calculation and ragdoll physics for example.
		/// </summary>
		public UPhysicsAsset PhysicsAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsAsset__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysicsAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysicsAsset__Offset, value._this.Get()); }
			
		}
		
		static readonly int ShadowPhysicsAsset__Offset;
		/// <summary>
		/// Physics asset whose shapes will be used for shadowing when components have bCastCharacterCapsuleDirectShadow or bCastCharacterCapsuleIndirectShadow enabled.
		/// Only spheres and sphyl shapes in the physics asset can be supported.  The more shapes used, the higher the cost of the capsule shadows will be.
		/// </summary>
		public UPhysicsAsset ShadowPhysicsAsset
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ShadowPhysicsAsset__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ShadowPhysicsAsset__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ShadowPhysicsAsset__Offset, value._this.Get()); }
			
		}
		
		static readonly int AssetImportData__Offset;
		/// <summary>Importing data and options used for this mesh</summary>
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static readonly int SourceFilePath__Offset;
		/// <summary>Path to the resource used to construct this skeletal mesh</summary>
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int SourceFileTimestamp__Offset;
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFileTimestamp__Offset, typeof(FString));}
			
		}
		
		static readonly int ThumbnailInfo__Offset;
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailInfo__Offset); if (v == IntPtr.Zero)return null; UThumbnailInfo retValue = new UThumbnailInfo(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + ThumbnailInfo__Offset, value._this.Get()); }
			
		}
		
		static readonly int OptimizationSettings__Offset;
		/// <summary>Optimization settings used to simplify LODs of this mesh.</summary>
		public TStructArray<FSkeletalMeshOptimizationSettings> OptimizationSettings
		{
			get{ CheckIsValid();return new TStructArray<FSkeletalMeshOptimizationSettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OptimizationSettings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OptimizationSettings__Offset, false);}
			
		}
		
		static readonly int PreviewAttachedAssetContainer__Offset;
		/// <summary>Attached assets component for this mesh</summary>
		public FPreviewAssetAttachContainer PreviewAttachedAssetContainer
		{
			get{ CheckIsValid();return (FPreviewAssetAttachContainer)Marshal.PtrToStructure(_this.Get()+PreviewAttachedAssetContainer__Offset, typeof(FPreviewAssetAttachContainer));}
			
		}
		
		static readonly int MorphTargets__Offset;
		public TObjectArray<UMorphTarget>  MorphTargets
		{
					get{ CheckIsValid();return new TObjectArray<UMorphTarget>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MorphTargets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MorphTargets__Offset, false);}
			
		}
		
		static readonly int SelectedEditorSection__Offset;
		/// <summary>The section currently selected in the Editor. Used for highlighting</summary>
		public int SelectedEditorSection
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SelectedEditorSection__Offset, typeof(int));}
			
		}
		
		static readonly int SelectedClothingSection__Offset;
		/// <summary>The section currently selected for clothing. need to remember this index for reimporting cloth</summary>
		public int SelectedClothingSection
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SelectedClothingSection__Offset, typeof(int));}
			
		}
		
		static readonly int FloorOffset__Offset;
		/// <summary>Height offset for the floor mesh in the editor</summary>
		public float FloorOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FloorOffset__Offset, typeof(float));}
			
		}
		
		static readonly int RetargetBasePose__Offset;
		/// <summary>This is buffer that saves pose that is used by retargeting</summary>
		public TStructArray<FTransform> RetargetBasePose
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RetargetBasePose__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RetargetBasePose__Offset, false);}
			
		}
		
		static readonly int ClothingAssets__Offset;
		/// <summary>Clothing asset data</summary>
		public TStructArray<FClothingAssetData> ClothingAssets
		{
			get{ CheckIsValid();return new TStructArray<FClothingAssetData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ClothingAssets__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ClothingAssets__Offset, false);}
			
		}
		
		static readonly int PostProcessAnimBlueprint__Offset;
		/// <summary>
		/// Animation Blueprint class to run as a post process for this mesh.
		/// This blueprint will be ran before physics, but after the main
		/// anim instance for any skeletal mesh component using this mesh.
		/// </summary>
		public TSubclassOf<UAnimInstance>  PostProcessAnimBlueprint
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PostProcessAnimBlueprint__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PostProcessAnimBlueprint__Offset, value); }
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the asset</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int Sockets__Offset;
		/// <summary>
		/// Array of named socket locations, set up in editor and used as a shortcut instead of specifying
		/// everything explicitly to AttachComponent in the SkeletalMeshComponent.
		/// </summary>
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
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			SourceFileTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"SourceFileTimestamp");
			ThumbnailInfo__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailInfo");
			OptimizationSettings__Offset=GetPropertyOffset(NativeClassPtr,"OptimizationSettings");
			PreviewAttachedAssetContainer__Offset=GetPropertyOffset(NativeClassPtr,"PreviewAttachedAssetContainer");
			MorphTargets__Offset=GetPropertyOffset(NativeClassPtr,"MorphTargets");
			SelectedEditorSection__Offset=GetPropertyOffset(NativeClassPtr,"SelectedEditorSection");
			SelectedClothingSection__Offset=GetPropertyOffset(NativeClassPtr,"SelectedClothingSection");
			FloorOffset__Offset=GetPropertyOffset(NativeClassPtr,"FloorOffset");
			RetargetBasePose__Offset=GetPropertyOffset(NativeClassPtr,"RetargetBasePose");
			ClothingAssets__Offset=GetPropertyOffset(NativeClassPtr,"ClothingAssets");
			PostProcessAnimBlueprint__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessAnimBlueprint");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			Sockets__Offset=GetPropertyOffset(NativeClassPtr,"Sockets");
			
		}
		
	}
	
}
#endif
#endif
