#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Renders text in the world with given font. Contains usual font related attributes such as Scale, Alignment, Color etc.</summary>
	public partial class UTextRenderComponent
	{
		static readonly int Text__Offset;
		/// <summary>Text content, can be multi line using <br> as line separator</summary>
		public string Text
		{
			get{ CheckIsValid(); return ((FText)Marshal.PtrToStructure(_this.Get()+Text__Offset, typeof(FText))).ToString();}
			set{ CheckIsValid();Marshal.StructureToPtr(FText.FromString(value), _this.Get()+Text__Offset, false);}
			
		}
		
		static readonly int TextMaterial__Offset;
		/// <summary>Text material</summary>
		public UMaterialInterface TextMaterial
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TextMaterial__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TextMaterial__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TextMaterial__Offset, value._this.Get()); }
			
		}
		
		static readonly int Font__Offset;
		/// <summary>Text font</summary>
		public UFont Font
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Font__Offset); if (v == IntPtr.Zero)return null; UFont retValue = new UFont(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Font__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Font__Offset, value._this.Get()); }
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		/// <summary>Horizontal text alignment</summary>
		public EHorizTextAligment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizTextAligment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizTextAligment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		/// <summary>Vertical text alignment</summary>
		public EVerticalTextAligment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalTextAligment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalTextAligment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static readonly int TextRenderColor__Offset;
		/// <summary>Color of the text, can be accessed as vertex color</summary>
		public FColor TextRenderColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+TextRenderColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextRenderColor__Offset, false);}
			
		}
		
		static readonly int XScale__Offset;
		/// <summary>Horizontal scale, default is 1.0</summary>
		public float XScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+XScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+XScale__Offset, false);}
			
		}
		
		static readonly int YScale__Offset;
		/// <summary>Vertical scale, default is 1.0</summary>
		public float YScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+YScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+YScale__Offset, false);}
			
		}
		
		static readonly int WorldSize__Offset;
		/// <summary>Vertical size of the fonts largest character in world units. Transform, XScale and YScale will affect final size.</summary>
		public float WorldSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WorldSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WorldSize__Offset, false);}
			
		}
		
		static readonly int InvDefaultSize__Offset;
		/// <summary>The inverse of the Font's character height.</summary>
		public float InvDefaultSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InvDefaultSize__Offset, typeof(float));}
			
		}
		
		static readonly int HorizSpacingAdjust__Offset;
		/// <summary>Horizontal adjustment per character, default is 0.0</summary>
		public float HorizSpacingAdjust
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HorizSpacingAdjust__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizSpacingAdjust__Offset, false);}
			
		}
		
		static readonly int VertSpacingAdjust__Offset;
		/// <summary>Vertical adjustment per character, default is 0.0</summary>
		public float VertSpacingAdjust
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VertSpacingAdjust__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VertSpacingAdjust__Offset, false);}
			
		}
		
		static readonly int bAlwaysRenderAsText__Offset;
		/// <summary>Allows text to draw unmodified when using debug visualization modes. *</summary>
		public bool bAlwaysRenderAsText
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysRenderAsText__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysRenderAsText__Offset, 1,0,1,1);}
			
		}
		
		static UTextRenderComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextRenderComponent");
			Text__Offset=GetPropertyOffset(NativeClassPtr,"Text");
			TextMaterial__Offset=GetPropertyOffset(NativeClassPtr,"TextMaterial");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			TextRenderColor__Offset=GetPropertyOffset(NativeClassPtr,"TextRenderColor");
			XScale__Offset=GetPropertyOffset(NativeClassPtr,"XScale");
			YScale__Offset=GetPropertyOffset(NativeClassPtr,"YScale");
			WorldSize__Offset=GetPropertyOffset(NativeClassPtr,"WorldSize");
			InvDefaultSize__Offset=GetPropertyOffset(NativeClassPtr,"InvDefaultSize");
			HorizSpacingAdjust__Offset=GetPropertyOffset(NativeClassPtr,"HorizSpacingAdjust");
			VertSpacingAdjust__Offset=GetPropertyOffset(NativeClassPtr,"VertSpacingAdjust");
			bAlwaysRenderAsText__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysRenderAsText");
			
		}
		
	}
	
}
#endif
#endif
