#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=628)]
	public partial struct FSpinBoxStyle
	{
		[FieldOffset(4)]
		public FSlateBrush BackgroundBrush;
		[FieldOffset(120)]
		public FSlateBrush HoveredBackgroundBrush;
		[FieldOffset(236)]
		public FSlateBrush ActiveFillBrush;
		[FieldOffset(352)]
		public FSlateBrush InactiveFillBrush;
		[FieldOffset(468)]
		public FSlateBrush ArrowsImage;
		[FieldOffset(584)]
		public FSlateColor ForegroundColor;
		[FieldOffset(612)]
		public FMargin TextPadding;
		
	}
	
}
#endif
#endif
