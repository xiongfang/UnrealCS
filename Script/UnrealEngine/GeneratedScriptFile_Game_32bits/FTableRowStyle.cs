#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1504)]
	public partial struct FTableRowStyle
	{
		[FieldOffset(8)]
		public FSlateBrush SelectorFocusedBrush;
		[FieldOffset(128)]
		public FSlateBrush ActiveHoveredBrush;
		[FieldOffset(248)]
		public FSlateBrush ActiveBrush;
		[FieldOffset(368)]
		public FSlateBrush InactiveHoveredBrush;
		[FieldOffset(488)]
		public FSlateBrush InactiveBrush;
		[FieldOffset(608)]
		public FSlateBrush EvenRowBackgroundHoveredBrush;
		[FieldOffset(728)]
		public FSlateBrush EvenRowBackgroundBrush;
		[FieldOffset(848)]
		public FSlateBrush OddRowBackgroundHoveredBrush;
		[FieldOffset(968)]
		public FSlateBrush OddRowBackgroundBrush;
		[FieldOffset(1088)]
		public FSlateColor TextColor;
		[FieldOffset(1116)]
		public FSlateColor SelectedTextColor;
		[FieldOffset(1144)]
		public FSlateBrush DropIndicator_Above;
		[FieldOffset(1264)]
		public FSlateBrush DropIndicator_Onto;
		[FieldOffset(1384)]
		public FSlateBrush DropIndicator_Below;
		
	}
	
}
#endif
#endif
