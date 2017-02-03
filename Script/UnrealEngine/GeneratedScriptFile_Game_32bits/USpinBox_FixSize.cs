#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USpinBox
	{
		static readonly int Value__Offset;
		public float Value
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Value__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Value__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		public FSpinBoxStyle WidgetStyle
		{
			get{ CheckIsValid();return (FSpinBoxStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FSpinBoxStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Style__Offset;
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Delta__Offset;
		public float Delta
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Delta__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Delta__Offset, false);}
			
		}
		
		static readonly int SliderExponent__Offset;
		public float SliderExponent
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SliderExponent__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SliderExponent__Offset, false);}
			
		}
		
		static readonly int Font__Offset;
		public FSlateFontInfo Font
		{
			get{ CheckIsValid();return (FSlateFontInfo)Marshal.PtrToStructure(_this.Get()+Font__Offset, typeof(FSlateFontInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Font__Offset, false);}
			
		}
		
		static readonly int MinDesiredWidth__Offset;
		public float MinDesiredWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDesiredWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDesiredWidth__Offset, false);}
			
		}
		
		static readonly int ClearKeyboardFocusOnCommit__Offset;
		public bool ClearKeyboardFocusOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), ClearKeyboardFocusOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int SelectAllTextOnCommit__Offset;
		public bool SelectAllTextOnCommit
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SelectAllTextOnCommit__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SelectAllTextOnCommit__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ForegroundColor__Offset;
		public FSlateColor ForegroundColor
		{
			get{ CheckIsValid();return (FSlateColor)Marshal.PtrToStructure(_this.Get()+ForegroundColor__Offset, typeof(FSlateColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ForegroundColor__Offset, false);}
			
		}
		
		static readonly int OnValueChanged__Offset;
		public FMulticastScriptDelegate OnValueChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnValueChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnValueChanged__Offset, false);}
			
		}
		
		static readonly int OnValueCommitted__Offset;
		public FMulticastScriptDelegate OnValueCommitted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnValueCommitted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnValueCommitted__Offset, false);}
			
		}
		
		static readonly int OnBeginSliderMovement__Offset;
		public FMulticastScriptDelegate OnBeginSliderMovement
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnBeginSliderMovement__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnBeginSliderMovement__Offset, false);}
			
		}
		
		static readonly int OnEndSliderMovement__Offset;
		public FMulticastScriptDelegate OnEndSliderMovement
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndSliderMovement__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndSliderMovement__Offset, false);}
			
		}
		
		static readonly int bOverride_MinValue__Offset;
		public bool bOverride_MinValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MinValue__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MinValue__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverride_MaxValue__Offset;
		public bool bOverride_MaxValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxValue__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxValue__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bOverride_MinSliderValue__Offset;
		public bool bOverride_MinSliderValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MinSliderValue__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MinSliderValue__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bOverride_MaxSliderValue__Offset;
		public bool bOverride_MaxSliderValue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverride_MaxSliderValue__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverride_MaxSliderValue__Offset, 1,0,8,8);}
			
		}
		
		static readonly int MinValue__Offset;
		public float MinValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinValue__Offset, false);}
			
		}
		
		static readonly int MaxValue__Offset;
		public float MaxValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxValue__Offset, false);}
			
		}
		
		static readonly int MinSliderValue__Offset;
		public float MinSliderValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinSliderValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinSliderValue__Offset, false);}
			
		}
		
		static readonly int MaxSliderValue__Offset;
		public float MaxSliderValue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSliderValue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSliderValue__Offset, false);}
			
		}
		
		static USpinBox()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpinBox");
			Value__Offset=GetPropertyOffset(NativeClassPtr,"Value");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			Delta__Offset=GetPropertyOffset(NativeClassPtr,"Delta");
			SliderExponent__Offset=GetPropertyOffset(NativeClassPtr,"SliderExponent");
			Font__Offset=GetPropertyOffset(NativeClassPtr,"Font");
			MinDesiredWidth__Offset=GetPropertyOffset(NativeClassPtr,"MinDesiredWidth");
			ClearKeyboardFocusOnCommit__Offset=GetPropertyOffset(NativeClassPtr,"ClearKeyboardFocusOnCommit");
			SelectAllTextOnCommit__Offset=GetPropertyOffset(NativeClassPtr,"SelectAllTextOnCommit");
			ForegroundColor__Offset=GetPropertyOffset(NativeClassPtr,"ForegroundColor");
			OnValueChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnValueChanged");
			OnValueCommitted__Offset=GetPropertyOffset(NativeClassPtr,"OnValueCommitted");
			OnBeginSliderMovement__Offset=GetPropertyOffset(NativeClassPtr,"OnBeginSliderMovement");
			OnEndSliderMovement__Offset=GetPropertyOffset(NativeClassPtr,"OnEndSliderMovement");
			bOverride_MinValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MinValue");
			bOverride_MaxValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxValue");
			bOverride_MinSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MinSliderValue");
			bOverride_MaxSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"bOverride_MaxSliderValue");
			MinValue__Offset=GetPropertyOffset(NativeClassPtr,"MinValue");
			MaxValue__Offset=GetPropertyOffset(NativeClassPtr,"MaxValue");
			MinSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"MinSliderValue");
			MaxSliderValue__Offset=GetPropertyOffset(NativeClassPtr,"MaxSliderValue");
			
		}
		
	}
	
}
#endif
#endif
