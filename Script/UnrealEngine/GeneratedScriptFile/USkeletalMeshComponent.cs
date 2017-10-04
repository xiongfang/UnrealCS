using System;
namespace UnrealEngine
{
	public partial class USkeletalMeshComponent:USkinnedMeshComponent
	{
		/// <summary>
		/// Gets the current Angular state for a named bone constraint
		/// @param InBoneName  Name of bone to get constraint ranges for
		/// @param Swing1Angle current angular state of the constraint
		/// @param TwistAngle  current angular state of the constraint
		/// @param Swing2Angle current angular state of the constraint
		/// </summary>
		public extern void GetCurrentJointAngles(FName InBoneName,out float Swing1Angle,out float TwistAngle,out float Swing2Angle);
		/// <summary>
		/// Sets the Angular Motion Ranges for a named bone
		/// @param InBoneName  Name of bone to adjust constraint ranges for
		/// @param Swing1LimitAngle       Size of limit in degrees, 0 means locked, 180 means free
		/// @param TwistLimitAngle        Size of limit in degrees, 0 means locked, 180 means free
		/// @param Swing2LimitAngle       Size of limit in degrees, 0 means locked, 180 means free
		/// </summary>
		public extern void SetAngularLimits(FName InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle);
		/// <summary>
		/// Break a constraint off a Gore mesh.
		/// @param       Impulse vector of impulse
		/// @param       HitLocation     location of the hit
		/// @param       InBoneName      Name of bone to break constraint for
		/// </summary>
		public extern void BreakConstraint(FVector Impulse,FVector HitLocation,FName InBoneName);
		/// <summary>
		/// Find Constraint Name from index
		/// @param       ConstraintIndex Index of constraint to look for
		/// @return      Constraint Joint Name
		/// </summary>
		public extern FName FindConstraintBoneName(int ConstraintIndex);
		/// <summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset for all constraints. If profile name is not found the joint is set to use the default constraint profile.</summary>
		public extern void SetConstraintProfileForAll(FName ProfileName,bool bDefaultIfNotFound=false);
		/// <summary>Sets the constraint profile properties (limits, motors, etc...) to match the constraint profile as defined in the physics asset. If profile name is not found the joint is set to use the default constraint profile.</summary>
		public extern void SetConstraintProfile(FName JointName,FName ProfileName,bool bDefaultIfNotFound=false);
		/// <summary>Set Angular Drive motors params for all constraint instances</summary>
		public extern void SetAllMotorsAngularDriveParams(float InSpring,float InDamping,float InForceLimit,bool bSkipCustomPhysicsType=false);
		/// <summary>Enable or Disable AngularVelocityDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
		public extern void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false);
		/// <summary>Enable or Disable AngularPositionDrive. If motor is in SLERP mode it will be turned on if either EnableSwingDrive OR EnableTwistDrive are enabled. In Twist and Swing mode the twist and the swing can be controlled individually.</summary>
		public extern void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false);
		/// <summary>Accumulate AddPhysicsBlendWeight to physics blendweight for all of the bones below passed in bone to be simulated</summary>
		public extern void AccumulateAllBodiesBelowPhysicsBlendWeight(FName InBoneName,float AddPhysicsBlendWeight,bool bSkipCustomPhysicsType=false);
		/// <summary>Set all of the bones below passed in bone to be simulated</summary>
		public extern void SetAllBodiesBelowPhysicsBlendWeight(FName InBoneName,float PhysicsBlendWeight,bool bSkipCustomPhysicsType=false,bool bIncludeSelf=true);
		public extern void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight,bool bSkipCustomPhysicsType=false);
		/// <summary>Allows you to reset bodies Simulate state based on where bUsePhysics is set to true in the BodySetup.</summary>
		public extern void ResetAllBodiesSimulatePhysics();
		/// <summary>Set all of the bones below passed in bone to be simulated</summary>
		public extern void SetAllBodiesBelowSimulatePhysics(FName InBoneName,bool bNewSimulate,bool bIncludeSelf=true);
		/// <summary>Disable physics blending of bones *</summary>
		public extern void SetEnablePhysicsBlending(bool bNewBlendPhysics);
		/// <summary>
		/// This is global set up for setting physics blend weight
		/// This does multiple things automatically
		/// If PhysicsBlendWeight == 1.f, it will enable Simulation, and if PhysicsBlendWeight == 0.f, it will disable Simulation.
		/// Also it will respect each body's setup, so if the body is fixed, it won't simulate. Vice versa
		/// So if you'd like all bodies to change manually, do not use this function, but SetAllBodiesPhysicsBlendWeight
		/// </summary>
		public extern void SetPhysicsBlendWeight(float PhysicsBlendWeight);
		/// <summary>Set bSimulatePhysics to true for all bone bodies. Does not change the component bSimulatePhysics flag.</summary>
		public extern void SetAllBodiesSimulatePhysics(bool bNewSimulate);
		/// <summary>
		/// Add impulse to all single rigid bodies below. Good for one time instant burst.
		/// @param  Impulse         Magnitude and direction of impulse to apply.
		/// @param  BoneName        If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.
		/// @param  bVelChange      If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no affect).
		/// @param bIncludeSelf If false, Force is only applied to bodies below but not given bone name.
		/// </summary>
		public extern virtual void AddImpulseToAllBodiesBelow(FVector Impulse,FName BoneName,bool bVelChange=false,bool bIncludeSelf=true);
		/// <summary>
		/// Add a force to all rigid bodies below.
		/// This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force.
		/// @param  Force            Force vector to apply. Magnitude indicates strength of force.
		/// @param  BoneName         If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.
		/// @param  bAccelChange If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no affect).
		/// @param  bIncludeSelf If false, Force is only applied to bodies below but not given bone name.
		/// </summary>
		public extern virtual void AddForceToAllBodiesBelow(FVector Force,FName BoneName,bool bAccelChange=false,bool bIncludeSelf=true);
		/// <summary>Returns the center of mass of the skeletal mesh, instead of the root body's location</summary>
		public extern FVector GetSkeletalCenterOfMass();
		/// <summary>
		/// Returns the mass (in kg) of the given bone
		/// @param BoneName         Name of the body to return. 'None' indicates root body.
		/// @param bScaleMass       If true, the mass is scaled by the bone's MassScale.
		/// </summary>
		public extern float GetBoneMass(FName BoneName,bool bScaleMass=true);
		/// <summary>
		/// Given a world position, find the closest point on the physics asset. Note that this is independent of collision and welding. This is based purely on animation position
		/// @param      WorldPosition                           The point we want the closest point to (i.e. for all bodies in the physics asset, find the one that has a point closest to WorldPosition)
		/// @param      ClosestPointOnPhysicsAsset      The data associated with the closest point (position, normal, etc...)
		/// @return     true if we found a closest point
		/// </summary>
		public extern bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition,out FVector ClosestWorldPosition,out FVector Normal,out FName BoneName,out float Distance);
		/// <summary>
		/// Enables or disables gravity to all bodies below the given bone.
		/// NAME_None indicates all bodies will be edited.
		/// In that case, consider using UPrimitiveComponent::EnableGravity.
		/// @param bEnableGravity   Whether gravity should be enabled or disabled.
		/// @param BoneName                 The name of the top most bone.
		/// @param bIncludeSelf             Whether the bone specified should be edited.
		/// </summary>
		public extern void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity,FName BoneName,bool bIncludeSelf=true);
		/// <summary>
		/// Checks whether or not gravity is enabled on the given bone.
		/// NAME_None indicates the root body should be queried.
		/// If the bone name given is otherwise invalid, false is returned.
		/// @param BoneName The name of the bone to check.
		/// @return True if gravity is enabled on the bone.
		/// </summary>
		public extern bool IsBodyGravityEnabled(FName BoneName);
		/// <summary>
		/// Enables or disables gravity for the given bone.
		/// NAME_None indicates the root body will be edited.
		/// If the bone name given is otherwise invalid, nothing happens.
		/// @param bEnableGravity   Whether gravity should be enabled or disabled.
		/// @param BoneName                 The name of the bone to modify.
		/// </summary>
		public extern void SetEnableBodyGravity(bool bEnableGravity,FName BoneName);
		/// <summary>
		/// Changes the value of bNotifyRigidBodyCollision on all bodies below a given bone
		/// @param bNewNotifyRigidBodyCollision   The value to assign to bNotifyRigidBodyCollision
		/// @param BoneName                                               Name of the body to turn hit notifies on (and below)
		/// @param bIncludeSelf                                   Whether to modify the given body (useful for roots with multiple children)
		/// </summary>
		public extern virtual void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision,FName BoneName,bool bIncludeSelf=true);
		/// <summary>
		/// Changes the value of bNotifyRigidBodyCollision for a given body
		/// @param bNewNotifyRigidBodyCollision   The value to assign to bNotifyRigidBodyCollision
		/// @param BoneName                                               Name of the body to turn hit notifies on/off. None implies root body
		/// </summary>
		public extern virtual void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision,FName BoneName);
		/// <summary>
		/// Sets whether or not to force tick component in order to update animation and refresh transform for this component
		/// This is supported only in the editor
		/// </summary>
		public extern void SetUpdateAnimationInEditor(bool NewUpdateState);
		/// <summary>
		/// If this component has a valid MasterPoseComponent and has previously had its cloth bound to the
		/// MCP, this function will unbind the cloth and resume simulation.
		/// @param bRestoreSimulationSpace if true and the master pose cloth was originally simulating in world
		/// space, we will restore this setting. This will cause the master component to reset which may be
		/// undesirable.
		/// </summary>
		public extern void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace=true);
		/// <summary>
		/// If this component has a valid MasterPoseComponent then this function makes cloth items on the slave component
		/// take the transforms of the cloth items on the master component instead of simulating separately.
		/// @Note This will FORCE any cloth actor on the master component to simulate in local space. Also
		/// The meshes used in the components must be identical for the cloth to bind correctly
		/// </summary>
		public extern void BindClothToMasterPoseComponent();
		/// <summary>Reset the teleport mode of a next update to 'Continuous'</summary>
		public extern void ResetClothTeleportMode();
		/// <summary>Gets whether or not the clothing simulation is currently suspended</summary>
		public extern bool IsClothingSimulationSuspended();
		/// <summary>Resumes a previously suspended clothing simulation, teleporting the clothing on the next tick</summary>
		public extern void ResumeClothingSimulation();
		/// <summary>Stops simulating clothing, but does not show clothing ref pose. Keeps the last known simulation state</summary>
		public extern void SuspendClothingSimulation();
		/// <summary>
		/// Used to indicate we should force 'teleport and reset' during the next call to UpdateClothState.
		/// This can be used to reset it from a bad state or by a teleport where the old state is not important anymore.
		/// </summary>
		public extern void ForceClothNextUpdateTeleportAndReset();
		/// <summary>
		/// Used to indicate we should force 'teleport' during the next call to UpdateClothState,
		/// This will transform positions and velocities and thus keep the simulation state, just translate it to a new pose.
		/// </summary>
		public extern void ForceClothNextUpdateTeleport();
		public extern void SetClothMaxDistanceScale(float Scale);
		/// <summary>Get/Set the max distance scale of clothing mesh vertices</summary>
		public extern float GetClothMaxDistanceScale();
		/// <summary>
		/// Takes a snapshot of this skeletal mesh component's pose and saves it to the specified snapshot.
		/// The snapshot is taken at the current LOD, so if for example you took the snapshot at LOD1
		/// and then used it at LOD0 any bones not in LOD1 will use the reference pose
		/// </summary>
		public extern void SnapshotPose(out FPoseSnapshot Snapshot);
		/// <summary>Get Morph target with given name</summary>
		public extern float GetMorphTarget(FName MorphTargetName);
		/// <summary>Clear all Morph Target that are set to this mesh</summary>
		public extern void ClearMorphTargets();
		/// <summary>
		/// Set Morph Target with Name and Value(0-1)
		/// @param bRemoveZeroWeight : Used by editor code when it should stay in the active list with zero weight
		/// </summary>
		public extern void SetMorphTarget(FName MorphTargetName,float Value,bool bRemoveZeroWeight=true);
		/// <summary>
		/// This overrides current AnimationData parameter in the SkeletalMeshComponent. This will serialize when the component serialize
		/// so it can be used during construction script. However note that this will override current existing data
		/// This can be useful if you'd like to make a blueprint with custom default animation per component
		/// This sets single player mode, which means you can't use AnimBlueprint with it
		/// </summary>
		public extern void OverrideAnimationData(UAnimationAsset InAnimToPlay,bool bIsLooping=true,bool bIsPlaying=true,float Position=0.000000f,float PlayRate=1.000000f);
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern float GetPlayRate();
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern void SetPlayRate(float Rate);
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern float GetPosition();
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern void SetPosition(float InPos,bool bFireNotifies=true);
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern bool IsPlaying();
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern void Stop();
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern void Play(bool bLooping);
		/// <summary>
		/// Animation play functions
		///       *
		///       * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///       * Becuase of that reason, it is not safe to be used during construction script
		///       * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern void SetAnimation(UAnimationAsset NewAnimToPlay);
		/// <summary>
		/// Animation play functions
		///        *
		///        * These changes status of animation instance, which is transient data, which means it won't serialize with this compoennt
		///        * Becuase of that reason, it is not safe to be used during construction script
		///        * Please use OverrideAnimationDatat for construction script. That will override AnimationData to be serialized
		/// </summary>
		public extern void PlayAnimation(UAnimationAsset NewAnimToPlay,bool bLooping);
		public extern EAnimationMode GetAnimationMode();
		/// <summary>Below are the interface to control animation when animation mode, not blueprint mode *</summary>
		public extern void SetAnimationMode(EAnimationMode InAnimationMode);
		/// <summary>
		/// Returns the active post process instance is one is available. This is set on the mesh that this
		/// component is using, and is evaluated immediately after the main instance.
		/// </summary>
		public extern UAnimInstance GetPostProcessInstance();
		/// <summary>
		/// Returns the animation instance that is driving the class (if available). This is typically an instance of
		/// the class set as AnimBlueprintGeneratedClass (generated by an animation blueprint)
		/// Since this instance is transient, it is not safe to be used during construction script
		/// </summary>
		public extern UAnimInstance GetAnimInstance();
		public extern void SetAnimInstanceClass(UClass NewClass);
		/// <summary>Whether to use Animation Blueprint or play Single Animation Asset.</summary>
		public EAnimationMode AnimationMode;
		
		/// <summary>The blueprint for creating an AnimationScript.</summary>
		public UAnimBlueprint AnimationBlueprint;
		
		public UClass AnimBlueprintGeneratedClass;
		
		/// <summary>The AnimBlueprint class to use. Use 'SetAnimInstanceClass' to change at runtime.</summary>
		public TSubclassOf<UAnimInstance>  AnimClass;
		
		/// <summary>The active animation graph program instance.</summary>
		public UAnimInstance AnimScriptInstance;
		
		/// <summary>
		/// An instance created from the PostPhysicsBlueprint property of the skeletal mesh we're using,
		/// Runs after physics has been blended
		/// </summary>
		public UAnimInstance PostProcessAnimInstance;
		
		public FSingleAnimationPlayData AnimationData;
		
		/// <summary>Used to scale speed of all animations on this skeletal mesh.</summary>
		public float GlobalAnimRateScale;
		
		/// <summary>If true, there is at least one body in the current PhysicsAsset with a valid bone in the current SkeletalMesh</summary>
		public bool bHasValidBodies;
		
		/// <summary>If we are running physics, should we update non-simulated bones based on the animation bone positions.</summary>
		public EKinematicBonesUpdateToPhysics KinematicBonesUpdateType;
		
		/// <summary>Whether physics simulation updates component transform.</summary>
		public EPhysicsTransformUpdateMode PhysicsTransformUpdateMode;
		
		/// <summary>Enables blending in of physics bodies whether Simulate or not</summary>
		public bool bBlendPhysics;
		
		/// <summary>
		/// If true, simulate physics for this component on a dedicated server.
		/// This should be set if simulating physics and replicating with a dedicated server.
		///     Note: This property cannot be changed at runtime.
		/// </summary>
		public bool bEnablePhysicsOnDedicatedServer;
		
		/// <summary>
		/// If we should pass joint position to joints each frame, so that they can be used by motorized joints to drive the
		/// ragdoll based on the animation.
		/// </summary>
		public bool bUpdateJointsFromAnimation;
		
		/// <summary>Disable cloth simulation and play original animation without simulation</summary>
		public bool bDisableClothSimulation;
		
		/// <summary>can't collide with part of environment if total collision volumes exceed 16 capsules or 32 planes per convex</summary>
		public bool bCollideWithEnvironment;
		
		/// <summary>can't collide with part of attached children if total collision volumes exceed 16 capsules or 32 planes per convex</summary>
		public bool bCollideWithAttachedChildren;
		
		/// <summary>
		/// It's worth trying this option when you feel that the current cloth simulation is unstable.
		/// The scale of the actor is maintained during the simulation.
		/// It is possible to add the inertia effects to the simulation, through the inertiaScale parameter of the clothing material.
		/// So with an inertiaScale of 1.0 there should be no visible difference between local space and global space simulation.
		/// Known issues: - Currently there's simulation issues when this feature is used in 3.x (DE4076) So if localSpaceSim is enabled there's no inertia effect when the global pose of the clothing actor changes.
		/// </summary>
		public bool bLocalSpaceSimulation;
		
		/// <summary>
		/// cloth morph target option
		/// This option will be applied only before playing because should do pre-calculation to reduce computation time for run-time play
		/// so it's impossible to change this option in run-time
		/// </summary>
		public bool bClothMorphTarget;
		
		/// <summary>reset the clothing after moving the clothing position (called teleport)</summary>
		public bool bResetAfterTeleport;
		
		/// <summary>
		/// conduct teleportation if the character's movement is greater than this threshold in 1 frame.
		/// Zero or negative values will skip the check
		/// you can also do force teleport manually using ForceNextUpdateTeleport() / ForceNextUpdateTeleportAndReset()
		/// </summary>
		public float TeleportDistanceThreshold;
		
		/// <summary>
		/// rotation threshold in degree, ranging from 0 to 180
		/// conduct teleportation if the character's rotation is greater than this threshold in 1 frame.
		/// Zero or negative values will skip the check
		/// </summary>
		public float TeleportRotationThreshold;
		
		/// <summary>
		/// weight to blend between simulated results and key-framed positions
		/// if weight is 1.0, shows only cloth simulation results and 0.0 will show only skinned results
		/// </summary>
		public float ClothBlendWeight;
		
		/// <summary>Offset of the root bone from the reference pose. Used to offset bounding box.</summary>
		public FVector RootBoneTranslation;
		
		/// <summary>Skips Ticking and Bone Refresh.</summary>
		public bool bNoSkeletonUpdate;
		
		/// <summary>pauses this component's animations (doesn't tick them, but still refreshes bones)</summary>
		public bool bPauseAnims;
		
		/// <summary>On InitAnim should we set to ref pose (if false use first tick of animation data)</summary>
		public bool bUseRefPoseOnInitAnim;
		
		/// <summary>Uses skinned data for collision data.</summary>
		public bool bEnablePerPolyCollision;
		
		/// <summary>
		/// Used for per poly collision. In 99% of cases you will be better off using a Physics Asset.
		/// This BodySetup is per instance because all modification of vertices is done in place
		/// </summary>
		public UBodySetup BodySetup;
		
		/// <summary>
		/// If true TickPose() will not be called from the Component's TickComponent function.
		/// It will instead be called from Autonomous networking updates. See ACharacter.
		/// </summary>
		public bool bOnlyAllowAutonomousTickPose;
		
		/// <summary>True if calling TickPose() from Autonomous networking updates. See ACharacter.</summary>
		public bool bIsAutonomousTickPose;
		
		/// <summary>If true, force the mesh into the reference pose - is an optimization.</summary>
		public bool bForceRefpose;
		
		/// <summary>If bForceRefPose was set last tick.</summary>
		public bool bOldForceRefPose;
		
		/// <summary>Bool that enables debug drawing of the skeleton before it is passed to the physics. Useful for debugging animation-driven physics.</summary>
		public bool bShowPrePhysBones;
		
		/// <summary>If false, indicates that on the next call to UpdateSkelPose the RequiredBones array should be recalculated.</summary>
		public bool bRequiredBonesUpToDate;
		
		/// <summary>If true, AnimTree has been initialised.</summary>
		public bool bAnimTreeInitialised;
		
		/// <summary>
		/// If true, the Location of this Component will be included into its bounds calculation
		/// (this can be useful when using SMU_OnlyTickPoseWhenRendered on a character that moves away from the root and no bones are left near the origin of the component)
		/// </summary>
		public bool bIncludeComponentLocationIntoBounds;
		
		/// <summary>If true, line checks will test against the bounding box of this skeletal mesh component and return a hit if there is a collision.</summary>
		public bool bEnableLineCheckWithBounds;
		
		/// <summary>If true, this will Tick until disabled</summary>
		public bool bUpdateAnimationInEditor;
		
		/// <summary>Cache AnimCurveUidVersion from Skeleton and this will be used to identify if it needs to be updated</summary>
		public ushort CachedAnimCurveUidVersion;
		
		/// <summary>If bEnableLineCheckWithBounds is true, scale the bounds by this value before doing line check.</summary>
		public FVector LineCheckBoundsScale;
		
		/// <summary>
		/// these are deprecated variables from removing SingleAnimSkeletalComponent
		/// remove if this version goes away : VER_UE4_REMOVE_SINGLENODEINSTANCE
		/// deprecated variable to be re-save
		/// </summary>
		public UAnimSequence SequenceToPlay;
		
		/// <summary>The default sequence to play on this skeletal mesh</summary>
		public UAnimationAsset AnimToPlay;
		
		/// <summary>Default setting for looping for SequenceToPlay. This is not current state of looping.</summary>
		public bool bDefaultLooping;
		
		/// <summary>Default setting for playing for SequenceToPlay. This is not current state of playing.</summary>
		public bool bDefaultPlaying;
		
		/// <summary>Default setting for position of SequenceToPlay to play.</summary>
		public float DefaultPosition;
		
		/// <summary>Default setting for playrate of SequenceToPlay to play.</summary>
		public float DefaultPlayRate;
		
		/// <summary>Keep track of when animation has been ticked to ensure it is ticked only once per frame.</summary>
		public float LastPoseTickTime;
		
		
	}
	
}
