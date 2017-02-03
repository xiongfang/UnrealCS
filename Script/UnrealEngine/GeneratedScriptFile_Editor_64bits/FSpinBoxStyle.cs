#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SSpinBox</summary>
	[StructLayout(LayoutKind.Explicit,Size=824)]
	public partial struct FSpinBoxStyle
	{
		/// <summary>Brush used to draw the background of the spinbox</summary>
		[FieldOffset(8)]
		public FSlateBrush BackgroundBrush;
		/// <summary>Brush used to draw the background of the spinbox when it's hovered over</summary>
		[FieldOffset(160)]
		public FSlateBrush HoveredBackgroundBrush;
		/// <summary>Brush used to fill the spinbox when it's active</summary>
		[FieldOffset(312)]
		public FSlateBrush ActiveFillBrush;
		/// <summary>Brush used to fill the spinbox when it's inactive</summary>
		[FieldOffset(464)]
		public FSlateBrush InactiveFillBrush;
		/// <summary>Image used to draw the spinbox arrows</summary>
		[FieldOffset(616)]
		public FSlateBrush ArrowsImage;
		/// <summary>Color used to draw the spinbox foreground elements</summary>
		[FieldOffset(768)]
		public FSlateColor ForegroundColor;
		/// <summary>Padding to add around the spinbox and its text</summary>
		[FieldOffset(808)]
		public FMargin TextPadding;
		
	}
	
}
#endif
#endif
