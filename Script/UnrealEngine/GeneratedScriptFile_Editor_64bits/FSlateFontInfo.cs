#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A representation of a font in Slate.</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FSlateFontInfo
	{
		/// <summary>The font object (valid when used from UMG or a Slate widget style asset)</summary>
		/// <summary>The material to use when rendering this font</summary>
		/// <summary>The name of the font to use from the default typeface (None will use the first entry)</summary>
		[FieldOffset(32)]
		public FName TypefaceFontName;
		/// <summary>The size of the font</summary>
		[FieldOffset(44)]
		public int Size;
		/// <summary>The name of the font</summary>
		[FieldOffset(48)]
		public FName FontName;
		/// <summary>The hinting algorithm to use with the font</summary>
		[FieldOffset(60)]
		public EFontHinting Hinting;
		
	}
	
}
#endif
#endif
