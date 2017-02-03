#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The button is a click-able primitive widget to enable basic interaction, you
	/// can place any other widget inside a button to make a more complex and
	/// interesting click-able element in your UI.
	/// * Single Child
	/// * Clickable
	/// </summary>
	public partial class UButton
	{
		static readonly int Style__Offset;
		/// <summary>The template style asset, used to seed the mutable instance of the style.</summary>
		public USlateWidgetStyleAsset Style
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Style__Offset); if (v == IntPtr.Zero)return null; USlateWidgetStyleAsset retValue = new USlateWidgetStyleAsset(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int WidgetStyle__Offset;
		/// <summary>The button style used at runtime</summary>
		public FButtonStyle WidgetStyle
		{
			get{ CheckIsValid();return (FButtonStyle)Marshal.PtrToStructure(_this.Get()+WidgetStyle__Offset, typeof(FButtonStyle));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidgetStyle__Offset, false);}
			
		}
		
		static readonly int ColorAndOpacity__Offset;
		/// <summary>The color multiplier for the button content</summary>
		public FLinearColor ColorAndOpacity
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ColorAndOpacity__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColorAndOpacity__Offset, false);}
			
		}
		
		static readonly int BackgroundColor__Offset;
		/// <summary>The color multiplier for the button background</summary>
		public FLinearColor BackgroundColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+BackgroundColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BackgroundColor__Offset, false);}
			
		}
		
		static readonly int ClickMethod__Offset;
		/// <summary>The type of mouse action required by the user to trigger the buttons 'Click'</summary>
		public EButtonClickMethod ClickMethod
		{
			get{ CheckIsValid();return (EButtonClickMethod)Marshal.PtrToStructure(_this.Get()+ClickMethod__Offset, typeof(EButtonClickMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ClickMethod__Offset, false);}
			
		}
		
		static readonly int TouchMethod__Offset;
		/// <summary>The type of touch action required by the user to trigger the buttons 'Click'</summary>
		public EButtonTouchMethod TouchMethod
		{
			get{ CheckIsValid();return (EButtonTouchMethod)Marshal.PtrToStructure(_this.Get()+TouchMethod__Offset, typeof(EButtonTouchMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TouchMethod__Offset, false);}
			
		}
		
		static readonly int IsFocusable__Offset;
		/// <summary>Sometimes a button should only be mouse-clickable and never keyboard focusable.</summary>
		public bool IsFocusable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), IsFocusable__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), IsFocusable__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnClicked__Offset;
		/// <summary>Called when the button is clicked</summary>
		public FMulticastScriptDelegate OnClicked
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnClicked__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnClicked__Offset, false);}
			
		}
		
		static readonly int OnPressed__Offset;
		/// <summary>Called when the button is pressed</summary>
		public FMulticastScriptDelegate OnPressed
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnPressed__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnPressed__Offset, false);}
			
		}
		
		static readonly int OnReleased__Offset;
		/// <summary>Called when the button is released</summary>
		public FMulticastScriptDelegate OnReleased
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnReleased__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnReleased__Offset, false);}
			
		}
		
		static readonly int OnHovered__Offset;
		public FMulticastScriptDelegate OnHovered
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnHovered__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnHovered__Offset, false);}
			
		}
		
		static readonly int OnUnhovered__Offset;
		public FMulticastScriptDelegate OnUnhovered
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnUnhovered__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnUnhovered__Offset, false);}
			
		}
		
		static UButton()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Button");
			Style__Offset=GetPropertyOffset(NativeClassPtr,"Style");
			WidgetStyle__Offset=GetPropertyOffset(NativeClassPtr,"WidgetStyle");
			ColorAndOpacity__Offset=GetPropertyOffset(NativeClassPtr,"ColorAndOpacity");
			BackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundColor");
			ClickMethod__Offset=GetPropertyOffset(NativeClassPtr,"ClickMethod");
			TouchMethod__Offset=GetPropertyOffset(NativeClassPtr,"TouchMethod");
			IsFocusable__Offset=GetPropertyOffset(NativeClassPtr,"IsFocusable");
			OnClicked__Offset=GetPropertyOffset(NativeClassPtr,"OnClicked");
			OnPressed__Offset=GetPropertyOffset(NativeClassPtr,"OnPressed");
			OnReleased__Offset=GetPropertyOffset(NativeClassPtr,"OnReleased");
			OnHovered__Offset=GetPropertyOffset(NativeClassPtr,"OnHovered");
			OnUnhovered__Offset=GetPropertyOffset(NativeClassPtr,"OnUnhovered");
			
		}
		
	}
	
}
#endif
#endif
