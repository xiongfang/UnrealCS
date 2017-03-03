#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FRepMovement
	{
		[FieldOffset(0)]
		public FVector LinearVelocity;
		[FieldOffset(12)]
		public FVector AngularVelocity;
		[FieldOffset(24)]
		public FVector Location;
		[FieldOffset(36)]
		public FRotator Rotation;
		public bool bSimulatedPhysicSleep
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 1); } }}
			
		}
		public bool bRepPhysics
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
