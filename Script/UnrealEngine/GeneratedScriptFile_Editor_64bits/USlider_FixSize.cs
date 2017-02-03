#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A simple widget that shows a sliding bar with a handle that allows you to control the value between 0..1.
	/// * No Children
	/// </summary>
	public partial class USlider
	{
		static readonly int Value__Offset;
		/// <summary>The volume value to display.</summary>
		public float Value
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Value__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Value__Offset, false);}
			
		}
		
		static readonly int WidgetStyle__Offset;
		/// <summary>The progress bar style</summary>
		public FSliderStyle WidgetStyle
		{
			get{ CheckIsValid();return (FSliderStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FSliderStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int Orientation__Offset;
		/// <summary>The slider's orientation.</summary>
		public EOrientation Orientation
		{
			get{ CheckIsValid();return (EOrientation)Marshal.PtrToStructure(_this.Get()+Orientation__Offset, typeof(EOrientation));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Orientation__Offset, false);}
			
		}
		
		static readonly int SliderBarColor__Offset;
		/// <summary>The color to draw the slider bar in.</summary>
		public FLinearColor SliderBarColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SliderBarColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SliderBarColor__Offset, false);}
			
		}
		
		static readonly int SliderHandleColor__Offset;
		/// <summary>The color to draw the slider handle in.</summary>
		public FLinearColor SliderHandleColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+SliderHandleColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SliderHandleColor__Offset, false);}
			
		}
		
		static readonly int IndentHandle__Offset;
		/// <summary>Whether the slidable area should be indented to fit the handle.</summary>
		public bool IndentHandle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IndentHandle__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IndentHandle__Offset, 1,0,1,255);}
			
		}
		
		static readonly int Locked__Offset;
		/// <summary>Whether the handle is interactive or fixed.</summary>
		public bool Locked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), Locked__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), Locked__Offset, 1,0,1,255);}
			
		}
		
		static readonly int StepSize__Offset;
		/// <summary>The amount to adjust the value by, when using a controller or keyboard</summary>
		public float StepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StepSize__Offset, false);}
			
		}
		
		static readonly int IsFocusable__Offset;
		/// <summary>Should the slider be focusable?</summary>
		public bool IsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnMouseCaptureBegin__Offset;
		/// <summary>Invoked when the mouse is pressed and a capture begins.</summary>
		public FMulticastScriptDelegate OnMouseCaptureBegin
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMouseCaptureBegin__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMouseCaptureBegin__Offset, false);}
			
		}
		
		static readonly int OnMouseCaptureEnd__Offset;
		/// <summary>Invoked when the mouse is released and a capture ends.</summary>
		public FMulticastScriptDelegate OnMouseCaptureEnd
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMouseCaptureEnd__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMouseCaptureEnd__Offset, false);}
			
		}
		
		static readonly int OnControllerCaptureBegin__Offset;
		/// <summary>Invoked when the controller capture begins.</summary>
		public FMulticastScriptDelegate OnControllerCaptureBegin
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnControllerCaptureBegin__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnControllerCaptureBegin__Offset, false);}
			
		}
		
		static readonly int OnControllerCaptureEnd__Offset;
		/// <summary>Invoked when the controller capture ends.</summary>
		public FMulticastScriptDelegate OnControllerCaptureEnd
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnControllerCaptureEnd__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnControllerCaptureEnd__Offset, false);}
			
		}
		
		static readonly int OnValueChanged__Offset;
		/// <summary>Called when the value is changed by slider or typing.</summary>
		public FMulticastScriptDelegate OnValueChanged
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnValueChanged__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnValueChanged__Offset, false);}
			
		}
		
		static USlider()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Slider");
			Value__Offset=GetPropertyOffset(NativeClassPtr,"Value");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			Orientation__Offset=GetPropertyOffset(NativeClassPtr,"Orientation");
			SliderBarColor__Offset=GetPropertyOffset(NativeClassPtr,"SliderBarColor");
			SliderHandleColor__Offset=GetPropertyOffset(NativeClassPtr,"SliderHandleColor");
			IndentHandle__Offset=GetPropertyOffset(NativeClassPtr,"IndentHandle");
			Locked__Offset=GetPropertyOffset(NativeClassPtr,"Locked");
			StepSize__Offset=GetPropertyOffset(NativeClassPtr,"StepSize");
			IsFocusable__Offset=GetPropertyOffset(NativeClassPtr,"IsFocusable");
			OnMouseCaptureBegin__Offset=GetPropertyOffset(NativeClassPtr,"OnMouseCaptureBegin");
			OnMouseCaptureEnd__Offset=GetPropertyOffset(NativeClassPtr,"OnMouseCaptureEnd");
			OnControllerCaptureBegin__Offset=GetPropertyOffset(NativeClassPtr,"OnControllerCaptureBegin");
			OnControllerCaptureEnd__Offset=GetPropertyOffset(NativeClassPtr,"OnControllerCaptureEnd");
			OnValueChanged__Offset=GetPropertyOffset(NativeClassPtr,"OnValueChanged");
			
		}
		
	}
	
}
#endif
#endif
