#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FReverbSettings
	{
		public bool bApplyReverb
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(1)]
		public ReverbPreset ReverbType;
		[FieldOffset(8)]
		public float Volume;
		[FieldOffset(12)]
		public float FadeTime;
		
	}
	
}
#endif
#endif
