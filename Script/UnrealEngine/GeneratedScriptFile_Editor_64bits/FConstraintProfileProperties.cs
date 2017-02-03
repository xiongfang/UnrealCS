#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Container for properties of a physics constraint that can be easily swapped at runtime. This is useful for switching different setups when going from ragdoll to standup for example</summary>
	[StructLayout(LayoutKind.Explicit,Size=260)]
	public partial struct FConstraintProfileProperties
	{
		/// <summary>Linear tolerance value in world units. If the distance error exceeds this tolerence limit, the body will be projected.</summary>
		[FieldOffset(0)]
		public float ProjectionLinearTolerance;
		/// <summary>Angular tolerance value in world units. If the distance error exceeds this tolerence limit, the body will be projected.</summary>
		[FieldOffset(4)]
		public float ProjectionAngularTolerance;
		/// <summary>Force needed to break the distance constraint.</summary>
		[FieldOffset(8)]
		public float LinearBreakThreshold;
		/// <summary>Torque needed to break the joint.</summary>
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
		/// <summary>Disable collision between bodies joined by this constraint.</summary>
		public bool bDisableCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 1, 1); } }}
			
		}
		/// <summary>
		/// If distance error between bodies exceeds 0.1 units, or rotation error exceeds 10 degrees, body will be projected to fix this.
		/// For example a chain spinning too fast will have its elements appear detached due to velocity, this will project all bodies so they still appear attached to each other.
		/// </summary>
		public bool bEnableProjection
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Whether it is possible to break the joint with angular force.</summary>
		public bool bAngularBreakable
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Whether it is possible to break the joint with linear force.</summary>
		public bool bLinearBreakable
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 256, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 256, 1, 0, 8, 8); } }}
			
		}
		
	}
	
}
#endif
#endif
