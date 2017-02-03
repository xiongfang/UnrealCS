#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Font import options</summary>
	[StructLayout(LayoutKind.Explicit,Size=176)]
	public partial struct FFontImportOptionsData
	{
		/// <summary>Name of the typeface for the font to import</summary>
		[FieldOffset(0)]
		public FString FontName;
		/// <summary>Height of font (point size)</summary>
		[FieldOffset(16)]
		public float Height;
		/// <summary>Whether the font should be antialiased or not.  Usually you should leave this enabled.</summary>
		public bool bEnableAntialiasing
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Whether the font should be generated in bold or not</summary>
		public bool bEnableBold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Whether the font should be generated in italics or not</summary>
		public bool bEnableItalic
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Whether the font should be generated with an underline or not</summary>
		public bool bEnableUnderline
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 8, 8); } }}
			
		}
		/// <summary>if true then forces PF_G8 and only maintains Alpha value and discards color</summary>
		public bool bAlphaOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 16, 16); } }}
			
		}
		/// <summary>Character set for this font</summary>
		[FieldOffset(24)]
		public EFontImportCharacterSet CharacterSet;
		/// <summary>Explicit list of characters to include in the font</summary>
		[FieldOffset(32)]
		public FString Chars;
		/// <summary>Range of Unicode character values to include in the font.  You can specify ranges using hyphens and/or commas (e.g. '400-900')</summary>
		[FieldOffset(48)]
		public FString UnicodeRange;
		/// <summary>Path on disk to a folder where files that contain a list of characters to include in the font</summary>
		[FieldOffset(64)]
		public FString CharsFilePath;
		/// <summary>File mask wildcard that specifies which files within the CharsFilePath to scan for characters in include in the font</summary>
		[FieldOffset(80)]
		public FString CharsFileWildcard;
		/// <summary>Skips generation of glyphs for any characters that are not considered 'printable'</summary>
		public bool bCreatePrintableOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 96, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 96, 1, 0, 1, 1); } }}
			
		}
		/// <summary>When specifying a range of characters and this is enabled, forces ASCII characters (0 thru 255) to be included as well</summary>
		public bool bIncludeASCIIRange
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 96, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 96, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Color of the foreground font pixels.  Usually you should leave this white and instead use the UI Styles editor to change the color of the font on the fly</summary>
		[FieldOffset(100)]
		public FLinearColor ForegroundColor;
		/// <summary>Enables a very simple, 1-pixel, black colored drop shadow for the generated font</summary>
		public bool bEnableDropShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Horizontal size of each texture page for this font in pixels</summary>
		[FieldOffset(120)]
		public int TexturePageWidth;
		/// <summary>The maximum vertical size of a texture page for this font in pixels.  The actual height of a texture page may be less than this if the font can fit within a smaller sized texture page.</summary>
		[FieldOffset(124)]
		public int TexturePageMaxHeight;
		/// <summary>Horizontal padding between each font character on the texture page in pixels</summary>
		[FieldOffset(128)]
		public int XPadding;
		/// <summary>Vertical padding between each font character on the texture page in pixels</summary>
		[FieldOffset(132)]
		public int YPadding;
		/// <summary>How much to extend the top of the UV coordinate rectangle for each character in pixels</summary>
		[FieldOffset(136)]
		public int ExtendBoxTop;
		/// <summary>How much to extend the bottom of the UV coordinate rectangle for each character in pixels</summary>
		[FieldOffset(140)]
		public int ExtendBoxBottom;
		/// <summary>How much to extend the right of the UV coordinate rectangle for each character in pixels</summary>
		[FieldOffset(144)]
		public int ExtendBoxRight;
		/// <summary>How much to extend the left of the UV coordinate rectangle for each character in pixels</summary>
		[FieldOffset(148)]
		public int ExtendBoxLeft;
		/// <summary>Enables legacy font import mode.  This results in lower quality antialiasing and larger glyph bounds, but may be useful when debugging problems</summary>
		public bool bEnableLegacyMode
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 152, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 152, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The initial horizontal spacing adjustment between rendered characters.  This setting will be copied directly into the generated Font object's properties.</summary>
		[FieldOffset(156)]
		public int Kerning;
		/// <summary>If true then the alpha channel of the font textures will store a distance field instead of a color mask</summary>
		public bool bUseDistanceFieldAlpha
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 160, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 160, 1, 0, 1, 1); } }}
			
		}
		/// <summary>
		/// Scale factor determines how big to scale the font bitmap during import when generating distance field values
		/// Note that higher values give better quality but importing will take much longer.
		/// </summary>
		[FieldOffset(164)]
		public int DistanceFieldScaleFactor;
		/// <summary>Shrinks or expands the scan radius used to determine the silhouette of the font edges.</summary>
		[FieldOffset(168)]
		public float DistanceFieldScanRadiusScale;
		
	}
	
}
#endif
#endif
