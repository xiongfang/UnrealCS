#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A representation of a font in Slate.</summary>
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FSlateFontInfo
	{
		/// <summary>The font object (valid when used from UMG or a Slate widget style asset)</summary>
		/// <summary>The material to use when rendering this font</summary>
		/// <summary>Settings for applying an outline to a font</summary>
		[FieldOffset(16)]
		public FFontOutlineSettings OutlineSettings;
		/// <summary>The name of the font to use from the default typeface (None will use the first entry)</summary>
		[FieldOffset(72)]
		public FName TypefaceFontName;
		/// <summary>The size of the font</summary>
		[FieldOffset(84)]
		public int Size;
		/// <summary>The name of the font</summary>
		[FieldOffset(88)]
		public FName FontName;
		
	}
	
}
#endif
#endif
