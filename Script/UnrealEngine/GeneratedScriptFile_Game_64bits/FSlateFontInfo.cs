#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FSlateFontInfo
	{
		[FieldOffset(32)]
		public FName TypefaceFontName;
		[FieldOffset(40)]
		public int Size;
		[FieldOffset(48)]
		public FName FontName;
		[FieldOffset(56)]
		public EFontHinting Hinting;
		
	}
	
}
#endif
#endif
