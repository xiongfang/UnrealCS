#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UScrollBar
	{
		static readonly int WidgetStyle__Offset;
		public FScrollBarStyle WidgetStyle
		{
			get{ CheckIsValid();return (FScrollBarStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FScrollBarStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bAlwaysShowScrollbar__Offset;
		public bool bAlwaysShowScrollbar
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysShowScrollbar__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysShowScrollbar__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Orientation__Offset;
		public EOrientation Orientation
		{
			get{ CheckIsValid();return (EOrientation)Marshal.PtrToStructure(_this.Get()+Orientation__Offset, typeof(EOrientation));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Orientation__Offset, false);}
			
		}
		
		static readonly int Thickness__Offset;
		public FVector2D Thickness
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Thickness__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Thickness__Offset, false);}
			
		}
		
		static UScrollBar()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ScrollBar");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			bAlwaysShowScrollbar__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysShowScrollbar");
			Orientation__Offset=GetPropertyOffset(NativeClassPtr,"Orientation");
			Thickness__Offset=GetPropertyOffset(NativeClassPtr,"Thickness");
			
		}
		
	}
	
}
#endif
#endif
