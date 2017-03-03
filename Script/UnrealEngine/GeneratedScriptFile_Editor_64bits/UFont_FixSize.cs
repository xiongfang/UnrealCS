#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A font object, for use by Slate, UMG, and Canvas.
	/// A font can either be:
	///   * Runtime cached - The font contains a series of TTF files that combine to form a composite font. The glyphs are cached on demand when required at runtime.
	///   * Offline cached - The font contains a series of textures containing pre-baked cached glyphs and their associated texture coordinates.
	/// </summary>
	public partial class UFont
	{
		static readonly int Characters__Offset;
		/// <summary>
		/// List of characters in the font.  For a MultiFont, this will include all characters in all sub-fonts!  Thus,
		///               the number of characters in this array isn't necessary the number of characters available in the font
		/// </summary>
		public TStructArray<FFontCharacter> Characters
		{
			get{ CheckIsValid();return new TStructArray<FFontCharacter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Characters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Characters__Offset, false);}
			
		}
		
		static readonly int Textures__Offset;
		/// <summary>Textures that store this font's glyph image data //NOTE: Do not expose this to the editor as it has nasty crash potential</summary>
		public TObjectArray<UTexture2D>  Textures
		{
					get{ CheckIsValid();return new TObjectArray<UTexture2D>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Textures__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Textures__Offset, false);}
			
		}
		
		static readonly int IsRemapped__Offset;
		/// <summary>
		/// True if font is 'remapped'.  That is, the character array is not a direct mapping to unicode values.  Instead,
		///               all characters are indexed indirectly through the CharRemap array
		/// </summary>
		public int IsRemapped
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+IsRemapped__Offset, typeof(int));}
			
		}
		
		static readonly int EmScale__Offset;
		/// <summary>Font metrics.</summary>
		public float EmScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmScale__Offset, false);}
			
		}
		
		static readonly int Ascent__Offset;
		/// <summary>@todo document</summary>
		public float Ascent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Ascent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Ascent__Offset, false);}
			
		}
		
		static readonly int Descent__Offset;
		/// <summary>@todo document</summary>
		public float Descent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Descent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Descent__Offset, false);}
			
		}
		
		static readonly int Leading__Offset;
		/// <summary>@todo document</summary>
		public float Leading
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Leading__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Leading__Offset, false);}
			
		}
		
		static readonly int Kerning__Offset;
		/// <summary>Default horizontal spacing between characters when rendering text with this font</summary>
		public int Kerning
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Kerning__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Kerning__Offset, false);}
			
		}
		
		static readonly int ImportOptions__Offset;
		/// <summary>Options used when importing this font</summary>
		public FFontImportOptionsData ImportOptions
		{
			get{ CheckIsValid();return (FFontImportOptionsData)Marshal.PtrToStructure(_this.Get()+ImportOptions__Offset, typeof(FFontImportOptionsData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ImportOptions__Offset, false);}
			
		}
		
		static readonly int NumCharacters__Offset;
		/// <summary>
		/// Number of characters in the font, not including multiple instances of the same character (for multi-fonts).
		///               This is cached at load-time or creation time, and is never serialized.
		/// </summary>
		public int NumCharacters
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumCharacters__Offset, typeof(int));}
			
		}
		
		static readonly int MaxCharHeight__Offset;
		/// <summary>
		/// The maximum height of a character in this font.  For multi-fonts, this array will contain a maximum
		///               character height for each multi-font, otherwise the array will contain only a single element.  This is
		///               cached at load-time or creation time, and is never serialized.
		/// </summary>
		public TStructArray<int> MaxCharHeight
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaxCharHeight__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaxCharHeight__Offset, false);}
			
		}
		
		static readonly int ScalingFactor__Offset;
		/// <summary>Scale to apply to the font.</summary>
		public float ScalingFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScalingFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScalingFactor__Offset, false);}
			
		}
		
		static readonly int LegacyFontSize__Offset;
		/// <summary>The default size of the font used for legacy Canvas APIs that don't specify a font size</summary>
		public int LegacyFontSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LegacyFontSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LegacyFontSize__Offset, false);}
			
		}
		
		static readonly int LegacyFontName__Offset;
		/// <summary>The default font name to use for legacy Canvas APIs that don't specify a font name</summary>
		public FName LegacyFontName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+LegacyFontName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LegacyFontName__Offset, false);}
			
		}
		
		static readonly int CompositeFont__Offset;
		/// <summary>Embedded composite font data</summary>
		public FCompositeFont CompositeFont
		{
			get{ CheckIsValid();return (FCompositeFont)Marshal.PtrToStructure(_this.Get()+CompositeFont__Offset, typeof(FCompositeFont));}
			
		}
		
		static UFont()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Font");
			Characters__Offset=GetPropertyOffset(NativeClassPtr,"Characters");
			Textures__Offset=GetPropertyOffset(NativeClassPtr,"Textures");
			IsRemapped__Offset=GetPropertyOffset(NativeClassPtr,"IsRemapped");
			EmScale__Offset=GetPropertyOffset(NativeClassPtr,"EmScale");
			Ascent__Offset=GetPropertyOffset(NativeClassPtr,"Ascent");
			Descent__Offset=GetPropertyOffset(NativeClassPtr,"Descent");
			Leading__Offset=GetPropertyOffset(NativeClassPtr,"Leading");
			Kerning__Offset=GetPropertyOffset(NativeClassPtr,"Kerning");
			ImportOptions__Offset=GetPropertyOffset(NativeClassPtr,"ImportOptions");
			NumCharacters__Offset=GetPropertyOffset(NativeClassPtr,"NumCharacters");
			MaxCharHeight__Offset=GetPropertyOffset(NativeClassPtr,"MaxCharHeight");
			ScalingFactor__Offset=GetPropertyOffset(NativeClassPtr,"ScalingFactor");
			LegacyFontSize__Offset=GetPropertyOffset(NativeClassPtr,"LegacyFontSize");
			LegacyFontName__Offset=GetPropertyOffset(NativeClassPtr,"LegacyFontName");
			CompositeFont__Offset=GetPropertyOffset(NativeClassPtr,"CompositeFont");
			
		}
		
	}
	
}
#endif
#endif
