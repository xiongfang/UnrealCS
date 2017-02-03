#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FSoundConcurrencySettings
	{
		[FieldOffset(0)]
		public int MaxCount;
		public bool bLimitToOwner
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(5)]
		public EMaxConcurrentResolutionRule ResolutionRule;
		[FieldOffset(8)]
		public float VolumeScale;
		
	}
	
}
#endif
#endif
