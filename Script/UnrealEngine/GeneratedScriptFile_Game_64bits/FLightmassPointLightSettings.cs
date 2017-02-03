#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FLightmassPointLightSettings
	{
		[FieldOffset(0)]
		public float IndirectLightingSaturation;
		[FieldOffset(4)]
		public float ShadowExponent;
		public bool bUseAreaShadowsForStationaryLight
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
