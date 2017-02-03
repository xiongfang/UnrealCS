#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=352)]
	public partial struct FProgressBarStyle
	{
		[FieldOffset(4)]
		public FSlateBrush BackgroundImage;
		[FieldOffset(120)]
		public FSlateBrush FillImage;
		[FieldOffset(236)]
		public FSlateBrush MarqueeImage;
		
	}
	
}
#endif
#endif
