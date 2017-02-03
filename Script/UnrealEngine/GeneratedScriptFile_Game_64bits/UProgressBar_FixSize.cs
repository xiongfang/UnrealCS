#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UProgressBar
	{
		static readonly int WidgetStyle__Offset;
		public FProgressBarStyle WidgetStyle
		{
			get{ CheckIsValid();return (FProgressBarStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FProgressBarStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int BackgroundImage__Offset;
		public USlateBrushAsset BackgroundImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + BackgroundImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int FillImage__Offset;
		public USlateBrushAsset FillImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + FillImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MarqueeImage__Offset;
		public USlateBrushAsset MarqueeImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MarqueeImage__Offset); if (v == IntPtr.Zero)return null; USlateBrushAsset retValue = new USlateBrushAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Percent__Offset;
		public float Percent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Percent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Percent__Offset, false);}
			
		}
		
		static readonly int BarFillType__Offset;
		public EProgressBarFillType BarFillType
		{
			get{ CheckIsValid();return (EProgressBarFillType)Marshal.PtrToStructure(_this.Get()+BarFillType__Offset, typeof(EProgressBarFillType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BarFillType__Offset, false);}
			
		}
		
		static readonly int bIsMarquee__Offset;
		public bool bIsMarquee
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsMarquee__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsMarquee__Offset, 1,0,1,255);}
			
		}
		
		static readonly int FillColorAndOpacity__Offset;
		public FLinearColor FillColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+FillColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FillColorAndOpacity__Offset, false);}
			
		}
		
		static UProgressBar()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ProgressBar");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			BackgroundImage__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundImage");
			FillImage__Offset=GetPropertyOffset(NativeClassPtr,"FillImage");
			MarqueeImage__Offset=GetPropertyOffset(NativeClassPtr,"MarqueeImage");
			Percent__Offset=GetPropertyOffset(NativeClassPtr,"Percent");
			BarFillType__Offset=GetPropertyOffset(NativeClassPtr,"BarFillType");
			bIsMarquee__Offset=GetPropertyOffset(NativeClassPtr,"bIsMarquee");
			FillColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"FillColorAndOpacity");
			
		}
		
	}
	
}
#endif
#endif
