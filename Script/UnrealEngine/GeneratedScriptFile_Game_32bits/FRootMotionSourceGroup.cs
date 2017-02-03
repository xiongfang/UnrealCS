#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FRootMotionSourceGroup
	{
		public bool bHasAdditiveSources
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 1, 255); } }}
			
		}
		public bool bHasOverrideSources
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 125, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 125, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(128)]
		public FVector_NetQuantize10 LastPreAdditiveVelocity;
		public bool bIsAdditiveVelocityApplied
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 140, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 140, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(141)]
		public FRootMotionSourceSettings LastAccumulatedSettings;
		
	}
	
}
#endif
#endif
