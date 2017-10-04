using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SComboButton</summary>
	public partial struct FComboButtonStyle
	{
		/// <summary>The style to use for our SButton</summary>
		public FButtonStyle ButtonStyle;
		/// <summary>Image to use for the down arrow</summary>
		public FSlateBrush DownArrowImage;
		/// <summary>Brush to use to add a "menu border" around the drop-down content</summary>
		public FSlateBrush MenuBorderBrush;
		/// <summary>Padding to use to add a "menu border" around the drop-down content</summary>
		public FMargin MenuBorderPadding;
		
	}
	
}
