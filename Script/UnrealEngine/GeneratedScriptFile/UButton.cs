using System;
namespace UnrealEngine
{
	public partial class UButton:UContentWidget
	{
		/// <summary>
		/// Returns true if the user is actively pressing the button.  Do not use this for detecting 'Clicks', use the OnClicked event instead.
		/// @return true if the user is actively pressing the button otherwise false.
		/// </summary>
		public extern bool IsPressed();
		/// <summary>Sets the color multiplier for the button background</summary>
		public extern void SetBackgroundColor(FLinearColor InBackgroundColor);
		/// <summary>Sets the color multiplier for the button content</summary>
		public extern void SetColorAndOpacity(FLinearColor InColorAndOpacity);
		/// <summary>Sets the color multiplier for the button background</summary>
		public extern void SetStyle(FButtonStyle InStyle);
		/// <summary>The template style asset, used to seed the mutable instance of the style.</summary>
		public USlateWidgetStyleAsset Style;
		
		/// <summary>The button style used at runtime</summary>
		public FButtonStyle WidgetStyle;
		
		/// <summary>The color multiplier for the button content</summary>
		public FLinearColor ColorAndOpacity;
		
		/// <summary>The color multiplier for the button background</summary>
		public FLinearColor BackgroundColor;
		
		/// <summary>The type of mouse action required by the user to trigger the buttons 'Click'</summary>
		public EButtonClickMethod ClickMethod;
		
		/// <summary>The type of touch action required by the user to trigger the buttons 'Click'</summary>
		public EButtonTouchMethod TouchMethod;
		
		/// <summary>Sometimes a button should only be mouse-clickable and never keyboard focusable.</summary>
		public bool IsFocusable;
		
		
	}
	
}
