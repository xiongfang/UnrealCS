#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=256)]
	public partial struct FRootMotionSourceGroup
	{
		public bool bHasAdditiveSources
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 232, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 232, 1, 0, 1, 255); } }}
			
		}
		public bool bHasOverrideSources
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 233, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 233, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(236)]
		public FVector_NetQuantize10 LastPreAdditiveVelocity;
		public bool bIsAdditiveVelocityApplied
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 248, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 248, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(249)]
		public FRootMotionSourceSettings LastAccumulatedSettings;
		
	}
	
}
#endif
#endif
