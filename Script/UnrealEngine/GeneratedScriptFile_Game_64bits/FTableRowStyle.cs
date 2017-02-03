#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1816)]
	public partial struct FTableRowStyle
	{
		[FieldOffset(8)]
		public FSlateBrush SelectorFocusedBrush;
		[FieldOffset(152)]
		public FSlateBrush ActiveHoveredBrush;
		[FieldOffset(296)]
		public FSlateBrush ActiveBrush;
		[FieldOffset(440)]
		public FSlateBrush InactiveHoveredBrush;
		[FieldOffset(584)]
		public FSlateBrush InactiveBrush;
		[FieldOffset(728)]
		public FSlateBrush EvenRowBackgroundHoveredBrush;
		[FieldOffset(872)]
		public FSlateBrush EvenRowBackgroundBrush;
		[FieldOffset(1016)]
		public FSlateBrush OddRowBackgroundHoveredBrush;
		[FieldOffset(1160)]
		public FSlateBrush OddRowBackgroundBrush;
		[FieldOffset(1304)]
		public FSlateColor TextColor;
		[FieldOffset(1344)]
		public FSlateColor SelectedTextColor;
		[FieldOffset(1384)]
		public FSlateBrush DropIndicator_Above;
		[FieldOffset(1528)]
		public FSlateBrush DropIndicator_Onto;
		[FieldOffset(1672)]
		public FSlateBrush DropIndicator_Below;
		
	}
	
}
#endif
#endif
