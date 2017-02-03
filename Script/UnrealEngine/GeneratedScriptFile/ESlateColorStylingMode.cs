using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Enumerates types of color values that can be held by Slate color.
	/// Should we use the specified color? If not, then which color from the style should we use.
	/// </summary>
	public enum ESlateColorStylingMode:byte
	{
		/// <summary>Color value is stored in this Slate color.</summary>
		UseColor_Specified=0,
		/// <summary>Color value is stored in the linked color.</summary>
		UseColor_Specified_Link=1,
		/// <summary>Use the widget's foreground color.</summary>
		UseColor_Foreground=2,
		/// <summary>Use the widget's subdued color.</summary>
		UseColor_Foreground_Subdued=3,
		UseColor_MAX=4,
		
	}
	
}
