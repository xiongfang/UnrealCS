#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=68)]
	public partial struct FSlateFontInfo
	{
		[FieldOffset(8)]
		public FFontOutlineSettings OutlineSettings;
		[FieldOffset(44)]
		public FName TypefaceFontName;
		[FieldOffset(52)]
		public int Size;
		[FieldOffset(56)]
		public FName FontName;
		
	}
	
}
#endif
#endif
