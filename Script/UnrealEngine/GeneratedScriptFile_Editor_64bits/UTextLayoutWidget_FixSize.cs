#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Base class for all widgets that use a text layout.
	/// Contains the common options that should be exposed for the underlying Slate widget.
	/// </summary>
	public partial class UTextLayoutWidget
	{
		static readonly int ShapedTextOptions__Offset;
		/// <summary>Controls how the text within this widget should be shaped.</summary>
		public FShapedTextOptions ShapedTextOptions
		{
			get{ CheckIsValid();return (FShapedTextOptions)Marshal.PtrToStructure(_this.Get()+ShapedTextOptions__Offset, typeof(FShapedTextOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShapedTextOptions__Offset, false);}
			
		}
		
		static readonly int Justification__Offset;
		/// <summary>How the text should be aligned with the margin.</summary>
		public ETextJustify Justification
		{
			get{ CheckIsValid();return (ETextJustify)Marshal.PtrToStructure(_this.Get()+Justification__Offset, typeof(ETextJustify));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Justification__Offset, false);}
			
		}
		
		static readonly int AutoWrapText__Offset;
		/// <summary>True if we're wrapping text automatically based on the computed horizontal space for this widget.</summary>
		public bool AutoWrapText
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AutoWrapText__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AutoWrapText__Offset, 1,0,1,255);}
			
		}
		
		static readonly int WrapTextAt__Offset;
		/// <summary>Whether text wraps onto a new line when it's length exceeds this width; if this value is zero or negative, no wrapping occurs.</summary>
		public float WrapTextAt
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WrapTextAt__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WrapTextAt__Offset, false);}
			
		}
		
		static readonly int Margin__Offset;
		/// <summary>The amount of blank space left around the edges of text area.</summary>
		public FMargin Margin
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Margin__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Margin__Offset, false);}
			
		}
		
		static readonly int LineHeightPercentage__Offset;
		/// <summary>The amount to scale each lines height by.</summary>
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
