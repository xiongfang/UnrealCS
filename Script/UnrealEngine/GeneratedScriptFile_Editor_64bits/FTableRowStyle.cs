#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an STableRow</summary>
	[StructLayout(LayoutKind.Explicit,Size=1912)]
	public partial struct FTableRowStyle
	{
		/// <summary>Brush used as a selector when a row is focused</summary>
		[FieldOffset(8)]
		public FSlateBrush SelectorFocusedBrush;
		/// <summary>Brush used when a selected row is active and hovered</summary>
		[FieldOffset(160)]
		public FSlateBrush ActiveHoveredBrush;
		/// <summary>Brush used when a selected row is active</summary>
		[FieldOffset(312)]
		public FSlateBrush ActiveBrush;
		/// <summary>Brush used when an selected row is inactive and hovered</summary>
		[FieldOffset(464)]
		public FSlateBrush InactiveHoveredBrush;
		/// <summary>Brush used when a selected row is inactive</summary>
		[FieldOffset(616)]
		public FSlateBrush InactiveBrush;
		/// <summary>Brush used when an even row is hovered</summary>
		[FieldOffset(768)]
		public FSlateBrush EvenRowBackgroundHoveredBrush;
		/// <summary>Brush used when an even row is in its normal state</summary>
		[FieldOffset(920)]
		public FSlateBrush EvenRowBackgroundBrush;
		/// <summary>Brush used when an odd row is hovered</summary>
		[FieldOffset(1072)]
		public FSlateBrush OddRowBackgroundHoveredBrush;
		/// <summary>Brush to used when an odd row is in its normal state</summary>
		[FieldOffset(1224)]
		public FSlateBrush OddRowBackgroundBrush;
		/// <summary>Text color used for all rows</summary>
		[FieldOffset(1376)]
		public FSlateColor TextColor;
		/// <summary>Text color used for the selected row</summary>
		[FieldOffset(1416)]
		public FSlateColor SelectedTextColor;
		/// <summary>Brush used to provide feedback that a user can drop above the hovered row.</summary>
		[FieldOffset(1456)]
		public FSlateBrush DropIndicator_Above;
		/// <summary>Brush used to provide feedback that a user can drop onto the hovered row.</summary>
		[FieldOffset(1608)]
		public FSlateBrush DropIndicator_Onto;
		/// <summary>Brush used to provide feedback that a user can drop below the hovered row.</summary>
		[FieldOffset(1760)]
		public FSlateBrush DropIndicator_Below;
		
	}
	
}
#endif
#endif
