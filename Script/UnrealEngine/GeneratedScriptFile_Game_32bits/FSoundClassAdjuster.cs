#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FSoundClassAdjuster
	{
		[FieldOffset(4)]
		public float VolumeAdjuster;
		[FieldOffset(8)]
		public float PitchAdjuster;
		public bool bApplyToChildren
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 12, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 12, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(16)]
		public float VoiceCenterChannelVolumeAdjuster;
		
	}
	
}
#endif
#endif
