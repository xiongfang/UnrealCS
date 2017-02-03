#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=992)]
	public partial struct FComboButtonStyle
	{
		[FieldOffset(8)]
		public FButtonStyle ButtonStyle;
		[FieldOffset(688)]
		public FSlateBrush DownArrowImage;
		[FieldOffset(832)]
		public FSlateBrush MenuBorderBrush;
		[FieldOffset(976)]
		public FMargin MenuBorderPadding;
		
	}
	
}
#endif
#endif
