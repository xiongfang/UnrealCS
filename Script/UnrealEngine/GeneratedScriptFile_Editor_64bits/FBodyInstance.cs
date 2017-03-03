#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Container for a physics representation of an object</summary>
	[StructLayout(LayoutKind.Explicit,Size=544)]
	public partial struct FBodyInstance
	{
		/// <summary>
		/// @todo : make this to be transient, so that it doesn't have to save anymore
		/// we have to still load them until resave
		/// </summary>
		[FieldOffset(20)]
		public FCollisionResponseContainer ResponseToChannels;
		/// <summary>Collision Profile Name *</summary>
		[FieldOffset(52)]
		public FName CollisionProfileName;
		/// <summary>Custom Channels for Responses</summary>
		[FieldOffset(64)]
		public FCollisionResponse CollisionResponses;
		/// <summary>If true Continuous Collision Detection (CCD) will be used for this component</summary>
		public bool bUseCCD
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Should 'Hit' events fire when this object collides during physics simulation.</summary>
		public bool bNotifyRigidBodyCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 2, 2); } }}
			
		}
		/// <summary>
		/// If true, this body will use simulation. If false, will be 'fixed' (ie kinematic) and move where it is told.
		/// For a Skeletal Mesh Component, simulating requires a physics asset setup and assigned on the SkeletalMesh asset.
		/// For a Static Mesh Component, simulating requires simple collision to be setup on the StaticMesh asset.
		/// </summary>
		public bool bSimulatePhysics
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 4, 4); } }}
			
		}
		/// <summary>If true, mass will not be automatically computed and you must set it directly</summary>
		public bool bOverrideMass
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 8, 8); } }}
			
		}
		/// <summary>If object should have the force of gravity applied</summary>
		public bool bEnableGravity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 16, 16); } }}
			
		}
		/// <summary>If true and is attached to a parent, the two bodies will be joined into a single rigid body. Physical settings like collision profile and body settings are determined by the root</summary>
		public bool bAutoWeld
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 32, 32); } }}
			
		}
		/// <summary>If object should start awake, or if it should initially be sleeping</summary>
		public bool bStartAwake
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 128, 128); } }}
			
		}
		/// <summary>Should 'wake/sleep' events fire when this object is woken up or put to sleep by the physics simulation.</summary>
		public bool bGenerateWakeEvents
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 1, 1); } }}
			
		}
		/// <summary>If true, it will update mass when scale changes *</summary>
		public bool bUpdateMassWhenScaleChanges
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 2, 2); } }}
			
		}
		/// <summary>When a Locked Axis Mode is selected, will lock translation on the specified axis</summary>
		public bool bLockTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 4, 4); } }}
			
		}
		/// <summary>When a Locked Axis Mode is selected, will lock rotation to the specified axis</summary>
		public bool bLockRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 8, 8); } }}
			
		}
		/// <summary>Lock translation along the X-axis</summary>
		public bool bLockXTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 16, 16); } }}
			
		}
		/// <summary>Lock translation along the Y-axis</summary>
		public bool bLockYTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 32, 32); } }}
			
		}
		/// <summary>Lock translation along the Z-axis</summary>
		public bool bLockZTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 64, 64); } }}
			
		}
		/// <summary>Lock rotation about the X-axis</summary>
		public bool bLockXRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 128, 128); } }}
			
		}
		/// <summary>Lock rotation about the Y-axis</summary>
		public bool bLockYRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Lock rotation about the Z-axis</summary>
		public bool bLockZRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Override the default max angular velocity</summary>
		public bool bOverrideMaxAngularVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 4, 4); } }}
			
		}
		/// <summary>
		/// If true, this body will be put into the asynchronous physics scene. If false, it will be put into the synchronous physics scene.
		/// If the body is static, it will be placed into both scenes regardless of the value of bUseAsyncScene.
		/// </summary>
		public bool bUseAsyncScene
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 16, 16); } }}
			
		}
		/// <summary>Whether this body instance has its own custom MaxDepenetrationVelocity</summary>
		public bool bOverrideMaxDepenetrationVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 32, 32); } }}
			
		}
		/// <summary>Whether this instance of the object has its own custom walkable slope override setting.</summary>
		public bool bOverrideWalkableSlopeOnInstance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 64, 64); } }}
			
		}
		/// <summary>The maximum velocity used to depenetrate this object</summary>
		[FieldOffset(120)]
		public float MaxDepenetrationVelocity;
		/// <summary>
		/// Mass of the body in KG. By default we compute this based on physical material and mass scale.
		/// @see bOverrideMass to set this directly
		/// </summary>
		[FieldOffset(132)]
		public float MassInKgOverride;
		/// <summary>'Drag' force added to reduce linear movement</summary>
		[FieldOffset(136)]
		public float LinearDamping;
		/// <summary>'Drag' force added to reduce angular movement</summary>
		[FieldOffset(140)]
		public float AngularDamping;
		/// <summary>Locks physical movement along a custom plane for a given normal.</summary>
		[FieldOffset(144)]
		public FVector CustomDOFPlaneNormal;
		/// <summary>User specified offset for the center of mass of this object, from the calculated location</summary>
		[FieldOffset(156)]
		public FVector COMNudge;
		/// <summary>Per-instance scaling of mass</summary>
		[FieldOffset(168)]
		public float MassScale;
		/// <summary>
		/// Custom walkable slope override setting for this instance.
		/// @see GetWalkableSlopeOverride(), SetWalkableSlopeOverride()
		/// </summary>
		[FieldOffset(192)]
		public FWalkableSlopeOverride WalkableSlopeOverride;
		/// <summary>Allows you to override the PhysicalMaterial to use for simple collision on this body.</summary>
		/// <summary>The maximum angular velocity for this instance</summary>
		[FieldOffset(216)]
		public float MaxAngularVelocity;
		/// <summary>If the SleepFamily is set to custom, multiply the natural sleep threshold by this amount. A higher number will cause the body to sleep sooner.</summary>
		[FieldOffset(220)]
		public float CustomSleepThresholdMultiplier;
		/// <summary>Provide appropriate interface for doing this instead of allowing BlueprintReadWrite *</summary>
		[FieldOffset(224)]
		public float PhysicsBlendWeight;
		/// <summary>This physics body's solver iteration count for position. Increasing this will be more CPU intensive, but better stabilized.</summary>
		[FieldOffset(228)]
		public int PositionSolverIterationCount;
		/// <summary>Internal use. Physics-engine id of the actor used during serialization. Needs to be outside the ifdef for serialization purposes</summary>
		[FieldOffset(272)]
		public ulong RigidActorSyncId;
		/// <summary>Internal use. Physics-engine id of the actor used during serialization.  Needs to be outside the ifdef for serialization purposes</summary>
		[FieldOffset(280)]
		public ulong RigidActorAsyncId;
		/// <summary>This physics body's solver iteration count for velocity. Increasing this will be more CPU intensive, but better stabilized.</summary>
		[FieldOffset(288)]
		public int VelocitySolverIterationCount;
		/// <summary>Locks physical movement along specified axis.</summary>
		[FieldOffset(541)]
		public EDOFMode DOFMode;
		/// <summary>
		/// Type of collision enabled.
		///      No Collision      : Will not create any representation in the physics engine. Cannot be used for spatial queries (raycasts, sweeps, overlaps) or simulation (rigid body, constraints). Best performance possible (especially for moving objects)
		///      Query Only        : Only used for spatial queries (raycasts, sweeps, and overlaps). Cannot be used for simulation (rigid body, constraints). Useful for character movement and things that do not need physical simulation. Performance gains by keeping data out of simulation tree.
		///      Physics Only      : Only used only for physics simulation (rigid body, constraints). Cannot be used for spatial queries (raycasts, sweeps, overlaps). Useful for jiggly bits on characters that do not need per bone detection. Performance gains by keeping data out of query tree
		///      Collision Enabled : Can be used for both spatial queries (raycasts, sweeps, overlaps) and simulation (rigid body, constraints).
		/// </summary>
		[FieldOffset(542)]
		public ECollisionEnabled CollisionEnabled;
		/// <summary>Enum indicating what type of object this should be considered as when it moves</summary>
		[FieldOffset(543)]
		public ECollisionChannel ObjectType;
		
	}
	
}
#endif
#endif
