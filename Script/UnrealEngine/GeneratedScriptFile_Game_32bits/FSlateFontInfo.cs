#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FSlateFontInfo
	{
		[FieldOffset(16)]
		public FName TypefaceFontName;
		[FieldOffset(24)]
		public int Size;
		[FieldOffset(32)]
		public FName FontName;
		[FieldOffset(40)]
		public EFontHinting Hinting;
		
	}
	
}
#endif
#endif
