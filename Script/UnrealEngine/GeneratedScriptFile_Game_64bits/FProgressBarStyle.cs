#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=440)]
	public partial struct FProgressBarStyle
	{
		[FieldOffset(8)]
		public FSlateBrush BackgroundImage;
		[FieldOffset(152)]
		public FSlateBrush FillImage;
		[FieldOffset(296)]
		public FSlateBrush MarqueeImage;
		
	}
	
}
#endif
#endif
