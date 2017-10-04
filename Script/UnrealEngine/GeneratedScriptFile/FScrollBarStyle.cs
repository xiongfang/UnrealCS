using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SScrollBar</summary>
	public partial struct FScrollBarStyle
	{
		/// <summary>Background image to use when the scrollbar is oriented horizontally</summary>
		public FSlateBrush HorizontalBackgroundImage;
		/// <summary>Background image to use when the scrollbar is oriented vertically</summary>
		public FSlateBrush VerticalBackgroundImage;
		/// <summary>The image to use to represent the track above the thumb when the scrollbar is oriented vertically</summary>
		public FSlateBrush VerticalTopSlotImage;
		/// <summary>The image to use to represent the track above the thumb when the scrollbar is oriented horizontally</summary>
		public FSlateBrush HorizontalTopSlotImage;
		/// <summary>The image to use to represent the track below the thumb when the scrollbar is oriented vertically</summary>
		public FSlateBrush VerticalBottomSlotImage;
		/// <summary>The image to use to represent the track below the thumb when the scrollbar is oriented horizontally</summary>
		public FSlateBrush HorizontalBottomSlotImage;
		/// <summary>Image to use when the scrollbar thumb is in its normal state</summary>
		public FSlateBrush NormalThumbImage;
		/// <summary>Image to use when the scrollbar thumb is in its hovered state</summary>
		public FSlateBrush HoveredThumbImage;
		/// <summary>Image to use when the scrollbar thumb is in its dragged state</summary>
		public FSlateBrush DraggedThumbImage;
		
	}
	
}
