#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCheckBox
	{
		static readonly int WidgetStyle__Offset;
		public FCheckBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FCheckBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FCheckBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UncheckedImage__Offset;
		public USlateBrushAsset UncheckedImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UncheckedImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UncheckedHoveredImage__Offset;
		public USlateBrushAsset UncheckedHoveredImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UncheckedHoveredImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UncheckedPressedImage__Offset;
		public USlateBrushAsset UncheckedPressedImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UncheckedPressedImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CheckedImage__Offset;
		public USlateBrushAsset CheckedImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheckedImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CheckedHoveredImage__Offset;
		public USlateBrushAsset CheckedHoveredImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheckedHoveredImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CheckedPressedImage__Offset;
		public USlateBrushAsset CheckedPressedImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheckedPressedImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UndeterminedImage__Offset;
		public USlateBrushAsset UndeterminedImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UndeterminedImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UndeterminedHoveredImage__Offset;
		public USlateBrushAsset UndeterminedHoveredImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UndeterminedHoveredImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int UndeterminedPressedImage__Offset;
		public USlateBrushAsset UndeterminedPressedImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + UndeterminedPressedImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int Padding__Offset;
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			
		}
		
		static readonly int BorderBackgroundColor__Offset;
		public FSlateColor BorderBackgroundColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+BorderBackgroundColor__Offset, typeof(FSlateColor));}
			
		}
		
		static readonly int IsFocusable__Offset;
		public bool IsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnCheckStateChanged__Offset;
		public FMulticastScriptDelegate OnCheckStateChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnCheckStateChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnCheckStateChanged__Offset, false);}
			
		}
		
		static UCheckBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CheckBox");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			UncheckedImage__Offset=GetPropertyOffset(NativeClassPtr,"UncheckedImage");
			UncheckedHoveredImage__Offset=GetPropertyOffset(NativeClassPtr,"UncheckedHoveredImage");
			UncheckedPressedImage__Offset=GetPropertyOffset(NativeClassPtr,"UncheckedPressedImage");
			CheckedImage__Offset=GetPropertyOffset(NativeClassPtr,"CheckedImage");
			CheckedHoveredImage__Offset=GetPropertyOffset(NativeClassPtr,"CheckedHoveredImage");
			CheckedPressedImage__Offset=GetPropertyOffset(NativeClassPtr,"CheckedPressedImage");
			UndeterminedImage__Offset=GetPropertyOffset(NativeClassPtr,"UndeterminedImage");
			UndeterminedHoveredImage__Offset=GetPropertyOffset(NativeClassPtr,"UndeterminedHoveredImage");
			UndeterminedPressedImage__Offset=GetPropertyOffset(NativeClassPtr,"UndeterminedPressedImage");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			BorderBackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BorderBackgroundColor");
			IsFocusable__Offset=GetPropertyOffset(NativeClassPtr,"IsFocusable");
			OnCheckStateChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnCheckStateChanged");
			
		}
		
	}
	
}
#endif
#endif
