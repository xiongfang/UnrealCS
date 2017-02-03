#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SEditableTextBox</summary>
	[StructLayout(LayoutKind.Explicit,Size=2264)]
	public partial struct FEditableTextBoxStyle
	{
		/// <summary>Border background image when the box is not hovered or focused</summary>
		[FieldOffset(8)]
		public FSlateBrush BackgroundImageNormal;
		/// <summary>Border background image when the box is hovered</summary>
		[FieldOffset(160)]
		public FSlateBrush BackgroundImageHovered;
		/// <summary>Border background image when the box is focused</summary>
		[FieldOffset(312)]
		public FSlateBrush BackgroundImageFocused;
		/// <summary>Border background image when the box is read-only</summary>
		[FieldOffset(464)]
		public FSlateBrush BackgroundImageReadOnly;
		/// <summary>Padding</summary>
		[FieldOffset(616)]
		public FMargin Padding;
		/// <summary>Font family and size to be used when displaying this text.</summary>
		[FieldOffset(632)]
		public FSlateFontInfo Font;
		/// <summary>The foreground color of text.</summary>
		[FieldOffset(736)]
		public FSlateColor ForegroundColor;
		/// <summary>The background color applied to the active background image</summary>
		[FieldOffset(776)]
		public FSlateColor BackgroundColor;
		/// <summary>The read-only foreground color of text in read-only mode.</summary>
		[FieldOffset(816)]
		public FSlateColor ReadOnlyForegroundColor;
		/// <summary>Padding around the horizontal scrollbar</summary>
		[FieldOffset(856)]
		public FMargin HScrollBarPadding;
		/// <summary>Padding around the vertical scrollbar</summary>
		[FieldOffset(872)]
		public FMargin VScrollBarPadding;
		/// <summary>Style used for the scrollbars</summary>
		[FieldOffset(888)]
		public FScrollBarStyle ScrollBarStyle;
		
	}
	
}
#endif
#endif
