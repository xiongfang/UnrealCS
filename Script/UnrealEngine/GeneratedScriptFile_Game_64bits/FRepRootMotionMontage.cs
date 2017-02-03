#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=352)]
	public partial struct FRepRootMotionMontage
	{
		public bool bIsActive
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(16)]
		public float Position;
		[FieldOffset(20)]
		public FVector_NetQuantize100 Location;
		[FieldOffset(32)]
		public FRotator Rotation;
		[FieldOffset(56)]
		public FName MovementBaseBoneName;
		public bool bRelativePosition
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 64, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 64, 1, 0, 1, 255); } }}
			
		}
		public bool bRelativeRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 65, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 65, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(72)]
		public FRootMotionSourceGroup AuthoritativeRootMotion;
		[FieldOffset(328)]
		public FVector_NetQuantize10 Acceleration;
		[FieldOffset(340)]
		public FVector_NetQuantize10 LinearVelocity;
		
	}
	
}
#endif
#endif
