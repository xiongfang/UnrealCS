#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextLayoutWidget
	{
		static readonly int ShapedTextOptions__Offset;
		public FShapedTextOptions ShapedTextOptions
		{
			get{ CheckIsValid();return (FShapedTextOptions)Marshal.PtrToStructure(_this.Get()+ShapedTextOptions__Offset, typeof(FShapedTextOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapedTextOptions__Offset, false);}
			
		}
		
		static readonly int Justification__Offset;
		public ETextJustify Justification
		{
			get{ CheckIsValid();return (ETextJustify)Marshal.PtrToStructure(_this.Get()+Justification__Offset, typeof(ETextJustify));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Justification__Offset, false);}
			
		}
		
		static readonly int AutoWrapText__Offset;
		public bool AutoWrapText
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AutoWrapText__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AutoWrapText__Offset, 1,0,1,255);}
			
		}
		
		static readonly int WrapTextAt__Offset;
		public float WrapTextAt
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WrapTextAt__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WrapTextAt__Offset, false);}
			
		}
		
		static readonly int Margin__Offset;
		public FMargin Margin
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Margin__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Margin__Offset, false);}
			
		}
		
		static readonly int LineHeightPercentage__Offset;
		public float LineHeightPercentage
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LineHeightPercentage__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LineHeightPercentage__Offset, false);}
			
		}
		
		static UTextLayoutWidget()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextLayoutWidget");
			ShapedTextOptions__Offset=GetPropertyOffset(NativeClassPtr,"ShapedTextOptions");
			Justification__Offset=GetPropertyOffset(NativeClassPtr,"Justification");
			AutoWrapText__Offset=GetPropertyOffset(NativeClassPtr,"AutoWrapText");
			WrapTextAt__Offset=GetPropertyOffset(NativeClassPtr,"WrapTextAt");
			Margin__Offset=GetPropertyOffset(NativeClassPtr,"Margin");
			LineHeightPercentage__Offset=GetPropertyOffset(NativeClassPtr,"LineHeightPercentage");
			
		}
		
	}
	
}
#endif
#endif
