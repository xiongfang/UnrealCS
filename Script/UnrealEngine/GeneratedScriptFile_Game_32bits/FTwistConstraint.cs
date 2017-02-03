#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FTwistConstraint
	{
		[FieldOffset(20)]
		public float TwistLimitDegrees;
		[FieldOffset(24)]
		public EAngularConstraintMotion TwistMotion;
		[FieldOffset(0)]
		public float Stiffness;
		[FieldOffset(4)]
		public float Damping;
		[FieldOffset(8)]
		public float Restitution;
		[FieldOffset(12)]
		public float ContactDistance;
		public bool bSoftConstraint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
