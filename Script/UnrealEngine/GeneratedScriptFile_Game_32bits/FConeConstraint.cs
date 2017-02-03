#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FConeConstraint
	{
		[FieldOffset(20)]
		public float Swing1LimitDegrees;
		[FieldOffset(24)]
		public float Swing2LimitDegrees;
		[FieldOffset(28)]
		public EAngularConstraintMotion Swing1Motion;
		[FieldOffset(29)]
		public EAngularConstraintMotion Swing2Motion;
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
