#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FFontOutlineSettings
	{
		[FieldOffset(0)]
		public int OutlineSize;
		[FieldOffset(8)]
		public FLinearColor OutlineColor;
		public bool bSeparateFillAlpha
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
