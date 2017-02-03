#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=784)]
	public partial struct FSpinBoxStyle
	{
		[FieldOffset(8)]
		public FSlateBrush BackgroundBrush;
		[FieldOffset(152)]
		public FSlateBrush HoveredBackgroundBrush;
		[FieldOffset(296)]
		public FSlateBrush ActiveFillBrush;
		[FieldOffset(440)]
		public FSlateBrush InactiveFillBrush;
		[FieldOffset(584)]
		public FSlateBrush ArrowsImage;
		[FieldOffset(728)]
		public FSlateColor ForegroundColor;
		[FieldOffset(768)]
		public FMargin TextPadding;
		
	}
	
}
#endif
#endif
