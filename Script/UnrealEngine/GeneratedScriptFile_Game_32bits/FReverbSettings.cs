#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FReverbSettings
	{
		public bool bApplyReverb
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(4)]
		public ReverbPreset ReverbType;
		[FieldOffset(12)]
		public float Volume;
		[FieldOffset(16)]
		public float FadeTime;
		
	}
	
}
#endif
#endif
