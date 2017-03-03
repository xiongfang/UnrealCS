#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=304)]
	public partial struct FExpandableAreaStyle
	{
		[FieldOffset(8)]
		public FSlateBrush CollapsedImage;
		[FieldOffset(152)]
		public FSlateBrush ExpandedImage;
		[FieldOffset(296)]
		public float RolloutAnimationSeconds;
		
	}
	
}
#endif
#endif
