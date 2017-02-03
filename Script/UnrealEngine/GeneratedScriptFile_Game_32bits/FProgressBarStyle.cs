#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=368)]
	public partial struct FProgressBarStyle
	{
		[FieldOffset(8)]
		public FSlateBrush BackgroundImage;
		[FieldOffset(128)]
		public FSlateBrush FillImage;
		[FieldOffset(248)]
		public FSlateBrush MarqueeImage;
		
	}
	
}
#endif
#endif
