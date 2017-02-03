#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FBasedMovementInfo
	{
		[FieldOffset(4)]
		public FName BoneName;
		[FieldOffset(12)]
		public FVector_NetQuantize100 Location;
		[FieldOffset(24)]
		public FRotator Rotation;
		public bool bServerHasBaseComponent
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 36, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 36, 1, 0, 1, 255); } }}
			
		}
		public bool bRelativeRotation
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 37, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 37, 1, 0, 1, 255); } }}
			
		}
		public bool bServerHasVelocity
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 38, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 38, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
