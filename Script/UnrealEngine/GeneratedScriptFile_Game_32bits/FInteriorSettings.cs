#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FInteriorSettings
	{
		public bool bIsWorldSettings
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(4)]
		public float ExteriorVolume;
		[FieldOffset(8)]
		public float ExteriorTime;
		[FieldOffset(12)]
		public float ExteriorLPF;
		[FieldOffset(16)]
		public float ExteriorLPFTime;
		[FieldOffset(20)]
		public float InteriorVolume;
		[FieldOffset(24)]
		public float InteriorTime;
		[FieldOffset(28)]
		public float InteriorLPF;
		[FieldOffset(32)]
		public float InteriorLPFTime;
		
	}
	
}
#endif
#endif
