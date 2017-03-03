#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=340)]
	public partial struct FBodyInstance
	{
		[FieldOffset(20)]
		public FCollisionResponseContainer ResponseToChannels;
		[FieldOffset(52)]
		public FName CollisionProfileName;
		[FieldOffset(60)]
		public FCollisionResponse CollisionResponses;
		public bool bUseCCD
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 1, 1); } }}
			
		}
		public bool bNotifyRigidBodyCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 2, 2); } }}
			
		}
		public bool bSimulatePhysics
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 4, 4); } }}
			
		}
		public bool bOverrideMass
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 8, 8); } }}
			
		}
		public bool bEnableGravity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 16, 16); } }}
			
		}
		public bool bAutoWeld
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 32, 32); } }}
			
		}
		public bool bStartAwake
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 128, 128); } }}
			
		}
		public bool bGenerateWakeEvents
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 1, 1); } }}
			
		}
		public bool bUpdateMassWhenScaleChanges
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 2, 2); } }}
			
		}
		public bool bLockTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 4, 4); } }}
			
		}
		public bool bLockRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 8, 8); } }}
			
		}
		public bool bLockXTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 16, 16); } }}
			
		}
		public bool bLockYTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 32, 32); } }}
			
		}
		public bool bLockZTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 64, 64); } }}
			
		}
		public bool bLockXRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 109, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 109, 1, 0, 128, 128); } }}
			
		}
		public bool bLockYRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 110, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 110, 1, 0, 1, 1); } }}
			
		}
		public bool bLockZRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 110, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 110, 1, 0, 2, 2); } }}
			
		}
		public bool bOverrideMaxAngularVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 110, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 110, 1, 0, 4, 4); } }}
			
		}
		public bool bUseAsyncScene
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 110, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 110, 1, 0, 16, 16); } }}
			
		}
		public bool bOverrideMaxDepenetrationVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 110, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 110, 1, 0, 32, 32); } }}
			
		}
		public bool bOverrideWalkableSlopeOnInstance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 110, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 110, 1, 0, 64, 64); } }}
			
		}
		[FieldOffset(112)]
		public float MaxDepenetrationVelocity;
		[FieldOffset(124)]
		public float MassInKgOverride;
		[FieldOffset(128)]
		public float LinearDamping;
		[FieldOffset(132)]
		public float AngularDamping;
		[FieldOffset(136)]
		public FVector CustomDOFPlaneNormal;
		[FieldOffset(148)]
		public FVector COMNudge;
		[FieldOffset(160)]
		public float MassScale;
		[FieldOffset(172)]
		public FWalkableSlopeOverride WalkableSlopeOverride;
		[FieldOffset(192)]
		public float MaxAngularVelocity;
		[FieldOffset(196)]
		public float CustomSleepThresholdMultiplier;
		[FieldOffset(200)]
		public float PhysicsBlendWeight;
		[FieldOffset(204)]
		public int PositionSolverIterationCount;
		[FieldOffset(228)]
		public ulong RigidActorSyncId;
		[FieldOffset(236)]
		public ulong RigidActorAsyncId;
		[FieldOffset(244)]
		public int VelocitySolverIterationCount;
		[FieldOffset(337)]
		public EDOFMode DOFMode;
		[FieldOffset(338)]
		public ECollisionEnabled CollisionEnabled;
		[FieldOffset(339)]
		public ECollisionChannel ObjectType;
		
	}
	
}
#endif
#endif
