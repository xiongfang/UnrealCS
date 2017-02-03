#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=656)]
	public partial struct FSpinBoxStyle
	{
		[FieldOffset(8)]
		public FSlateBrush BackgroundBrush;
		[FieldOffset(128)]
		public FSlateBrush HoveredBackgroundBrush;
		[FieldOffset(248)]
		public FSlateBrush ActiveFillBrush;
		[FieldOffset(368)]
		public FSlateBrush InactiveFillBrush;
		[FieldOffset(488)]
		public FSlateBrush ArrowsImage;
		[FieldOffset(608)]
		public FSlateColor ForegroundColor;
		[FieldOffset(636)]
		public FMargin TextPadding;
		
	}
	
}
#endif
#endif
