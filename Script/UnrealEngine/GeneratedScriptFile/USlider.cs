using System;
namespace UnrealEngine
{
	public partial class USlider:UWidget
	{
		/// <summary>Sets the color of the handle bar</summary>
		public extern void SetSliderHandleColor(FLinearColor InValue);
		/// <summary>Sets the color of the slider bar</summary>
		public extern void SetSliderBarColor(FLinearColor InValue);
		/// <summary>Sets the amount to adjust the value by, when using a controller or keyboard</summary>
		public extern void SetStepSize(float InValue);
		/// <summary>Sets the handle to be interactive or fixed</summary>
		public extern void SetLocked(bool InValue);
		/// <summary>Sets if the slidable area should be indented to fit the handle</summary>
		public extern void SetIndentHandle(bool InValue);
		/// <summary>Sets the current value of the slider.</summary>
		public extern void SetValue(float InValue);
		/// <summary>Gets the current value of the slider.</summary>
		public extern float GetValue();
		/// <summary>The volume value to display.</summary>
		public float Value;
		
		/// <summary>The progress bar style</summary>
		public FSliderStyle WidgetStyle;
		
		/// <summary>The slider's orientation.</summary>
		public EOrientation Orientation;
		
		/// <summary>The color to draw the slider bar in.</summary>
		public FLinearColor SliderBarColor;
		
		/// <summary>The color to draw the slider handle in.</summary>
		public FLinearColor SliderHandleColor;
		
		/// <summary>Whether the slidable area should be indented to fit the handle.</summary>
		public bool IndentHandle;
		
		/// <summary>Whether the handle is interactive or fixed.</summary>
		public bool Locked;
		
		/// <summary>The amount to adjust the value by, when using a controller or keyboard</summary>
		public float StepSize;
		
		/// <summary>Should the slider be focusable?</summary>
		public bool IsFocusable;
		
		
	}
	
}
