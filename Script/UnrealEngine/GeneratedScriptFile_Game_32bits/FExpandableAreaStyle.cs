#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=240)]
	public partial struct FExpandableAreaStyle
	{
		[FieldOffset(4)]
		public FSlateBrush CollapsedImage;
		[FieldOffset(120)]
		public FSlateBrush ExpandedImage;
		[FieldOffset(236)]
		public float RolloutAnimationSeconds;
		
	}
	
}
#endif
#endif
