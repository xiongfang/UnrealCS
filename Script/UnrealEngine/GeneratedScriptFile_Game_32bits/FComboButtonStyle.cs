#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=808)]
	public partial struct FComboButtonStyle
	{
		[FieldOffset(4)]
		public FButtonStyle ButtonStyle;
		[FieldOffset(560)]
		public FSlateBrush DownArrowImage;
		[FieldOffset(676)]
		public FSlateBrush MenuBorderBrush;
		[FieldOffset(792)]
		public FMargin MenuBorderPadding;
		
	}
	
}
#endif
#endif
