#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=544)]
	public partial struct FBodyInstance
	{
		[FieldOffset(20)]
		public FCollisionResponseContainer ResponseToChannels;
		[FieldOffset(56)]
		public FName CollisionProfileName;
		[FieldOffset(64)]
		public FCollisionResponse CollisionResponses;
		public bool bUseCCD
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 1); } }}
			
		}
		public bool bNotifyRigidBodyCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 2, 2); } }}
			
		}
		public bool bSimulatePhysics
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 4, 4); } }}
			
		}
		public bool bOverrideMass
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 8, 8); } }}
			
		}
		public bool bEnableGravity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 16, 16); } }}
			
		}
		public bool bAutoWeld
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 32, 32); } }}
			
		}
		public bool bStartAwake
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 128, 128); } }}
			
		}
		public bool bGenerateWakeEvents
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 1, 1); } }}
			
		}
		public bool bUpdateMassWhenScaleChanges
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 2, 2); } }}
			
		}
		public bool bLockTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 4, 4); } }}
			
		}
		public bool bLockRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 8, 8); } }}
			
		}
		public bool bLockXTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 16, 16); } }}
			
		}
		public bool bLockYTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 32, 32); } }}
			
		}
		public bool bLockZTranslation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 64, 64); } }}
			
		}
		public bool bLockXRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 117, 1, 0, 128, 128); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 117, 1, 0, 128, 128); } }}
			
		}
		public bool bLockYRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 1, 1); } }}
			
		}
		public bool bLockZRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 2, 2); } }}
			
		}
		public bool bOverrideMaxAngularVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 4, 4); } }}
			
		}
		public bool bUseAsyncScene
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 16, 16); } }}
			
		}
		public bool bOverrideMaxDepenetrationVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 32, 32); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 32, 32); } }}
			
		}
		public bool bOverrideWalkableSlopeOnInstance
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 118, 1, 0, 64, 64); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 118, 1, 0, 64, 64); } }}
			
		}
		[FieldOffset(120)]
		public float MaxDepenetrationVelocity;
		[FieldOffset(132)]
		public float MassInKgOverride;
		[FieldOffset(136)]
		public float LinearDamping;
		[FieldOffset(140)]
		public float AngularDamping;
		[FieldOffset(144)]
		public FVector CustomDOFPlaneNormal;
		[FieldOffset(156)]
		public FVector COMNudge;
		[FieldOffset(168)]
		public float MassScale;
		[FieldOffset(192)]
		public FWalkableSlopeOverride WalkableSlopeOverride;
		[FieldOffset(216)]
		public float MaxAngularVelocity;
		[FieldOffset(220)]
		public float CustomSleepThresholdMultiplier;
		[FieldOffset(224)]
		public float PhysicsBlendWeight;
		[FieldOffset(228)]
		public int PositionSolverIterationCount;
		[FieldOffset(272)]
		public ulong RigidActorSyncId;
		[FieldOffset(280)]
		public ulong RigidActorAsyncId;
		[FieldOffset(288)]
		public int VelocitySolverIterationCount;
		[FieldOffset(541)]
		public EDOFMode DOFMode;
		[FieldOffset(542)]
		public ECollisionEnabled CollisionEnabled;
		[FieldOffset(543)]
		public ECollisionChannel ObjectType;
		
	}
	
}
#endif
#endif
