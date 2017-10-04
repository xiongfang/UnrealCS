using System;
namespace UnrealEngine
{
	/// <summary>Font import options</summary>
	public partial struct FFontImportOptionsData
	{
		/// <summary>Name of the typeface for the font to import</summary>
		public FString FontName;
		/// <summary>Height of font (point size)</summary>
		public float Height;
		/// <summary>Whether the font should be antialiased or not.  Usually you should leave this enabled.</summary>
		public bool bEnableAntialiasing;
		/// <summary>Whether the font should be generated in bold or not</summary>
		public bool bEnableBold;
		/// <summary>Whether the font should be generated in italics or not</summary>
		public bool bEnableItalic;
		/// <summary>Whether the font should be generated with an underline or not</summary>
		public bool bEnableUnderline;
		/// <summary>if true then forces PF_G8 and only maintains Alpha value and discards color</summary>
		public bool bAlphaOnly;
		/// <summary>Character set for this font</summary>
		public EFontImportCharacterSet CharacterSet;
		/// <summary>Explicit list of characters to include in the font</summary>
		public FString Chars;
		/// <summary>Range of Unicode character values to include in the font.  You can specify ranges using hyphens and/or commas (e.g. '400-900')</summary>
		public FString UnicodeRange;
		/// <summary>Path on disk to a folder where files that contain a list of characters to include in the font</summary>
		public FString CharsFilePath;
		/// <summary>File mask wildcard that specifies which files within the CharsFilePath to scan for characters in include in the font</summary>
		public FString CharsFileWildcard;
		/// <summary>Skips generation of glyphs for any characters that are not considered 'printable'</summary>
		public bool bCreatePrintableOnly;
		/// <summary>When specifying a range of characters and this is enabled, forces ASCII characters (0 thru 255) to be included as well</summary>
		public bool bIncludeASCIIRange;
		/// <summary>Color of the foreground font pixels.  Usually you should leave this white and instead use the UI Styles editor to change the color of the font on the fly</summary>
		public FLinearColor ForegroundColor;
		/// <summary>Enables a very simple, 1-pixel, black colored drop shadow for the generated font</summary>
		public bool bEnableDropShadow;
		/// <summary>Horizontal size of each texture page for this font in pixels</summary>
		public int TexturePageWidth;
		/// <summary>The maximum vertical size of a texture page for this font in pixels.  The actual height of a texture page may be less than this if the font can fit within a smaller sized texture page.</summary>
		public int TexturePageMaxHeight;
		/// <summary>Horizontal padding between each font character on the texture page in pixels</summary>
		public int XPadding;
		/// <summary>Vertical padding between each font character on the texture page in pixels</summary>
		public int YPadding;
		/// <summary>How much to extend the top of the UV coordinate rectangle for each character in pixels</summary>
		public int ExtendBoxTop;
		/// <summary>How much to extend the bottom of the UV coordinate rectangle for each character in pixels</summary>
		public int ExtendBoxBottom;
		/// <summary>How much to extend the right of the UV coordinate rectangle for each character in pixels</summary>
		public int ExtendBoxRight;
		/// <summary>How much to extend the left of the UV coordinate rectangle for each character in pixels</summary>
		public int ExtendBoxLeft;
		/// <summary>Enables legacy font import mode.  This results in lower quality antialiasing and larger glyph bounds, but may be useful when debugging problems</summary>
		public bool bEnableLegacyMode;
		/// <summary>The initial horizontal spacing adjustment between rendered characters.  This setting will be copied directly into the generated Font object's properties.</summary>
		public int Kerning;
		/// <summary>If true then the alpha channel of the font textures will store a distance field instead of a color mask</summary>
		public bool bUseDistanceFieldAlpha;
		/// <summary>
		/// Scale factor determines how big to scale the font bitmap during import when generating distance field values
		/// Note that higher values give better quality but importing will take much longer.
		/// </summary>
		public int DistanceFieldScaleFactor;
		/// <summary>Shrinks or expands the scan radius used to determine the silhouette of the font edges.</summary>
		public float DistanceFieldScanRadiusScale;
		
	}
	
}
