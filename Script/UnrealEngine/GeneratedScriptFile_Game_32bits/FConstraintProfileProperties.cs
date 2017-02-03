#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=260)]
	public partial struct FConstraintProfileProperties
	{
		[FieldOffset(0)]
		public float ProjectionLinearTolerance;
		[FieldOffset(4)]
		public float ProjectionAngularTolerance;
		[FieldOffset(8)]
		public float LinearBreakThreshold;
		[FieldOffset(12)]
		public float AngularBreakThreshold;
		[FieldOffset(16)]
		public FLinearConstraint LinearLimit;
		[FieldOffset(44)]
		public FConeConstraint ConeLimit;
		[FieldOffset(76)]
		public FTwistConstraint TwistLimit;
		[FieldOffset(104)]
		public FLinearDriveConstraint LinearDrive;
		[FieldOffset(180)]
		public FAngularDriveConstraint AngularDrive;
		public bool bDisableCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 1, 1); } }}
			
		}
		public bool bEnableProjection
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 2, 2); } }}
			
		}
		public bool bAngularBreakable
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 4, 4); } }}
			
		}
		public bool bLinearBreakable
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 8, 8); } }}
			
		}
		
	}
	
}
#endif
#endif
