using System;
namespace UnrealEngine
{
	public partial class USkinnedMeshComponent:UMeshComponent
	{
		/// <summary>
		/// Determines if the specified bone is hidden.
		/// @param  BoneName            Name of bone to check
		/// @return true if hidden
		/// </summary>
		public extern bool IsBoneHiddenByName(FName BoneName);
		/// <summary>
		/// UnHide the specified bone with name.  Currently this just enforces a scale of 0 for the hidden bones.
		/// Compoared to HideBone By Index - This keeps track of list of bones and update when LOD changes
		/// @param  BoneName            Name of bone to unhide
		/// </summary>
		public extern void UnHideBoneByName(FName BoneName);
		/// <summary>
		/// Hides the specified bone with name.  Currently this just enforces a scale of 0 for the hidden bones.
		/// Compoared to HideBone By Index - This keeps track of list of bones and update when LOD changes
		/// @param  BoneName            Name of bone to hide
		/// @param  PhysBodyOption          Option for physics bodies that attach to the bones to be hidden
		/// </summary>
		public extern void HideBoneByName(FName BoneName,EPhysBodyOp PhysBodyOption);
		/// <summary>
		/// finds the closest bone to the given location
		/// @param TestLocation the location to test against
		/// @param BoneLocation (optional, out) if specified, set to the world space location of the bone that was found, or (0,0,0) if no bone was found
		/// @param IgnoreScale (optional) if specified, only bones with scaling larger than the specified factor are considered
		/// @param bRequirePhysicsAsset (optional) if true, only bones with physics will be considered
		/// @return the name of the bone that was found, or 'None' if no bone was found
		/// </summary>
		public extern FName FindClosestBone_K2(FVector TestLocation,out FVector BoneLocation,float IgnoreScale=0.000000f,bool bRequirePhysicsAsset=false);
		/// <summary>
		/// Transform a location/rotation in bone relative space to world space.
		/// @param BoneName Name of bone
		/// @param InPosition Input position
		/// @param InRotation Input rotation
		/// @param OutPosition (out) Transformed position
		/// @param OutRotation (out) Transformed rotation
		/// </summary>
		public extern void TransformFromBoneSpace(FName BoneName,FVector InPosition,FRotator InRotation,out FVector OutPosition,out FRotator OutRotation);
		/// <summary>
		/// Transform a location/rotation from world space to bone relative space.
		/// This is handy if you know the location in world space for a bone attachment, as AttachComponent takes location/rotation in bone-relative space.
		/// @param BoneName Name of bone
		/// @param InPosition Input position
		/// @param InRotation Input rotation
		/// @param OutPosition (out) Transformed position
		/// @param OutRotation (out) Transformed rotation
		/// </summary>
		public extern void TransformToBoneSpace(FName BoneName,FVector InPosition,FRotator InRotation,out FVector OutPosition,out FRotator OutRotation);
		/// <summary>
		/// Tests if BoneName is child of (or equal to) ParentBoneName.
		/// @param BoneName Name of the bone
		/// @param ParentBone Name to check
		/// @return true if child (strictly, not same). false otherwise
		/// Note - will return false if ChildBoneIndex is the same as ParentBoneIndex ie. must be strictly a child.
		/// </summary>
		public extern bool BoneIsChildOf(FName BoneName,FName ParentBoneName);
		/// <summary>
		/// Set MasterPoseComponent for this component
		/// @param NewMasterBoneComponent New MasterPoseComponent
		/// </summary>
		public extern void SetMasterPoseComponent(USkinnedMeshComponent NewMasterBoneComponent);
		/// <summary>Clear any applied vertex color override</summary>
		public extern void ClearVertexColorOverride(int LODIndex);
		/// <summary>
		/// Get Parent Bone of the input bone
		/// @param BoneName Name of the bone
		/// @return the name of the parent bone for the specified bone. Returns 'None' if the bone does not exist or it is the root bone
		/// </summary>
		public extern FName GetParentBone(FName BoneName);
		/// <summary>
		/// Change the SkeletalMesh that is rendered for this Component. Will re-initialize the animation tree etc.
		/// @param NewMesh New mesh to set for this component
		/// @param bReinitPose Whether we should keep current pose or reinitialize.
		/// </summary>
		public extern virtual void SetSkeletalMesh(USkeletalMesh NewMesh,bool bReinitPose=true);
		/// <summary>
		/// Returns bone name linked to a given named socket on the skeletal mesh component.
		/// If you're unsure to deal with sockets or bones names, you can use this function to filter through, and always return the bone name.
		/// @param       bone name or socket name
		/// @return      bone name
		/// </summary>
		public extern FName GetSocketBoneName(FName InSocketName);
		/// <summary>
		/// Get Bone Name from index
		/// @param BoneIndex Index of the bone
		/// @return the name of the bone at the specified index
		/// </summary>
		public extern FName GetBoneName(int BoneIndex);
		/// <summary>
		/// Find the index of bone by name. Looks in the current SkeletalMesh being used by this SkeletalMeshComponent.
		/// @param BoneName Name of bone to look up
		/// @return Index of the named bone in the current SkeletalMesh. Will return INDEX_NONE if bone not found.
		/// @see USkeletalMesh::GetBoneIndex.
		/// </summary>
		public extern int GetBoneIndex(FName BoneName);
		/// <summary>Returns the number of bones in the skeleton.</summary>
		public extern int GetNumBones();
		/// <summary>
		/// Set MinLodModel of the mesh component
		/// @param       InNewForcedLOD  Set new ForcedLODModel that forces to set the incoming LOD. Range from [1, Max Number of LOD]. This will affect in the next tick update.
		/// </summary>
		public extern void SetForcedLOD(int InNewForcedLOD);
		/// <summary>
		/// Set MinLodModel of the mesh component
		/// @param       InNewMinLOD     Set new MinLodModel that make sure the LOD does not go below of this value. Range from [0, Max Number of LOD - 1]. This will affect in the next tick update.
		/// </summary>
		public extern void SetMinLOD(int InNewMinLOD);
		/// <summary>
		/// Override the Physics Asset of the mesh. It uses SkeletalMesh.PhysicsAsset, but if you'd like to override use this function
		/// @param       NewPhysicsAsset New PhysicsAsset
		/// @param       bForceReInit    Force reinitialize
		/// </summary>
		public extern virtual void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset,bool bForceReInit=false);
		/// <summary>The skeletal mesh used by this component.</summary>
		public USkeletalMesh SkeletalMesh;
		
