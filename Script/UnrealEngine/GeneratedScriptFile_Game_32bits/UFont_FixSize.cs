#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UFont
	{
		static readonly int Characters__Offset;
		public TStructArray<FFontCharacter> Characters
		{
			get{ CheckIsValid();return new TStructArray<FFontCharacter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Characters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Characters__Offset, false);}
			
		}
		
		static readonly int Textures__Offset;
		public TObjectArray<UTexture2D>  Textures
		{
					get{ CheckIsValid();return new TObjectArray<UTexture2D>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Textures__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Textures__Offset, false);}
			
		}
		
		static readonly int IsRemapped__Offset;
		public int IsRemapped
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+IsRemapped__Offset, typeof(int));}
			
		}
		
		static readonly int EmScale__Offset;
		public float EmScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmScale__Offset, false);}
			
		}
		
		static readonly int Ascent__Offset;
		public float Ascent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Ascent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Ascent__Offset, false);}
			
		}
		
		static readonly int Descent__Offset;
		public float Descent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Descent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Descent__Offset, false);}
			
		}
		
		static readonly int Leading__Offset;
		public float Leading
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Leading__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Leading__Offset, false);}
			
		}
		
		static readonly int Kerning__Offset;
		public int Kerning
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Kerning__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Kerning__Offset, false);}
			
		}
		
		static readonly int ImportOptions__Offset;
		public FFontImportOptionsData ImportOptions
		{
			get{ CheckIsValid();return (FFontImportOptionsData)Marshal.PtrToStructure(_this.Get()+ImportOptions__Offset, typeof(FFontImportOptionsData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ImportOptions__Offset, false);}
			
		}
		
		static readonly int NumCharacters__Offset;
		public int NumCharacters
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumCharacters__Offset, typeof(int));}
			
		}
		
		static readonly int MaxCharHeight__Offset;
		public TStructArray<int> MaxCharHeight
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MaxCharHeight__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MaxCharHeight__Offset, false);}
			
		}
		
		static readonly int ScalingFactor__Offset;
		public float ScalingFactor
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ScalingFactor__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScalingFactor__Offset, false);}
			
		}
		
		static readonly int LegacyFontSize__Offset;
		public int LegacyFontSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LegacyFontSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LegacyFontSize__Offset, false);}
			
		}
		
		static readonly int LegacyFontName__Offset;
		public FName LegacyFontName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+LegacyFontName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LegacyFontName__Offset, false);}
			
		}
		
		static readonly int CompositeFont__Offset;
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
