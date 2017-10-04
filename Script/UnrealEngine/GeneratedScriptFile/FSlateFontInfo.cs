using System;
namespace UnrealEngine
{
	/// <summary>A representation of a font in Slate.</summary>
	public partial struct FSlateFontInfo
	{
		/// <summary>The font object (valid when used from UMG or a Slate widget style asset)</summary>
		public UObject FontObject;
		/// <summary>The material to use when rendering this font</summary>
		public UObject FontMaterial;
		/// <summary>Settings for applying an outline to a font</summary>
		public FFontOutlineSettings OutlineSettings;
		/// <summary>The name of the font to use from the default typeface (None will use the first entry)</summary>
		public FName TypefaceFontName;
		/// <summary>The size of the font</summary>
		public int Size;
		/// <summary>The name of the font</summary>
		public FName FontName;
		
	}
	
}
