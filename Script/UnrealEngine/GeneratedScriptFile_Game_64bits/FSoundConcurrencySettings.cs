#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FSoundConcurrencySettings
	{
		[FieldOffset(0)]
		public int MaxCount;
		public bool bLimitToOwner
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(8)]
		public EMaxConcurrentResolutionRule ResolutionRule;
		[FieldOffset(12)]
		public float VolumeScale;
		
	}
	
}
#endif
#endif
