#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=592)]
	public partial struct FSliderStyle
	{
		[FieldOffset(8)]
		public FSlateBrush NormalBarImage;
		[FieldOffset(152)]
		public FSlateBrush DisabledBarImage;
		[FieldOffset(296)]
		public FSlateBrush NormalThumbImage;
		[FieldOffset(440)]
		public FSlateBrush DisabledThumbImage;
		[FieldOffset(584)]
		public float BarThickness;
		
	}
	
}
#endif
#endif
