#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An arbitrary scrollable collection of widgets.  Great for presenting 10-100 widgets in a list.  Doesn't support virtualization.</summary>
	public partial class UScrollBox
	{
		static readonly int WidgetStyle__Offset;
		/// <summary>The style</summary>
		public FScrollBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FScrollBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FScrollBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int WidgetBarStyle__Offset;
		/// <summary>The bar style</summary>
		public FScrollBarStyle WidgetBarStyle
		{
			get{ CheckIsValid();return (FScrollBarStyle)Marshal.PtrToStructure(_this.Get()+WidgetBarStyle__Offset, typeof(FScrollBarStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetBarStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BarStyle__Offset;
		public USlateWidgetStyleAsset BarStyle
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BarStyle__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Orientation__Offset;
		/// <summary>The orientation of the scrolling and stacking in the box.</summary>
		public EOrientation Orientation
		{
			get{ CheckIsValid();return (EOrientation)Marshal.PtrToStructure(_this.Get()+Orientation__Offset, typeof(EOrientation));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Orientation__Offset, false);}
			
		}
		
		static readonly int ScrollBarVisibility__Offset;
		/// <summary>Visibility</summary>
		public ESlateVisibility ScrollBarVisibility
		{
			get{ CheckIsValid();return (ESlateVisibility)Marshal.PtrToStructure(_this.Get()+ScrollBarVisibility__Offset, typeof(ESlateVisibility));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScrollBarVisibility__Offset, false);}
			
		}
		
		static readonly int ConsumeMouseWheel__Offset;
		/// <summary>Enable to always consume mouse wheel event, even when scrolling is not possible</summary>
		public EConsumeMouseWheel ConsumeMouseWheel
		{
			get{ CheckIsValid();return (EConsumeMouseWheel)Marshal.PtrToStructure(_this.Get()+ConsumeMouseWheel__Offset, typeof(EConsumeMouseWheel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConsumeMouseWheel__Offset, false);}
			
		}
		
		static readonly int ScrollbarThickness__Offset;
		public FVector2D ScrollbarThickness
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+ScrollbarThickness__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScrollbarThickness__Offset, false);}
			
		}
		
		static readonly int AlwaysShowScrollbar__Offset;
		public bool AlwaysShowScrollbar
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AlwaysShowScrollbar__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), AlwaysShowScrollbar__Offset, 1,0,1,255);}
			
		}
		
		static UScrollBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ScrollBox");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			WidgetBarStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetBarStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			BarStyle__Offset=GetPropertyOffset(NativeClassPtr,"BarStyle");
			Orientation__Offset=GetPropertyOffset(NativeClassPtr,"Orientation");
			ScrollBarVisibility__Offset=GetPropertyOffset(NativeClassPtr,"ScrollBarVisibility");
			ConsumeMouseWheel__Offset=GetPropertyOffset(NativeClassPtr,"ConsumeMouseWheel");
			ScrollbarThickness__Offset=GetPropertyOffset(NativeClassPtr,"ScrollbarThickness");
			AlwaysShowScrollbar__Offset=GetPropertyOffset(NativeClassPtr,"AlwaysShowScrollbar");
			
		}
		
	}
	
}
#endif
#endif
