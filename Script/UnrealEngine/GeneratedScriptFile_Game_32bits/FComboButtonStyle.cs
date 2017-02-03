#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=848)]
	public partial struct FComboButtonStyle
	{
		[FieldOffset(8)]
		public FButtonStyle ButtonStyle;
		[FieldOffset(592)]
		public FSlateBrush DownArrowImage;
		[FieldOffset(712)]
		public FSlateBrush MenuBorderBrush;
		[FieldOffset(832)]
		public FMargin MenuBorderPadding;
		
	}
	
}
#endif
#endif
