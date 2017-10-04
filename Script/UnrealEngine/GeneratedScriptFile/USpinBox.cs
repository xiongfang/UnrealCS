using System;
namespace UnrealEngine
{
	public partial class USpinBox:UWidget
	{
		public extern void SetForegroundColor(FSlateColor InForegroundColor);
		/// <summary>Clear the maximum value that can be specified using the slider.</summary>
		public extern void ClearMaxSliderValue();
		/// <summary>Set the maximum value that can be specified using the slider.</summary>
		public extern void SetMaxSliderValue(float NewValue);
		/// <summary>Get the current maximum value that can be specified using the slider.</summary>
		public extern float GetMaxSliderValue();
		/// <summary>Clear the minimum value that can be specified using the slider.</summary>
		public extern void ClearMinSliderValue();
		/// <summary>Set the minimum value that can be specified using the slider.</summary>
		public extern void SetMinSliderValue(float NewValue);
		/// <summary>Get the current minimum value that can be specified using the slider.</summary>
		public extern float GetMinSliderValue();
		/// <summary>Clear the maximum value that can be manually set in the spin box.</summary>
		public extern void ClearMaxValue();
		/// <summary>Set the maximum value that can be manually set in the spin box.</summary>
		public extern void SetMaxValue(float NewValue);
		/// <summary>Get the current maximum value that can be manually set in the spin box.</summary>
		public extern float GetMaxValue();
		/// <summary>Clear the minimum value that can be manually set in the spin box.</summary>
		public extern void ClearMinValue();
		/// <summary>Set the minimum value that can be manually set in the spin box.</summary>
		public extern void SetMinValue(float NewValue);
		/// <summary>Get the current minimum value that can be manually set in the spin box.</summary>
		public extern float GetMinValue();
		/// <summary>Set the value of the spin box.</summary>
		public extern void SetValue(float NewValue);
		/// <summary>Get the current value of the spin box.</summary>
		public extern float GetValue();
		/// <summary>Value stored in this spin box</summary>
		public float Value;
		
		/// <summary>The Style</summary>
		public FSpinBoxStyle WidgetStyle;
		
		public USlateWidgetStyleAsset Style;
		
		/// <summary>The amount by which to change the spin box value as the slider moves.</summary>
		public float Delta;
		
		/// <summary>The exponent by which to increase the delta as the mouse moves. 1 is constant (never increases the delta).</summary>
		public float SliderExponent;
		
		/// <summary>Font color and opacity (overrides style)</summary>
		public FSlateFontInfo Font;
		
		/// <summary>The minimum width of the spin box</summary>
		public float MinDesiredWidth;
		
		/// <summary>Whether to remove the keyboard focus from the spin box when the value is committed</summary>
		public bool ClearKeyboardFocusOnCommit;
		
		/// <summary>Whether to select the text in the spin box when the value is committed</summary>
		public bool SelectAllTextOnCommit;
		
		public FSlateColor ForegroundColor;
		
		/// <summary>Whether the optional MinValue attribute of the widget is set</summary>
		public bool bOverride_MinValue;
		
		/// <summary>Whether the optional MaxValue attribute of the widget is set</summary>
		public bool bOverride_MaxValue;
		
		/// <summary>Whether the optional MinSliderValue attribute of the widget is set</summary>
		public bool bOverride_MinSliderValue;
		
		/// <summary>Whether the optional MaxSliderValue attribute of the widget is set</summary>
		public bool bOverride_MaxSliderValue;
		
		/// <summary>The minimum allowable value that can be manually entered into the spin box</summary>
		public float MinValue;
		
		/// <summary>The maximum allowable value that can be manually entered into the spin box</summary>
		public float MaxValue;
		
		/// <summary>The minimum allowable value that can be specified using the slider</summary>
		public float MinSliderValue;
		
		/// <summary>The maximum allowable value that can be specified using the slider</summary>
		public float MaxSliderValue;
		
		
	}
	
}
