using System;
namespace UnrealEngine
{
	/// <summary>Container for a physics representation of an object</summary>
	public partial struct FBodyInstance
	{
		/// <summary>
		/// @todo : make this to be transient, so that it doesn't have to save anymore
		/// we have to still load them until resave
		/// </summary>
		public FCollisionResponseContainer ResponseToChannels;
		/// <summary>Collision Profile Name *</summary>
		public FName CollisionProfileName;
		/// <summary>Custom Channels for Responses</summary>
		public FCollisionResponse CollisionResponses;
		/// <summary>If true Continuous Collision Detection (CCD) will be used for this component</summary>
		public bool bUseCCD;
		/// <summary>Should 'Hit' events fire when this object collides during physics simulation.</summary>
		public bool bNotifyRigidBodyCollision;
		/// <summary>
		/// If true, this body will use simulation. If false, will be 'fixed' (ie kinematic) and move where it is told.
		/// For a Skeletal Mesh Component, simulating requires a physics asset setup and assigned on the SkeletalMesh asset.
		/// For a Static Mesh Component, simulating requires simple collision to be setup on the StaticMesh asset.
		/// </summary>
		public bool bSimulatePhysics;
		/// <summary>If true, mass will not be automatically computed and you must set it directly</summary>
		public bool bOverrideMass;
		/// <summary>If object should have the force of gravity applied</summary>
		public bool bEnableGravity;
		/// <summary>If true and is attached to a parent, the two bodies will be joined into a single rigid body. Physical settings like collision profile and body settings are determined by the root</summary>
		public bool bAutoWeld;
		/// <summary>If object should start awake, or if it should initially be sleeping</summary>
		public bool bStartAwake;
		/// <summary>Should 'wake/sleep' events fire when this object is woken up or put to sleep by the physics simulation.</summary>
		public bool bGenerateWakeEvents;
		/// <summary>If true, it will update mass when scale changes *</summary>
		public bool bUpdateMassWhenScaleChanges;
		/// <summary>When a Locked Axis Mode is selected, will lock translation on the specified axis</summary>
		public bool bLockTranslation;
		/// <summary>When a Locked Axis Mode is selected, will lock rotation to the specified axis</summary>
		public bool bLockRotation;
		/// <summary>Lock translation along the X-axis</summary>
		public bool bLockXTranslation;
		/// <summary>Lock translation along the Y-axis</summary>
		public bool bLockYTranslation;
		/// <summary>Lock translation along the Z-axis</summary>
		public bool bLockZTranslation;
		/// <summary>Lock rotation about the X-axis</summary>
		public bool bLockXRotation;
		/// <summary>Lock rotation about the Y-axis</summary>
		public bool bLockYRotation;
		/// <summary>Lock rotation about the Z-axis</summary>
		public bool bLockZRotation;
		/// <summary>Override the default max angular velocity</summary>
		public bool bOverrideMaxAngularVelocity;
		/// <summary>
		/// If true, this body will be put into the asynchronous physics scene. If false, it will be put into the synchronous physics scene.
		/// If the body is static, it will be placed into both scenes regardless of the value of bUseAsyncScene.
		/// </summary>
		public bool bUseAsyncScene;
		/// <summary>Whether this body instance has its own custom MaxDepenetrationVelocity</summary>
		public bool bOverrideMaxDepenetrationVelocity;
		/// <summary>Whether this instance of the object has its own custom walkable slope override setting.</summary>
		public bool bOverrideWalkableSlopeOnInstance;
		/// <summary>The maximum velocity used to depenetrate this object</summary>
		public float MaxDepenetrationVelocity;
		/// <summary>
		/// Mass of the body in KG. By default we compute this based on physical material and mass scale.
		/// @see bOverrideMass to set this directly
		/// </summary>
		public float MassInKgOverride;
		/// <summary>'Drag' force added to reduce linear movement</summary>
		public float LinearDamping;
		/// <summary>'Drag' force added to reduce angular movement</summary>
		public float AngularDamping;
		/// <summary>Locks physical movement along a custom plane for a given normal.</summary>
		public FVector CustomDOFPlaneNormal;
		/// <summary>User specified offset for the center of mass of this object, from the calculated location</summary>
		public FVector COMNudge;
		/// <summary>Per-instance scaling of mass</summary>
		public float MassScale;
		/// <summary>
		/// Custom walkable slope override setting for this instance.
		/// @see GetWalkableSlopeOverride(), SetWalkableSlopeOverride()
		/// </summary>
		public FWalkableSlopeOverride WalkableSlopeOverride;
		/// <summary>Allows you to override the PhysicalMaterial to use for simple collision on this body.</summary>
		public UPhysicalMaterial PhysMaterialOverride;
		/// <summary>The maximum angular velocity for this instance</summary>
		public float MaxAngularVelocity;
		/// <summary>If the SleepFamily is set to custom, multiply the natural sleep threshold by this amount. A higher number will cause the body to sleep sooner.</summary>
		public float CustomSleepThresholdMultiplier;
		/// <summary>Provide appropriate interface for doing this instead of allowing BlueprintReadWrite *</summary>
		public float PhysicsBlendWeight;
		/// <summary>This physics body's solver iteration count for position. Increasing this will be more CPU intensive, but better stabilized.</summary>
		public int PositionSolverIterationCount;
		/// <summary>Internal use. Physics-engine id of the actor used during serialization. Needs to be outside the ifdef for serialization purposes</summary>
		public ulong RigidActorSyncId;
		/// <summary>Internal use. Physics-engine id of the actor used during serialization.  Needs to be outside the ifdef for serialization purposes</summary>
		public ulong RigidActorAsyncId;
		/// <summary>This physics body's solver iteration count for velocity. Increasing this will be more CPU intensive, but better stabilized.</summary>
		public int VelocitySolverIterationCount;
		/// <summary>Locks physical movement along specified axis.</summary>
		public EDOFMode DOFMode;
		/// <summary>
		/// Type of collision enabled.
		///      No Collision      : Will not create any representation in the physics engine. Cannot be used for spatial queries (raycasts, sweeps, overlaps) or simulation (rigid body, constraints). Best performance possible (especially for moving objects)
		///      Query Only        : Only used for spatial queries (raycasts, sweeps, and overlaps). Cannot be used for simulation (rigid body, constraints). Useful for character movement and things that do not need physical simulation. Performance gains by keeping data out of simulation tree.
		///      Physics Only      : Only used only for physics simulation (rigid body, constraints). Cannot be used for spatial queries (raycasts, sweeps, overlaps). Useful for jiggly bits on characters that do not need per bone detection. Performance gains by keeping data out of query tree
		///      Collision Enabled : Can be used for both spatial queries (raycasts, sweeps, overlaps) and simulation (rigid body, constraints).
		/// </summary>
		public ECollisionEnabled CollisionEnabled;
		/// <summary>Enum indicating what type of object this should be considered as when it moves</summary>
		public ECollisionChannel ObjectType;
		
	}
	
}
