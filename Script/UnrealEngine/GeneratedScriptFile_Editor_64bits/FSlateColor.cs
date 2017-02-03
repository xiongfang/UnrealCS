#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A Slate color can be a directly specified value, or the color can be pulled from a WidgetStyle.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FSlateColor
	{
		/// <summary>The current specified color; only meaningful when ColorToUse == UseColor_Specified.</summary>
		[FieldOffset(0)]
		public FLinearColor SpecifiedColor;
		/// <summary>The rule for which color to pick.</summary>
		[FieldOffset(16)]
		public ESlateColorStylingMode ColorUseRule;
		
	}
	
}
#endif
#endif
