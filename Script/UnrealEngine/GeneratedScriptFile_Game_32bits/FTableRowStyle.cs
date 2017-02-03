#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1452)]
	public partial struct FTableRowStyle
	{
		[FieldOffset(4)]
		public FSlateBrush SelectorFocusedBrush;
		[FieldOffset(120)]
		public FSlateBrush ActiveHoveredBrush;
		[FieldOffset(236)]
		public FSlateBrush ActiveBrush;
		[FieldOffset(352)]
		public FSlateBrush InactiveHoveredBrush;
		[FieldOffset(468)]
		public FSlateBrush InactiveBrush;
		[FieldOffset(584)]
		public FSlateBrush EvenRowBackgroundHoveredBrush;
		[FieldOffset(700)]
		public FSlateBrush EvenRowBackgroundBrush;
		[FieldOffset(816)]
		public FSlateBrush OddRowBackgroundHoveredBrush;
		[FieldOffset(932)]
		public FSlateBrush OddRowBackgroundBrush;
		[FieldOffset(1048)]
		public FSlateColor TextColor;
		[FieldOffset(1076)]
		public FSlateColor SelectedTextColor;
		[FieldOffset(1104)]
		public FSlateBrush DropIndicator_Above;
		[FieldOffset(1220)]
		public FSlateBrush DropIndicator_Onto;
		[FieldOffset(1336)]
		public FSlateBrush DropIndicator_Below;
		
	}
	
}
#endif
#endif
