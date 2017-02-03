#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=496)]
	public partial struct FSliderStyle
	{
		[FieldOffset(8)]
		public FSlateBrush NormalBarImage;
		[FieldOffset(128)]
		public FSlateBrush DisabledBarImage;
		[FieldOffset(248)]
		public FSlateBrush NormalThumbImage;
		[FieldOffset(368)]
		public FSlateBrush DisabledThumbImage;
		[FieldOffset(488)]
		public float BarThickness;
		
	}
	
}
#endif
#endif
