#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FBasedMovementInfo
	{
		[FieldOffset(8)]
		public FName BoneName;
		[FieldOffset(16)]
		public FVector_NetQuantize100 Location;
		[FieldOffset(28)]
		public FRotator Rotation;
		public bool bServerHasBaseComponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		public bool bRelativeRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 41, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 41, 1, 0, 1, 255); } }}
			
		}
		public bool bServerHasVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 42, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 42, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
