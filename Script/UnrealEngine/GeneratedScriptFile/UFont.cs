using System;
namespace UnrealEngine
{
	public partial class UFont:UObject
	{
		/// <summary>
		/// True if font is 'remapped'.  That is, the character array is not a direct mapping to unicode values.  Instead,
		///               all characters are indexed indirectly through the CharRemap array
		/// </summary>
		public int IsRemapped;
		
		/// <summary>Font metrics.</summary>
		public float EmScale;
		
		/// <summary>@todo document</summary>
		public float Ascent;
		
		/// <summary>@todo document</summary>
		public float Descent;
		
		/// <summary>@todo document</summary>
		public float Leading;
		
		/// <summary>Default horizontal spacing between characters when rendering text with this font</summary>
		public int Kerning;
		
		/// <summary>Options used when importing this font</summary>
		public FFontImportOptionsData ImportOptions;
		
		/// <summary>
		/// Number of characters in the font, not including multiple instances of the same character (for multi-fonts).
		///               This is cached at load-time or creation time, and is never serialized.
		/// </summary>
		public int NumCharacters;
		
		/// <summary>Scale to apply to the font.</summary>
		public float ScalingFactor;
		
		/// <summary>The default size of the font used for legacy Canvas APIs that don't specify a font size</summary>
		public int LegacyFontSize;
		
		/// <summary>The default font name to use for legacy Canvas APIs that don't specify a font name</summary>
		public FName LegacyFontName;
		
		/// <summary>Embedded composite font data</summary>
		public FCompositeFont CompositeFont;
		
		
	}
	
}
