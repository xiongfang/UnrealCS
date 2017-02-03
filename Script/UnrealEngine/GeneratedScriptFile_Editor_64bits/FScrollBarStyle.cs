#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SScrollBar</summary>
	[StructLayout(LayoutKind.Explicit,Size=1376)]
	public partial struct FScrollBarStyle
	{
		/// <summary>Background image to use when the scrollbar is oriented horizontally</summary>
		[FieldOffset(8)]
		public FSlateBrush HorizontalBackgroundImage;
		/// <summary>Background image to use when the scrollbar is oriented vertically</summary>
		[FieldOffset(160)]
		public FSlateBrush VerticalBackgroundImage;
		/// <summary>The image to use to represent the track above the thumb when the scrollbar is oriented vertically</summary>
		[FieldOffset(312)]
		public FSlateBrush VerticalTopSlotImage;
		/// <summary>The image to use to represent the track above the thumb when the scrollbar is oriented horizontally</summary>
		[FieldOffset(464)]
		public FSlateBrush HorizontalTopSlotImage;
		/// <summary>The image to use to represent the track below the thumb when the scrollbar is oriented vertically</summary>
		[FieldOffset(616)]
		public FSlateBrush VerticalBottomSlotImage;
		/// <summary>The image to use to represent the track below the thumb when the scrollbar is oriented horizontally</summary>
		[FieldOffset(768)]
		public FSlateBrush HorizontalBottomSlotImage;
		/// <summary>Image to use when the scrollbar thumb is in its normal state</summary>
		[FieldOffset(920)]
		public FSlateBrush NormalThumbImage;
		/// <summary>Image to use when the scrollbar thumb is in its hovered state</summary>
		[FieldOffset(1072)]
		public FSlateBrush HoveredThumbImage;
		/// <summary>Image to use when the scrollbar thumb is in its dragged state</summary>
		[FieldOffset(1224)]
		public FSlateBrush DraggedThumbImage;
		
	}
	
}
#endif
#endif
