#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=2120)]
	public partial struct FEditableTextBoxStyle
	{
		[FieldOffset(8)]
		public FSlateBrush BackgroundImageNormal;
		[FieldOffset(152)]
		public FSlateBrush BackgroundImageHovered;
		[FieldOffset(296)]
		public FSlateBrush BackgroundImageFocused;
		[FieldOffset(440)]
		public FSlateBrush BackgroundImageReadOnly;
		[FieldOffset(584)]
		public FMargin Padding;
		[FieldOffset(600)]
		public FSlateFontInfo Font;
		[FieldOffset(664)]
		public FSlateColor ForegroundColor;
		[FieldOffset(704)]
		public FSlateColor BackgroundColor;
		[FieldOffset(744)]
		public FSlateColor ReadOnlyForegroundColor;
		[FieldOffset(784)]
		public FMargin HScrollBarPadding;
		[FieldOffset(800)]
		public FMargin VScrollBarPadding;
		[FieldOffset(816)]
		public FScrollBarStyle ScrollBarStyle;
		
	}
	
}
#endif
#endif
