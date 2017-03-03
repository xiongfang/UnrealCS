#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Skinned mesh component that supports bone skinned mesh rendering.
	/// This class does not support animation.
	/// @see USkeletalMeshComponent
	/// </summary>
	public partial class USkinnedMeshComponent
	{
		static readonly int SkeletalMesh__Offset;
		/// <summary>The skeletal mesh used by this component.</summary>
		public USkeletalMesh SkeletalMesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SkeletalMesh__Offset); if (v == IntPtr.Zero)return null; USkeletalMesh retValue = new USkeletalMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SkeletalMesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SkeletalMesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int bUseBoundsFromMasterPoseComponent__Offset;
		/// <summary>
		/// When true, we will just using the bounds from our MasterPoseComponent.  This is useful for when we have a Mesh Parented
		/// to the main SkelMesh (e.g. outline mesh or a full body overdraw effect that is toggled) that is always going to be the same
		/// bounds as parent.  We want to do no calculations in that case.
		/// </summary>
		public bool bUseBoundsFromMasterPoseComponent
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseBoundsFromMasterPoseComponent__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseBoundsFromMasterPoseComponent__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ChunkIndexPreview__Offset;
		/// <summary>Index of the chunk to preview... If set to -1, all chunks will be rendered</summary>
		public int ChunkIndexPreview
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ChunkIndexPreview__Offset, typeof(int));}
			
		}
		
		static readonly int SectionIndexPreview__Offset;
		/// <summary>Index of the section to preview... If set to -1, all section will be rendered</summary>
		public int SectionIndexPreview
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SectionIndexPreview__Offset, typeof(int));}
			
		}
		
		static readonly int PhysicsAssetOverride__Offset;
		/// <summary>PhysicsAsset is set in SkeletalMesh by default, but you can override with this value</summary>
		public UPhysicsAsset PhysicsAssetOverride
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PhysicsAssetOverride__Offset); if (v == IntPtr.Zero)return null; UPhysicsAsset retValue = new UPhysicsAsset(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PhysicsAssetOverride__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PhysicsAssetOverride__Offset, value._this.Get()); }
			
		}
		
		static readonly int ForcedLodModel__Offset;
		/// <summary>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).</summary>
		public int ForcedLodModel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ForcedLodModel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForcedLodModel__Offset, false);}
			
		}
		
		static readonly int MinLodModel__Offset;
		/// <summary>
		/// This is the min LOD that this component will use.  (e.g. if set to 2 then only 2+ LOD Models will be used.) This is useful to set on
		/// meshes which are known to be a certain distance away and still want to have better LODs when zoomed in on them.
		/// </summary>
		public int MinLodModel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinLodModel__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinLodModel__Offset, false);}
			
		}
		
		static readonly int LODInfo__Offset;
		/// <summary>LOD array info. Each index will correspond to the LOD index *</summary>
		public TStructArray<FSkelMeshComponentLODInfo> LODInfo
		{
			get{ CheckIsValid();return new TStructArray<FSkelMeshComponentLODInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODInfo__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODInfo__Offset, false);}
			
		}
		
		static readonly int StreamingDistanceMultiplier__Offset;
		/// <summary>
		/// Allows adjusting the desired streaming distance of streaming textures that uses UV 0.
		/// 1.0 is the default, whereas a higher value makes the textures stream in sooner from far away.
		/// A lower value (0.0-1.0) makes the textures stream in later (you have to be closer).
		/// Value can be < 0 (from legcay content, or code changes)
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StreamingDistanceMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StreamingDistanceMultiplier__Offset, false);}
			
		}
		
		static readonly int WireframeColor__Offset;
		/// <summary>Wireframe color</summary>
		public FColor WireframeColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+WireframeColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WireframeColor__Offset, false);}
			
		}
		
		static readonly int bForceWireframe__Offset;
		/// <summary>Forces the mesh to draw in wireframe mode.</summary>
		public bool bForceWireframe
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceWireframe__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDisplayBones__Offset;
		/// <summary>Draw the skeleton hierarchy for this skel mesh.</summary>
		public bool bDisplayBones
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisplayBones__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisableMorphTarget__Offset;
		/// <summary>Disable Morphtarget for this component.</summary>
		public bool bDisableMorphTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableMorphTarget__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableMorphTarget__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bHideSkin__Offset;
		/// <summary>Don't bother rendering the skin.</summary>
		public bool bHideSkin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHideSkin__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bPerBoneMotionBlur__Offset;
		/// <summary>If true, use per-bone motion blur on this skeletal mesh (requires additional rendering, can be disabled to save performance).</summary>
		public bool bPerBoneMotionBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPerBoneMotionBlur__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPerBoneMotionBlur__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bComponentUseFixedSkelBounds__Offset;
		/// <summary>When true, skip using the physics asset etc. and always use the fixed bounds defined in the SkeletalMesh.</summary>
		public bool bComponentUseFixedSkelBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bComponentUseFixedSkelBounds__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bComponentUseFixedSkelBounds__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bConsiderAllBodiesForBounds__Offset;
		/// <summary>If true, when updating bounds from a PhysicsAsset, consider _all_ BodySetups, not just those flagged with bConsiderForBounds.</summary>
		public bool bConsiderAllBodiesForBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConsiderAllBodiesForBounds__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bConsiderAllBodiesForBounds__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MeshComponentUpdateFlag__Offset;
		/// <summary>
		/// This is update frequency flag even when our Owner has not been rendered recently
		/// SMU_AlwaysTickPoseAndRefreshBones,                   // Always Tick and Refresh BoneTransforms whether rendered or not
		/// SMU_AlwaysTickPose,                                                  // Always Tick, but Refresh BoneTransforms only when rendered
		/// SMU_OnlyTickPoseWhenRendered,                                // Tick only when rendered, and it will only RefreshBoneTransforms when rendered
		/// </summary>
		public EMeshComponentUpdateFlag MeshComponentUpdateFlag
		{
			get{ CheckIsValid();return (EMeshComponentUpdateFlag)Marshal.PtrToStructure(_this.Get()+MeshComponentUpdateFlag__Offset, typeof(EMeshComponentUpdateFlag));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MeshComponentUpdateFlag__Offset, false);}
			
		}
		
		static readonly int bForceMeshObjectUpdate__Offset;
		/// <summary>If true, UpdateTransform will always result in a call to MeshObject->Update.</summary>
		public bool bForceMeshObjectUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMeshObjectUpdate__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCanHighlightSelectedSections__Offset;
		/// <summary>Whether or not we can highlight selected sections - this should really only be done in the editor</summary>
		public bool bCanHighlightSelectedSections
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanHighlightSelectedSections__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bRecentlyRendered__Offset;
		/// <summary>true if mesh has been recently rendered, false otherwise</summary>
		public bool bRecentlyRendered
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRecentlyRendered__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int ProgressiveDrawingFraction__Offset;
		/// <summary>
		/// Editor only. Used for visualizing drawing order in Animset Viewer. If < 1.0,
		/// only the specified fraction of triangles will be rendered
		/// </summary>
		public float ProgressiveDrawingFraction
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProgressiveDrawingFraction__Offset, typeof(float));}
			
		}
		
		static readonly int CustomSortAlternateIndexMode__Offset;
		/// <summary>
		/// Editor only. Used for manually selecting the alternate indices for
		/// TRISORT_CustomLeftRight sections.
		/// </summary>
		public byte CustomSortAlternateIndexMode
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+CustomSortAlternateIndexMode__Offset, typeof(byte));}
			
		}
		
		static readonly int bCastCapsuleDirectShadow__Offset;
		/// <summary>
		/// Whether to use the capsule representation (when present) from a skeletal mesh's ShadowPhysicsAsset for direct shadowing from lights.
		/// This type of shadowing is approximate but handles extremely wide area shadowing well.  The softness of the shadow depends on the light's LightSourceAngle / SourceRadius.
		/// This flag will force bCastInsetShadow to be enabled.
		/// </summary>
		public bool bCastCapsuleDirectShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastCapsuleDirectShadow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastCapsuleDirectShadow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCastCapsuleIndirectShadow__Offset;
		/// <summary>Whether to use the capsule representation (when present) from a skeletal mesh's ShadowPhysicsAsset for shadowing indirect lighting (from lightmaps or skylight).</summary>
		public bool bCastCapsuleIndirectShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastCapsuleIndirectShadow__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastCapsuleIndirectShadow__Offset, 1,0,2,2);}
			
		}
		
		static readonly int CapsuleIndirectShadowMinVisibility__Offset;
		/// <summary>Controls how dark the capsule indirect shadow can be.</summary>
		public float CapsuleIndirectShadowMinVisibility
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CapsuleIndirectShadowMinVisibility__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CapsuleIndirectShadowMinVisibility__Offset, false);}
			
		}
		
		static readonly int bCPUSkinning__Offset;
		/// <summary>CPU skinning rendering - only for previewing in Persona and conversion tools</summary>
		public bool bCPUSkinning
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCPUSkinning__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CachedLocalBounds__Offset;
		/// <summary>LocalBounds cached, so they're computed just once.</summary>
		public FBoxSphereBounds CachedLocalBounds
		{
			get{ CheckIsValid();return (FBoxSphereBounds)Marshal.PtrToStructure(_this.Get()+CachedLocalBounds__Offset, typeof(FBoxSphereBounds));}
			
		}
		
		static readonly int bCachedLocalBoundsUpToDate__Offset;
		/// <summary>true when CachedLocalBounds is up to date.</summary>
		public bool bCachedLocalBoundsUpToDate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCachedLocalBoundsUpToDate__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEnableUpdateRateOptimizations__Offset;
		/// <summary>
		/// if TRUE, Owner will determine how often animation will be updated and evaluated. See AnimUpdateRateTick()
		/// This allows to skip frames for performance. (For example based on visibility and size on screen).
		/// </summary>
		public bool bEnableUpdateRateOptimizations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableUpdateRateOptimizations__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableUpdateRateOptimizations__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDisplayDebugUpdateRateOptimizations__Offset;
		/// <summary>
		/// Enable on screen debugging of update rate optimization.
		/// Red = Skipping 0 frames, Green = skipping 1 frame, Blue = skipping 2 frames, black = skipping more than 2 frames.
		/// @todo: turn this into a console command.
		/// </summary>
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
			ChunkIndexPreview__Offset=GetPropertyOffset(NativeClassPtr,"ChunkIndexPreview");
			SectionIndexPreview__Offset=GetPropertyOffset(NativeClassPtr,"SectionIndexPreview");
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
			ProgressiveDrawingFraction__Offset=GetPropertyOffset(NativeClassPtr,"ProgressiveDrawingFraction");
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
