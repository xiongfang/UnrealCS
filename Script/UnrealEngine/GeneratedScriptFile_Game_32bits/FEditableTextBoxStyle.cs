#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1716)]
	public partial struct FEditableTextBoxStyle
	{
		[FieldOffset(4)]
		public FSlateBrush BackgroundImageNormal;
		[FieldOffset(120)]
		public FSlateBrush BackgroundImageHovered;
		[FieldOffset(236)]
		public FSlateBrush BackgroundImageFocused;
		[FieldOffset(352)]
		public FSlateBrush BackgroundImageReadOnly;
		[FieldOffset(468)]
		public FMargin Padding;
		[FieldOffset(484)]
		public FSlateFontInfo Font;
		[FieldOffset(552)]
		public FSlateColor ForegroundColor;
		[FieldOffset(580)]
		public FSlateColor BackgroundColor;
		[FieldOffset(608)]
		public FSlateColor ReadOnlyForegroundColor;
		[FieldOffset(636)]
		public FMargin HScrollBarPadding;
		[FieldOffset(652)]
		public FMargin VScrollBarPadding;
		[FieldOffset(668)]
		public FScrollBarStyle ScrollBarStyle;
		
	}
	
}
#endif
#endif
