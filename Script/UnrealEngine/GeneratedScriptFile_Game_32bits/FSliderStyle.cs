#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=472)]
	public partial struct FSliderStyle
	{
		[FieldOffset(4)]
		public FSlateBrush NormalBarImage;
		[FieldOffset(120)]
		public FSlateBrush DisabledBarImage;
		[FieldOffset(236)]
		public FSlateBrush NormalThumbImage;
		[FieldOffset(352)]
		public FSlateBrush DisabledThumbImage;
		[FieldOffset(468)]
		public float BarThickness;
		
	}
	
}
#endif
#endif
