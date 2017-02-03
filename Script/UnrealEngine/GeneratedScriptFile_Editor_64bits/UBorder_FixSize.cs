#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A border is a container widget that can contain one child widget, providing an opportunity
	/// to surround it with a background image and adjustable padding.
	/// * Single Child
	/// * Image
	/// </summary>
	public partial class UBorder
	{
		static readonly int ContentColorAndOpacity__Offset;
		/// <summary>Color and opacity multiplier of content in the border</summary>
		public FLinearColor ContentColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ContentColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ContentColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int Padding__Offset;
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		/// <summary>The alignment of the content horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		/// <summary>The alignment of the content vertically.</summary>
		public EVerticalAlignment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalAlignment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static readonly int Background__Offset;
		/// <summary>Brush to drag as the background</summary>
		public FSlateBrush Background
		{
			get{ CheckIsValid();return (FSlateBrush)Marshal.PtrToStructure(_this.Get()+Background__Offset, typeof(FSlateBrush));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Background__Offset, false);}
			
		}
		
		static readonly int BrushColor__Offset;
		/// <summary>Color and opacity of the actual border image</summary>
		public FLinearColor BrushColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+BrushColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BrushColor__Offset, false);}
			
		}
		
		static readonly int DesiredSizeScale__Offset;
		/// <summary>
		/// Scales the computed desired size of this border and its contents. Useful
		/// for making things that slide open without having to hard-code their size.
		/// Note: if the parent widget is set up to ignore this widget's desired size,
		/// then changing this value will have no effect.
		/// </summary>
		public FVector2D DesiredSizeScale
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+DesiredSizeScale__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DesiredSizeScale__Offset, false);}
			
		}
		
		static readonly int bShowEffectWhenDisabled__Offset;
		/// <summary>Whether or not to show the disabled effect when this border is disabled</summary>
		public bool bShowEffectWhenDisabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowEffectWhenDisabled__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowEffectWhenDisabled__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Brush__Offset;
		/// <summary>Image to use for the border</summary>
		public USlateBrushAsset Brush
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Brush__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static UBorder()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Border");
			ContentColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ContentColorAndOpacity");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			Background__Offset=GetPropertyOffset(NativeClassPtr,"Background");
			BrushColor__Offset=GetPropertyOffset(NativeClassPtr,"BrushColor");
			DesiredSizeScale__Offset=GetPropertyOffset(NativeClassPtr,"DesiredSizeScale");
			bShowEffectWhenDisabled__Offset=GetPropertyOffset(NativeClassPtr,"bShowEffectWhenDisabled");
			Brush__Offset=GetPropertyOffset(NativeClassPtr,"Brush");
			
		}
		
	}
	
}
#endif
#endif
