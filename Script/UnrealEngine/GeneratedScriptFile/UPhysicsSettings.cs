using System;
namespace UnrealEngine
{
	public partial class UPhysicsSettings:UDeveloperSettings
	{
		/// <summary>Default gravity.</summary>
		public float DefaultGravityZ;
		
		/// <summary>Default terminal velocity for Physics Volumes.</summary>
		public float DefaultTerminalVelocity;
		
		/// <summary>Default fluid friction for Physics Volumes.</summary>
		public float DefaultFluidFriction;
		
		/// <summary>Amount of memory to reserve for PhysX simulate(), this is per pxscene and will be rounded up to the next 16K boundary</summary>
		public int SimulateScratchMemorySize;
		
		/// <summary>Threshold for ragdoll bodies above which they will be added to an aggregate before being added to the scene</summary>
		public int RagdollAggregateThreshold;
		
		/// <summary>Triangles from triangle meshes (BSP) with an area less than or equal to this value will be removed from physics collision data. Set to less than 0 to disable.</summary>
		public float TriangleMeshTriangleMinAreaThreshold;
		
		/// <summary>Enables the use of an async scene</summary>
		public bool bEnableAsyncScene;
		
		/// <summary>Enables shape sharing between sync and async scene for static rigid actors</summary>
		public bool bEnableShapeSharing;
		
		/// <summary>Enables persistent contact manifolds. This will generate fewer contact points, but with more accuracy. Reduces stability of stacking, but can help energy conservation.</summary>
		public bool bEnablePCM;
		
		/// <summary>Whether to warn when physics locks are used incorrectly. Turning this off is not recommended and should only be used by very advanced users.</summary>
		public bool bWarnMissingLocks;
		
		/// <summary>Can 2D physics be used (Box2D)?</summary>
		public bool bEnable2DPhysics;
		
		public ESettingsLockedAxis LockedAxis;
		
		/// <summary>Useful for constraining all objects in the world, for example if you are making a 2D game using 3D environments.</summary>
		public ESettingsDOF DefaultDegreesOfFreedom;
		
		/// <summary>Minimum relative velocity required for an object to bounce. A typical value for simulation stability is about 0.2 * gravity</summary>
		public float BounceThresholdVelocity;
		
		/// <summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
		public EFrictionCombineMode FrictionCombineMode;
		
		/// <summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
		public EFrictionCombineMode RestitutionCombineMode;
		
		/// <summary>Max angular velocity that a simulated object can achieve.</summary>
		public float MaxAngularVelocity;
		
		/// <summary>Max velocity which may be used to depenetrate simulated physics objects. 0 means no maximum.</summary>
		public float MaxDepenetrationVelocity;
		
		/// <summary>Contact offset multiplier. When creating a physics shape we look at its bounding volume and multiply its minimum value by this multiplier. A bigger number will generate contact points earlier which results in higher stability at the cost of performance.</summary>
		public float ContactOffsetMultiplier;
		
		/// <summary>Min Contact offset.</summary>
		public float MinContactOffset;
		
		/// <summary>Max Contact offset.</summary>
		public float MaxContactOffset;
		
		/// <summary>
		/// If true, simulate physics for this component on a dedicated server.
		/// This should be set if simulating physics and replicating with a dedicated server.
		/// </summary>
		public bool bSimulateSkeletalMeshOnDedicatedServer;
		
		/// <summary>Determines the default physics shape complexity.</summary>
		public ECollisionTraceFlag DefaultShapeComplexity;
		
		/// <summary>If true, static meshes will use per poly collision as complex collision by default. If false the default behavior is the same as UseSimpleAsComplex.</summary>
		public bool bDefaultHasComplexCollision;
		
		/// <summary>If true, the internal physx face to UE face mapping will not be generated. This is a memory optimization available if you do not rely on face indices returned by scene queries.</summary>
		public bool bSuppressFaceRemapTable;
		
		/// <summary>If true, store extra information to allow FindCollisionUV to derive UV info from a line trace hit result, using the FindCollisionUV utility</summary>
		public bool bSupportUVFromHitResults;
		
		/// <summary>If true, physx will not update unreal with any bodies that have moved during the simulation. This should only be used if you have no physx simulation or you are manually updating the unreal data via polling physx.</summary>
		public bool bDisableActiveActors;
		
		/// <summary>If true CCD will be ignored. This is an optimization when CCD is never used which removes the need for physx to check it internally.</summary>
		public bool bDisableCCD;
		
		/// <summary>Max Physics Delta Time to be clamped.</summary>
		public float MaxPhysicsDeltaTime;
		
		/// <summary>Whether to substep the physics simulation. This feature is still experimental. Certain functionality might not work correctly</summary>
		public bool bSubstepping;
		
		/// <summary>Whether to substep the async physics simulation. This feature is still experimental. Certain functionality might not work correctly</summary>
		public bool bSubsteppingAsync;
		
		/// <summary>Max delta time (in seconds) for an individual simulation substep.</summary>
		public float MaxSubstepDeltaTime;
		
		/// <summary>Max number of substeps for physics simulation.</summary>
		public int MaxSubsteps;
		
		/// <summary>Physics delta time smoothing factor for sync scene.</summary>
		public float SyncSceneSmoothingFactor;
		
		/// <summary>Physics delta time smoothing factor for async scene.</summary>
		public float AsyncSceneSmoothingFactor;
		
		/// <summary>Physics delta time initial average.</summary>
		public float InitialAverageFrameRate;
		
		
	}
	
}