		/// <summary>
		/// When true, we will just using the bounds from our MasterPoseComponent.  This is useful for when we have a Mesh Parented
		/// to the main SkelMesh (e.g. outline mesh or a full body overdraw effect that is toggled) that is always going to be the same
		/// bounds as parent.  We want to do no calculations in that case.
		/// </summary>
		public bool bUseBoundsFromMasterPoseComponent;
		
		/// <summary>Index of the chunk to preview... If set to -1, all chunks will be rendered</summary>
		public int ChunkIndexPreview;
		
		/// <summary>Index of the section to preview... If set to -1, all section will be rendered</summary>
		public int SectionIndexPreview;
		
		/// <summary>PhysicsAsset is set in SkeletalMesh by default, but you can override with this value</summary>
		public UPhysicsAsset PhysicsAssetOverride;
		
		/// <summary>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).</summary>
		public int ForcedLodModel;
		
		/// <summary>
		/// This is the min LOD that this component will use.  (e.g. if set to 2 then only 2+ LOD Models will be used.) This is useful to set on
		/// meshes which are known to be a certain distance away and still want to have better LODs when zoomed in on them.
		/// </summary>
		public int MinLodModel;
		
		/// <summary>
		/// Allows adjusting the desired streaming distance of streaming textures that uses UV 0.
		/// 1.0 is the default, whereas a higher value makes the textures stream in sooner from far away.
		/// A lower value (0.0-1.0) makes the textures stream in later (you have to be closer).
		/// Value can be < 0 (from legcay content, or code changes)
		/// </summary>
		public float StreamingDistanceMultiplier;
		
		/// <summary>Wireframe color</summary>
		public FColor WireframeColor;
		
		/// <summary>Forces the mesh to draw in wireframe mode.</summary>
		public bool bForceWireframe;
		
