using System;
namespace UnrealEngine
{
	/// <summary>A Slate color can be a directly specified value, or the color can be pulled from a WidgetStyle.</summary>
	public partial struct FSlateColor
	{
		/// <summary>The current specified color; only meaningful when ColorToUse == UseColor_Specified.</summary>
		public FLinearColor SpecifiedColor;
		/// <summary>The rule for which color to pick.</summary>
		public ESlateColorStylingMode ColorUseRule;
		
	}
	
}
