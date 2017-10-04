using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SSpinBox</summary>
	public partial struct FSpinBoxStyle
	{
		/// <summary>Brush used to draw the background of the spinbox</summary>
		public FSlateBrush BackgroundBrush;
		/// <summary>Brush used to draw the background of the spinbox when it's hovered over</summary>
		public FSlateBrush HoveredBackgroundBrush;
		/// <summary>Brush used to fill the spinbox when it's active</summary>
		public FSlateBrush ActiveFillBrush;
		/// <summary>Brush used to fill the spinbox when it's inactive</summary>
		public FSlateBrush InactiveFillBrush;
		/// <summary>Image used to draw the spinbox arrows</summary>
		public FSlateBrush ArrowsImage;
		/// <summary>Color used to draw the spinbox foreground elements</summary>
		public FSlateColor ForegroundColor;
		/// <summary>Padding to add around the spinbox and its text</summary>
		public FMargin TextPadding;
		
	}
	
}
