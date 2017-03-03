using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkinnedMeshComponent:UMeshComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsBoneHiddenByName(IntPtr _this,string BoneName);
/// <summary>
/// Determines if the specified bone is hidden.
/// @param  BoneName            Name of bone to check
/// @return true if hidden
/// </summary>
public  bool IsBoneHiddenByName(string BoneName)
{
	CheckIsValid();
	int ___ret = IsBoneHiddenByName(_this.Get(),BoneName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void UnHideBoneByName(IntPtr _this,string BoneName);
/// <summary>
/// UnHide the specified bone with name.  Currently this just enforces a scale of 0 for the hidden bones.
/// Compoared to HideBone By Index - This keeps track of list of bones and update when LOD changes
/// @param  BoneName            Name of bone to unhide
/// </summary>
public  void UnHideBoneByName(string BoneName)
{
	CheckIsValid();
	UnHideBoneByName(_this.Get(),BoneName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void HideBoneByName(IntPtr _this,string BoneName,int PhysBodyOption);
/// <summary>
/// Hides the specified bone with name.  Currently this just enforces a scale of 0 for the hidden bones.
/// Compoared to HideBone By Index - This keeps track of list of bones and update when LOD changes
/// @param  BoneName            Name of bone to hide
/// @param  PhysBodyOption          Option for physics bodies that attach to the bones to be hidden
/// </summary>
public  void HideBoneByName(string BoneName,EPhysBodyOp PhysBodyOption)
{
	CheckIsValid();
	HideBoneByName(_this.Get(),BoneName,(int)PhysBodyOption);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string FindClosestBone_K2(IntPtr _this,ref FVector TestLocation,out FVector BoneLocation,float IgnoreScale,int bRequirePhysicsAsset);
/// <summary>
/// finds the closest bone to the given location
/// @param TestLocation the location to test against
/// @param BoneLocation (optional, out) if specified, set to the world space location of the bone that was found, or (0,0,0) if no bone was found
/// @param IgnoreScale (optional) if specified, only bones with scaling larger than the specified factor are considered
/// @param bRequirePhysicsAsset (optional) if true, only bones with physics will be considered
/// @return the name of the bone that was found, or 'None' if no bone was found
/// </summary>
public  string FindClosestBone_K2(FVector TestLocation,out FVector BoneLocation,float IgnoreScale=0.000000f,bool bRequirePhysicsAsset=false)
{
	CheckIsValid();
	string ___ret = FindClosestBone_K2(_this.Get(),ref TestLocation,out BoneLocation,IgnoreScale,bRequirePhysicsAsset?1:0);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TransformFromBoneSpace(IntPtr _this,string BoneName,ref FVector InPosition,ref FRotator InRotation,out FVector OutPosition,out FRotator OutRotation);
/// <summary>
/// Transform a location/rotation in bone relative space to world space.
/// @param BoneName Name of bone
/// @param InPosition Input position
/// @param InRotation Input rotation
/// @param OutPosition (out) Transformed position
/// @param OutRotation (out) Transformed rotation
/// </summary>
public  void TransformFromBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,out FVector OutPosition,out FRotator OutRotation)
{
	CheckIsValid();
	TransformFromBoneSpace(_this.Get(),BoneName,ref InPosition,ref InRotation,out OutPosition,out OutRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void TransformToBoneSpace(IntPtr _this,string BoneName,ref FVector InPosition,ref FRotator InRotation,out FVector OutPosition,out FRotator OutRotation);
/// <summary>
/// Transform a location/rotation from world space to bone relative space.
/// This is handy if you know the location in world space for a bone attachment, as AttachComponent takes location/rotation in bone-relative space.
/// @param BoneName Name of bone
/// @param InPosition Input position
/// @param InRotation Input rotation
/// @param OutPosition (out) Transformed position
/// @param OutRotation (out) Transformed rotation
/// </summary>
public  void TransformToBoneSpace(string BoneName,FVector InPosition,FRotator InRotation,out FVector OutPosition,out FRotator OutRotation)
{
	CheckIsValid();
	TransformToBoneSpace(_this.Get(),BoneName,ref InPosition,ref InRotation,out OutPosition,out OutRotation);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BoneIsChildOf(IntPtr _this,string BoneName,string ParentBoneName);
/// <summary>
/// Tests if BoneName is child of (or equal to) ParentBoneName.
/// @param BoneName Name of the bone
/// @param ParentBone Name to check
/// @return true if child (strictly, not same). false otherwise
/// Note - will return false if ChildBoneIndex is the same as ParentBoneIndex ie. must be strictly a child.
/// </summary>
public  bool BoneIsChildOf(string BoneName,string ParentBoneName)
{
	CheckIsValid();
	int ___ret = BoneIsChildOf(_this.Get(),BoneName,ParentBoneName);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMasterPoseComponent(IntPtr _this,IntPtr NewMasterBoneComponent);
/// <summary>
/// Set MasterPoseComponent for this component
/// @param NewMasterBoneComponent New MasterPoseComponent
/// </summary>
public  void SetMasterPoseComponent(USkinnedMeshComponent NewMasterBoneComponent)
{
	CheckIsValid();
	SetMasterPoseComponent(_this.Get(),NewMasterBoneComponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearVertexColorOverride(IntPtr _this,int LODIndex);
/// <summary>Clear any applied vertex color override</summary>
public  void ClearVertexColorOverride(int LODIndex)
{
	CheckIsValid();
	ClearVertexColorOverride(_this.Get(),LODIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVertexColorOverride_LinearColor(IntPtr _this,int LODIndex,FLinearColor[] VertexColors);
/// <summary>Allow override of vertex colors on a per-component basis, taking array of Blueprint-friendly LinearColors.</summary>
public  void SetVertexColorOverride_LinearColor(int LODIndex,FLinearColor[] VertexColors)
{
	CheckIsValid();
	SetVertexColorOverride_LinearColor(_this.Get(),LODIndex,VertexColors);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetParentBone(IntPtr _this,string BoneName);
/// <summary>
/// Get Parent Bone of the input bone
/// @param BoneName Name of the bone
/// @return the name of the parent bone for the specified bone. Returns 'None' if the bone does not exist or it is the root bone
/// </summary>
public  string GetParentBone(string BoneName)
{
	CheckIsValid();
	string ___ret = GetParentBone(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSkeletalMesh(IntPtr _this,IntPtr NewMesh,int bReinitPose);
/// <summary>
/// Change the SkeletalMesh that is rendered for this Component. Will re-initialize the animation tree etc.
/// @param NewMesh New mesh to set for this component
/// @param bReinitPose Whether we should keep current pose or reinitialize.
/// </summary>
public  void SetSkeletalMesh(USkeletalMesh NewMesh,bool bReinitPose=true)
{
	CheckIsValid();
	SetSkeletalMesh(_this.Get(),NewMesh,bReinitPose?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetSocketBoneName(IntPtr _this,string InSocketName);
/// <summary>
/// Returns bone name linked to a given named socket on the skeletal mesh component.
/// If you're unsure to deal with sockets or bones names, you can use this function to filter through, and always return the bone name.
/// @param       bone name or socket name
/// @return      bone name
/// </summary>
public  string GetSocketBoneName(string InSocketName)
{
	CheckIsValid();
	string ___ret = GetSocketBoneName(_this.Get(),InSocketName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetBoneName(IntPtr _this,int BoneIndex);
/// <summary>
/// Get Bone Name from index
/// @param BoneIndex Index of the bone
/// @return the name of the bone at the specified index
/// </summary>
public  string GetBoneName(int BoneIndex)
{
	CheckIsValid();
	string ___ret = GetBoneName(_this.Get(),BoneIndex);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetBoneIndex(IntPtr _this,string BoneName);
/// <summary>
/// Find the index of bone by name. Looks in the current SkeletalMesh being used by this SkeletalMeshComponent.
/// @param BoneName Name of bone to look up
/// @return Index of the named bone in the current SkeletalMesh. Will return INDEX_NONE if bone not found.
/// @see USkeletalMesh::GetBoneIndex.
/// </summary>
public  int GetBoneIndex(string BoneName)
{
	CheckIsValid();
	int ___ret = GetBoneIndex(_this.Get(),BoneName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumBones(IntPtr _this);
/// <summary>Returns the number of bones in the skeleton.</summary>
public  int GetNumBones()
{
	CheckIsValid();
	int ___ret = GetNumBones(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetForcedLOD(IntPtr _this,int InNewForcedLOD);
/// <summary>
/// Set MinLodModel of the mesh component
/// @param       InNewForcedLOD  Set new ForcedLODModel that forces to set the incoming LOD. Range from [1, Max Number of LOD]. This will affect in the next tick update.
/// </summary>
public  void SetForcedLOD(int InNewForcedLOD)
{
	CheckIsValid();
	SetForcedLOD(_this.Get(),InNewForcedLOD);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinLOD(IntPtr _this,int InNewMinLOD);
/// <summary>
/// Set MinLodModel of the mesh component
/// @param       InNewMinLOD     Set new MinLodModel that make sure the LOD does not go below of this value. Range from [0, Max Number of LOD - 1]. This will affect in the next tick update.
/// </summary>
public  void SetMinLOD(int InNewMinLOD)
{
	CheckIsValid();
	SetMinLOD(_this.Get(),InNewMinLOD);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPhysicsAsset(IntPtr _this,IntPtr NewPhysicsAsset,int bForceReInit);
/// <summary>
/// Override the Physics Asset of the mesh. It uses SkeletalMesh.PhysicsAsset, but if you'd like to override use this function
/// @param       NewPhysicsAsset New PhysicsAsset
/// @param       bForceReInit    Force reinitialize
/// </summary>
public  void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset,bool bForceReInit=false)
{
	CheckIsValid();
	SetPhysicsAsset(_this.Get(),NewPhysicsAsset,bForceReInit?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
