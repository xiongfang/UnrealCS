using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an STableRow</summary>
	public partial struct FTableRowStyle
	{
		/// <summary>Brush used as a selector when a row is focused</summary>
		public FSlateBrush SelectorFocusedBrush;
		/// <summary>Brush used when a selected row is active and hovered</summary>
		public FSlateBrush ActiveHoveredBrush;
		/// <summary>Brush used when a selected row is active</summary>
		public FSlateBrush ActiveBrush;
		/// <summary>Brush used when an selected row is inactive and hovered</summary>
		public FSlateBrush InactiveHoveredBrush;
		/// <summary>Brush used when a selected row is inactive</summary>
		public FSlateBrush InactiveBrush;
		/// <summary>Brush used when an even row is hovered</summary>
		public FSlateBrush EvenRowBackgroundHoveredBrush;
		/// <summary>Brush used when an even row is in its normal state</summary>
		public FSlateBrush EvenRowBackgroundBrush;
		/// <summary>Brush used when an odd row is hovered</summary>
		public FSlateBrush OddRowBackgroundHoveredBrush;
		/// <summary>Brush to used when an odd row is in its normal state</summary>
		public FSlateBrush OddRowBackgroundBrush;
		/// <summary>Text color used for all rows</summary>
		public FSlateColor TextColor;
		/// <summary>Text color used for the selected row</summary>
		public FSlateColor SelectedTextColor;
		/// <summary>Brush used to provide feedback that a user can drop above the hovered row.</summary>
		public FSlateBrush DropIndicator_Above;
		/// <summary>Brush used to provide feedback that a user can drop onto the hovered row.</summary>
		public FSlateBrush DropIndicator_Onto;
		/// <summary>Brush used to provide feedback that a user can drop below the hovered row.</summary>
		public FSlateBrush DropIndicator_Below;
		
	}
	
}
