#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=220)]
	public partial struct FRepRootMotionMontage
	{
		public bool bIsActive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(8)]
		public float Position;
		[FieldOffset(12)]
		public FVector_NetQuantize100 Location;
		[FieldOffset(24)]
		public FRotator Rotation;
		[FieldOffset(40)]
		public FName MovementBaseBoneName;
		public bool bRelativePosition
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 255); } }}
			
		}
		public bool bRelativeRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 49, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 49, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(52)]
		public FRootMotionSourceGroup AuthoritativeRootMotion;
		[FieldOffset(196)]
		public FVector_NetQuantize10 Acceleration;
		[FieldOffset(208)]
		public FVector_NetQuantize10 LinearVelocity;
		
	}
	
}
#endif
#endif