		/// <summary>Draw the skeleton hierarchy for this skel mesh.</summary>
		public bool bDisplayBones;
		
		/// <summary>Disable Morphtarget for this component.</summary>
		public bool bDisableMorphTarget;
		
		/// <summary>Don't bother rendering the skin.</summary>
		public bool bHideSkin;
		
		/// <summary>If true, use per-bone motion blur on this skeletal mesh (requires additional rendering, can be disabled to save performance).</summary>
		public bool bPerBoneMotionBlur;
		
		/// <summary>When true, skip using the physics asset etc. and always use the fixed bounds defined in the SkeletalMesh.</summary>
		public bool bComponentUseFixedSkelBounds;
		
		/// <summary>If true, when updating bounds from a PhysicsAsset, consider _all_ BodySetups, not just those flagged with bConsiderForBounds.</summary>
		public bool bConsiderAllBodiesForBounds;
		
		/// <summary>
		/// This is update frequency flag even when our Owner has not been rendered recently
		/// SMU_AlwaysTickPoseAndRefreshBones,                   // Always Tick and Refresh BoneTransforms whether rendered or not
		/// SMU_AlwaysTickPose,                                                  // Always Tick, but Refresh BoneTransforms only when rendered
		/// SMU_OnlyTickPoseWhenRendered,                                // Tick only when rendered, and it will only RefreshBoneTransforms when rendered
		/// </summary>
		public EMeshComponentUpdateFlag MeshComponentUpdateFlag;
		
		/// <summary>If true, UpdateTransform will always result in a call to MeshObject->Update.</summary>
		public bool bForceMeshObjectUpdate;
		
		/// <summary>Whether or not we can highlight selected sections - this should really only be done in the editor</summary>
		public bool bCanHighlightSelectedSections;
		
		/// <summary>true if mesh has been recently rendered, false otherwise</summary>
		public bool bRecentlyRendered;
		
		/// <summary>
		/// Editor only. Used for visualizing drawing order in Animset Viewer. If < 1.0,
		/// only the specified fraction of triangles will be rendered
		/// </summary>
		public float ProgressiveDrawingFraction;
		
		/// <summary>
		/// Editor only. Used for manually selecting the alternate indices for
		/// TRISORT_CustomLeftRight sections.
		/// </summary>
		public byte CustomSortAlternateIndexMode;
		
		/// <summary>
		/// Whether to use the capsule representation (when present) from a skeletal mesh's ShadowPhysicsAsset for direct shadowing from lights.
		/// This type of shadowing is approximate but handles extremely wide area shadowing well.  The softness of the shadow depends on the light's LightSourceAngle / SourceRadius.
		/// This flag will force bCastInsetShadow to be enabled.
		/// </summary>
		public bool bCastCapsuleDirectShadow;
		
		/// <summary>Whether to use the capsule representation (when present) from a skeletal mesh's ShadowPhysicsAsset for shadowing indirect lighting (from lightmaps or skylight).</summary>
		public bool bCastCapsuleIndirectShadow;
		
		/// <summary>Controls how dark the capsule indirect shadow can be.</summary>
		public float CapsuleIndirectShadowMinVisibility;
		
		/// <summary>CPU skinning rendering - only for previewing in Persona and conversion tools</summary>
		public bool bCPUSkinning;
		
		/// <summary>LocalBounds cached, so they're computed just once.</summary>
		public FBoxSphereBounds CachedLocalBounds;
		
		/// <summary>true when CachedLocalBounds is up to date.</summary>
		public bool bCachedLocalBoundsUpToDate;
		
		/// <summary>
		/// if TRUE, Owner will determine how often animation will be updated and evaluated. See AnimUpdateRateTick()
		/// This allows to skip frames for performance. (For example based on visibility and size on screen).
		/// </summary>
		public bool bEnableUpdateRateOptimizations;
		
		/// <summary>
		/// Enable on screen debugging of update rate optimization.
		/// Red = Skipping 0 frames, Green = skipping 1 frame, Blue = skipping 2 frames, black = skipping more than 2 frames.
		/// @todo: turn this into a console command.
		/// </summary>
		public bool bDisplayDebugUpdateRateOptimizations;
		
		
	}
	
}
