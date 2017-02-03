#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=236)]
	public partial struct FExpandableAreaStyle
	{
		[FieldOffset(4)]
		public FSlateBrush CollapsedImage;
		[FieldOffset(120)]
		public FSlateBrush ExpandedImage;
		
	}
	
}
#endif
#endif
