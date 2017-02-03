#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SComboButton</summary>
	[StructLayout(LayoutKind.Explicit,Size=1064)]
	public partial struct FComboButtonStyle
	{
		/// <summary>The style to use for our SButton</summary>
		[FieldOffset(8)]
		public FButtonStyle ButtonStyle;
		/// <summary>Image to use for the down arrow</summary>
		[FieldOffset(744)]
		public FSlateBrush DownArrowImage;
		/// <summary>Brush to use to add a "menu border" around the drop-down content</summary>
		[FieldOffset(896)]
		public FSlateBrush MenuBorderBrush;
		/// <summary>Padding to use to add a "menu border" around the drop-down content</summary>
		[FieldOffset(1048)]
		public FMargin MenuBorderPadding;
		
	}
	
}
#endif
#endif
