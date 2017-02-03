#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1760)]
	public partial struct FEditableTextBoxStyle
	{
		[FieldOffset(8)]
		public FSlateBrush BackgroundImageNormal;
		[FieldOffset(128)]
		public FSlateBrush BackgroundImageHovered;
		[FieldOffset(248)]
		public FSlateBrush BackgroundImageFocused;
		[FieldOffset(368)]
		public FSlateBrush BackgroundImageReadOnly;
		[FieldOffset(488)]
		public FMargin Padding;
		[FieldOffset(504)]
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
		[FieldOffset(672)]
		public FScrollBarStyle ScrollBarStyle;
		
	}
	
}
#endif
#endif
