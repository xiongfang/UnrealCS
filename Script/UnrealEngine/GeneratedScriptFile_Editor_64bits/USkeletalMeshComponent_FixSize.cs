#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// SkeletalMeshComponent is used to create an instance of an animated SkeletalMesh asset.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Content/Types/SkeletalMeshes/
	/// @see USkeletalMesh
	/// </summary>
	public partial class USkeletalMeshComponent
	{
		static readonly int AnimationMode__Offset;
		/// <summary>Whether to use Animation Blueprint or play Single Animation Asset.</summary>
		public EAnimationMode AnimationMode
		{
			get{ CheckIsValid();return (EAnimationMode)Marshal.PtrToStructure(_this.Get()+AnimationMode__Offset, typeof(EAnimationMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimationMode__Offset, false);}
			
		}
		
		static readonly int AnimationBlueprint__Offset;
		/// <summary>The blueprint for creating an AnimationScript.</summary>
		public UAnimBlueprint AnimationBlueprint
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimationBlueprint__Offset); if (v == IntPtr.Zero)return null; UAnimBlueprint retValue = new UAnimBlueprint(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimBlueprintGeneratedClass__Offset;
		public UClass AnimBlueprintGeneratedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimBlueprintGeneratedClass__Offset); return v; }
			
		}
		
		static readonly int AnimClass__Offset;
		/// <summary>The AnimBlueprint class to use. Use 'SetAnimInstanceClass' to change at runtime.</summary>
		public TSubclassOf<UAnimInstance>  AnimClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + AnimClass__Offset, value); }
			
		}
		
		static readonly int AnimScriptInstance__Offset;
		/// <summary>The active animation graph program instance.</summary>
		public UAnimInstance AnimScriptInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimScriptInstance__Offset); if (v == IntPtr.Zero)return null; UAnimInstance retValue = new UAnimInstance(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SubInstances__Offset;
		/// <summary>Any running sub anim instances that need to be updates on the game thread</summary>
		public TObjectArray<UAnimInstance>  SubInstances
		{
					get{ CheckIsValid();return new TObjectArray<UAnimInstance>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubInstances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubInstances__Offset, false);}
			
		}
		
		static readonly int PostProcessAnimInstance__Offset;
		/// <summary>
		/// An instance created from the PostPhysicsBlueprint property of the skeletal mesh we're using,
		/// Runs after physics has been blended
		/// </summary>
		public UAnimInstance PostProcessAnimInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PostProcessAnimInstance__Offset); if (v == IntPtr.Zero)return null; UAnimInstance retValue = new UAnimInstance(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimationData__Offset;
		public FSingleAnimationPlayData AnimationData
		{
			get{ CheckIsValid();return (FSingleAnimationPlayData)Marshal.PtrToStructure(_this.Get()+AnimationData__Offset, typeof(FSingleAnimationPlayData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimationData__Offset, false);}
			
		}
		
		static readonly int CachedBoneSpaceTransforms__Offset;
		/// <summary>Cached BoneSpaceTransforms for Update Rate optimization.</summary>
		public TStructArray<FTransform> CachedBoneSpaceTransforms
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CachedBoneSpaceTransforms__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CachedBoneSpaceTransforms__Offset, false);}
			
		}
		
		static readonly int CachedComponentSpaceTransforms__Offset;
		/// <summary>Cached SpaceBases for Update Rate optimization.</summary>
		public TStructArray<FTransform> CachedComponentSpaceTransforms
		{
			get{ CheckIsValid();return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CachedComponentSpaceTransforms__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CachedComponentSpaceTransforms__Offset, false);}
			
		}
		
		static readonly int GlobalAnimRateScale__Offset;
		/// <summary>Used to scale speed of all animations on this skeletal mesh.</summary>
		public float GlobalAnimRateScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+GlobalAnimRateScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+GlobalAnimRateScale__Offset, false);}
			
		}
		
		static readonly int bHasValidBodies__Offset;
		/// <summary>If true, there is at least one body in the current PhysicsAsset with a valid bone in the current SkeletalMesh</summary>
		public bool bHasValidBodies
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasValidBodies__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int KinematicBonesUpdateType__Offset;
		/// <summary>If we are running physics, should we update non-simulated bones based on the animation bone positions.</summary>
		public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType
		{
			get{ CheckIsValid();return (EKinematicBonesUpdateToPhysics)Marshal.PtrToStructure(_this.Get()+KinematicBonesUpdateType__Offset, typeof(EKinematicBonesUpdateToPhysics));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+KinematicBonesUpdateType__Offset, false);}
			
		}
		
		static readonly int PhysicsTransformUpdateMode__Offset;
		/// <summary>Whether physics simulation updates component transform.</summary>
		public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode
		{
			get{ CheckIsValid();return (EPhysicsTransformUpdateMode)Marshal.PtrToStructure(_this.Get()+PhysicsTransformUpdateMode__Offset, typeof(EPhysicsTransformUpdateMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PhysicsTransformUpdateMode__Offset, false);}
			
		}
		
		static readonly int bBlendPhysics__Offset;
		/// <summary>Enables blending in of physics bodies whether Simulate or not</summary>
		public bool bBlendPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlendPhysics__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bEnablePhysicsOnDedicatedServer__Offset;
		/// <summary>
		/// If true, simulate physics for this component on a dedicated server.
		/// This should be set if simulating physics and replicating with a dedicated server.
		///     Note: This property cannot be changed at runtime.
		/// </summary>
		public bool bEnablePhysicsOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePhysicsOnDedicatedServer__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePhysicsOnDedicatedServer__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUpdateJointsFromAnimation__Offset;
		/// <summary>
		/// If we should pass joint position to joints each frame, so that they can be used by motorized joints to drive the
		/// ragdoll based on the animation.
		/// </summary>
		public bool bUpdateJointsFromAnimation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateJointsFromAnimation__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateJointsFromAnimation__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDisableClothSimulation__Offset;
		/// <summary>Disable cloth simulation and play original animation without simulation</summary>
		public bool bDisableClothSimulation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableClothSimulation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableClothSimulation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCollideWithEnvironment__Offset;
		/// <summary>can't collide with part of environment if total collision volumes exceed 16 capsules or 32 planes per convex</summary>
		public bool bCollideWithEnvironment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideWithEnvironment__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollideWithEnvironment__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bCollideWithAttachedChildren__Offset;
		/// <summary>can't collide with part of attached children if total collision volumes exceed 16 capsules or 32 planes per convex</summary>
		public bool bCollideWithAttachedChildren
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideWithAttachedChildren__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollideWithAttachedChildren__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bLocalSpaceSimulation__Offset;
		/// <summary>
		/// It's worth trying this option when you feel that the current cloth simulation is unstable.
		/// The scale of the actor is maintained during the simulation.
		/// It is possible to add the inertia effects to the simulation, through the inertiaScale parameter of the clothing material.
		/// So with an inertiaScale of 1.0 there should be no visible difference between local space and global space simulation.
		/// Known issues: - Currently there's simulation issues when this feature is used in 3.x (DE4076) So if localSpaceSim is enabled there's no inertia effect when the global pose of the clothing actor changes.
		/// </summary>
		public bool bLocalSpaceSimulation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLocalSpaceSimulation__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLocalSpaceSimulation__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bClothMorphTarget__Offset;
		/// <summary>
		/// cloth morph target option
		/// This option will be applied only before playing because should do pre-calculation to reduce computation time for run-time play
		/// so it's impossible to change this option in run-time
		/// </summary>
		public bool bClothMorphTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClothMorphTarget__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClothMorphTarget__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bResetAfterTeleport__Offset;
		/// <summary>reset the clothing after moving the clothing position (called teleport)</summary>
		public bool bResetAfterTeleport
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bResetAfterTeleport__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bResetAfterTeleport__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TeleportDistanceThreshold__Offset;
		/// <summary>
		/// conduct teleportation if the character's movement is greater than this threshold in 1 frame.
		/// Zero or negative values will skip the check
		/// you can also do force teleport manually using ForceNextUpdateTeleport() / ForceNextUpdateTeleportAndReset()
		/// </summary>
		public float TeleportDistanceThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TeleportDistanceThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TeleportDistanceThreshold__Offset, false);}
			
		}
		
		static readonly int TeleportRotationThreshold__Offset;
		/// <summary>
		/// rotation threshold in degree, ranging from 0 to 180
		/// conduct teleportation if the character's rotation is greater than this threshold in 1 frame.
		/// Zero or negative values will skip the check
		/// </summary>
		public float TeleportRotationThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TeleportRotationThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TeleportRotationThreshold__Offset, false);}
			
		}
		
		static readonly int ClothBlendWeight__Offset;
		/// <summary>
		/// weight to blend between simulated results and key-framed positions
		/// if weight is 1.0, shows only cloth simulation results and 0.0 will show only skinned results
		/// </summary>
		public float ClothBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ClothBlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClothBlendWeight__Offset, false);}
			
		}
		
		static readonly int RootBoneTranslation__Offset;
		/// <summary>Offset of the root bone from the reference pose. Used to offset bounding box.</summary>
		public FVector RootBoneTranslation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+RootBoneTranslation__Offset, typeof(FVector));}
			
		}
		
		static readonly int bNoSkeletonUpdate__Offset;
		/// <summary>Skips Ticking and Bone Refresh.</summary>
		public bool bNoSkeletonUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoSkeletonUpdate__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNoSkeletonUpdate__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bPauseAnims__Offset;
		/// <summary>pauses this component's animations (doesn't tick them, but still refreshes bones)</summary>
		public bool bPauseAnims
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseAnims__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseAnims__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseRefPoseOnInitAnim__Offset;
		/// <summary>On InitAnim should we set to ref pose (if false use first tick of animation data)</summary>
		public bool bUseRefPoseOnInitAnim
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRefPoseOnInitAnim__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRefPoseOnInitAnim__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bEnablePerPolyCollision__Offset;
		/// <summary>Uses skinned data for collision data.</summary>
		public bool bEnablePerPolyCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePerPolyCollision__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePerPolyCollision__Offset, 1,0,1,1);}
			
		}
		
		static readonly int BodySetup__Offset;
		/// <summary>
		/// Used for per poly collision. In 99% of cases you will be better off using a Physics Asset.
		/// This BodySetup is per instance because all modification of vertices is done in place
		/// </summary>
		public UBodySetup BodySetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BodySetup__Offset); if (v == IntPtr.Zero)return null; UBodySetup retValue = new UBodySetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bOnlyAllowAutonomousTickPose__Offset;
		/// <summary>
		/// If true TickPose() will not be called from the Component's TickComponent function.
		/// It will instead be called from Autonomous networking updates. See ACharacter.
		/// </summary>
		public bool bOnlyAllowAutonomousTickPose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyAllowAutonomousTickPose__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsAutonomousTickPose__Offset;
		/// <summary>True if calling TickPose() from Autonomous networking updates. See ACharacter.</summary>
		public bool bIsAutonomousTickPose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsAutonomousTickPose__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bForceRefpose__Offset;
		/// <summary>If true, force the mesh into the reference pose - is an optimization.</summary>
		public bool bForceRefpose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceRefpose__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bOldForceRefPose__Offset;
		/// <summary>If bForceRefPose was set last tick.</summary>
		public bool bOldForceRefPose
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOldForceRefPose__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bShowPrePhysBones__Offset;
		/// <summary>Bool that enables debug drawing of the skeleton before it is passed to the physics. Useful for debugging animation-driven physics.</summary>
		public bool bShowPrePhysBones
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowPrePhysBones__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bRequiredBonesUpToDate__Offset;
		/// <summary>If false, indicates that on the next call to UpdateSkelPose the RequiredBones array should be recalculated.</summary>
		public bool bRequiredBonesUpToDate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequiredBonesUpToDate__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bAnimTreeInitialised__Offset;
		/// <summary>If true, AnimTree has been initialised.</summary>
		public bool bAnimTreeInitialised
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAnimTreeInitialised__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bIncludeComponentLocationIntoBounds__Offset;
		/// <summary>
		/// If true, the Location of this Component will be included into its bounds calculation
		/// (this can be useful when using SMU_OnlyTickPoseWhenRendered on a character that moves away from the root and no bones are left near the origin of the component)
		/// </summary>
		public bool bIncludeComponentLocationIntoBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIncludeComponentLocationIntoBounds__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIncludeComponentLocationIntoBounds__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bEnableLineCheckWithBounds__Offset;
		/// <summary>If true, line checks will test against the bounding box of this skeletal mesh component and return a hit if there is a collision.</summary>
		public bool bEnableLineCheckWithBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableLineCheckWithBounds__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bUpdateAnimationInEditor__Offset;
		/// <summary>If true, this will Tick until disabled</summary>
		public bool bUpdateAnimationInEditor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateAnimationInEditor__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUpdateAnimationInEditor__Offset, 1,0,2,2);}
			
		}
		
		static readonly int CachedAnimCurveUidVersion__Offset;
		/// <summary>Cache AnimCurveUidVersion from Skeleton and this will be used to identify if it needs to be updated</summary>
		public ushort CachedAnimCurveUidVersion
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+CachedAnimCurveUidVersion__Offset, typeof(ushort));}
			
		}
		
		static readonly int LineCheckBoundsScale__Offset;
		/// <summary>If bEnableLineCheckWithBounds is true, scale the bounds by this value before doing line check.</summary>
		public FVector LineCheckBoundsScale
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LineCheckBoundsScale__Offset, typeof(FVector));}
			
		}
		
		static readonly int OnConstraintBroken__Offset;
		/// <summary>Notification when constraint is broken.</summary>
		public FMulticastScriptDelegate OnConstraintBroken
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnConstraintBroken__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnConstraintBroken__Offset, false);}
			
		}
		
		static readonly int SequenceToPlay__Offset;
		/// <summary>
		/// these are deprecated variables from removing SingleAnimSkeletalComponent
		/// remove if this version goes away : VER_UE4_REMOVE_SINGLENODEINSTANCE
		/// deprecated variable to be re-save
		/// </summary>
		public UAnimSequence SequenceToPlay
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SequenceToPlay__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimToPlay__Offset;
		/// <summary>The default sequence to play on this skeletal mesh</summary>
		public UAnimationAsset AnimToPlay
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimToPlay__Offset); if (v == IntPtr.Zero)return null; UAnimationAsset retValue = new UAnimationAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bDefaultLooping__Offset;
		/// <summary>Default setting for looping for SequenceToPlay. This is not current state of looping.</summary>
		public bool bDefaultLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultLooping__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDefaultPlaying__Offset;
		/// <summary>Default setting for playing for SequenceToPlay. This is not current state of playing.</summary>
		public bool bDefaultPlaying
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultPlaying__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DefaultPosition__Offset;
		/// <summary>Default setting for position of SequenceToPlay to play.</summary>
		public float DefaultPosition
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultPosition__Offset, typeof(float));}
			
		}
		
		static readonly int DefaultPlayRate__Offset;
		/// <summary>Default setting for playrate of SequenceToPlay to play.</summary>
		public float DefaultPlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultPlayRate__Offset, typeof(float));}
			
		}
		
		static readonly int LastPoseTickTime__Offset;
		/// <summary>Keep track of when animation has been ticked to ensure it is ticked only once per frame.</summary>
		public float LastPoseTickTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastPoseTickTime__Offset, typeof(float));}
			
		}
		
		static USkeletalMeshComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalMeshComponent");
			AnimationMode__Offset=GetPropertyOffset(NativeClassPtr,"AnimationMode");
			AnimationBlueprint__Offset=GetPropertyOffset(NativeClassPtr,"AnimationBlueprint");
			AnimBlueprintGeneratedClass__Offset=GetPropertyOffset(NativeClassPtr,"AnimBlueprintGeneratedClass");
			AnimClass__Offset=GetPropertyOffset(NativeClassPtr,"AnimClass");
			AnimScriptInstance__Offset=GetPropertyOffset(NativeClassPtr,"AnimScriptInstance");
			SubInstances__Offset=GetPropertyOffset(NativeClassPtr,"SubInstances");
			PostProcessAnimInstance__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessAnimInstance");
			AnimationData__Offset=GetPropertyOffset(NativeClassPtr,"AnimationData");
			CachedBoneSpaceTransforms__Offset=GetPropertyOffset(NativeClassPtr,"CachedBoneSpaceTransforms");
			CachedComponentSpaceTransforms__Offset=GetPropertyOffset(NativeClassPtr,"CachedComponentSpaceTransforms");
			GlobalAnimRateScale__Offset=GetPropertyOffset(NativeClassPtr,"GlobalAnimRateScale");
			bHasValidBodies__Offset=GetPropertyOffset(NativeClassPtr,"bHasValidBodies");
			KinematicBonesUpdateType__Offset=GetPropertyOffset(NativeClassPtr,"KinematicBonesUpdateType");
			PhysicsTransformUpdateMode__Offset=GetPropertyOffset(NativeClassPtr,"PhysicsTransformUpdateMode");
			bBlendPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bBlendPhysics");
			bEnablePhysicsOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePhysicsOnDedicatedServer");
			bUpdateJointsFromAnimation__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateJointsFromAnimation");
			bDisableClothSimulation__Offset=GetPropertyOffset(NativeClassPtr,"bDisableClothSimulation");
			bCollideWithEnvironment__Offset=GetPropertyOffset(NativeClassPtr,"bCollideWithEnvironment");
			bCollideWithAttachedChildren__Offset=GetPropertyOffset(NativeClassPtr,"bCollideWithAttachedChildren");
			bLocalSpaceSimulation__Offset=GetPropertyOffset(NativeClassPtr,"bLocalSpaceSimulation");
			bClothMorphTarget__Offset=GetPropertyOffset(NativeClassPtr,"bClothMorphTarget");
			bResetAfterTeleport__Offset=GetPropertyOffset(NativeClassPtr,"bResetAfterTeleport");
			TeleportDistanceThreshold__Offset=GetPropertyOffset(NativeClassPtr,"TeleportDistanceThreshold");
			TeleportRotationThreshold__Offset=GetPropertyOffset(NativeClassPtr,"TeleportRotationThreshold");
			ClothBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"ClothBlendWeight");
			RootBoneTranslation__Offset=GetPropertyOffset(NativeClassPtr,"RootBoneTranslation");
			bNoSkeletonUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bNoSkeletonUpdate");
			bPauseAnims__Offset=GetPropertyOffset(NativeClassPtr,"bPauseAnims");
			bUseRefPoseOnInitAnim__Offset=GetPropertyOffset(NativeClassPtr,"bUseRefPoseOnInitAnim");
			bEnablePerPolyCollision__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePerPolyCollision");
			BodySetup__Offset=GetPropertyOffset(NativeClassPtr,"BodySetup");
			bOnlyAllowAutonomousTickPose__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyAllowAutonomousTickPose");
			bIsAutonomousTickPose__Offset=GetPropertyOffset(NativeClassPtr,"bIsAutonomousTickPose");
			bForceRefpose__Offset=GetPropertyOffset(NativeClassPtr,"bForceRefpose");
			bOldForceRefPose__Offset=GetPropertyOffset(NativeClassPtr,"bOldForceRefPose");
			bShowPrePhysBones__Offset=GetPropertyOffset(NativeClassPtr,"bShowPrePhysBones");
			bRequiredBonesUpToDate__Offset=GetPropertyOffset(NativeClassPtr,"bRequiredBonesUpToDate");
			bAnimTreeInitialised__Offset=GetPropertyOffset(NativeClassPtr,"bAnimTreeInitialised");
			bIncludeComponentLocationIntoBounds__Offset=GetPropertyOffset(NativeClassPtr,"bIncludeComponentLocationIntoBounds");
			bEnableLineCheckWithBounds__Offset=GetPropertyOffset(NativeClassPtr,"bEnableLineCheckWithBounds");
			bUpdateAnimationInEditor__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateAnimationInEditor");
			CachedAnimCurveUidVersion__Offset=GetPropertyOffset(NativeClassPtr,"CachedAnimCurveUidVersion");
			LineCheckBoundsScale__Offset=GetPropertyOffset(NativeClassPtr,"LineCheckBoundsScale");
			OnConstraintBroken__Offset=GetPropertyOffset(NativeClassPtr,"OnConstraintBroken");
			SequenceToPlay__Offset=GetPropertyOffset(NativeClassPtr,"SequenceToPlay");
			AnimToPlay__Offset=GetPropertyOffset(NativeClassPtr,"AnimToPlay");
			bDefaultLooping__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultLooping");
			bDefaultPlaying__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultPlaying");
			DefaultPosition__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPosition");
			DefaultPlayRate__Offset=GetPropertyOffset(NativeClassPtr,"DefaultPlayRate");
			LastPoseTickTime__Offset=GetPropertyOffset(NativeClassPtr,"LastPoseTickTime");
			
		}
		
	}
	
}
#endif
#endif
