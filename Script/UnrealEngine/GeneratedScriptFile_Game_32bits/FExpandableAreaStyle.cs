#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=248)]
	public partial struct FExpandableAreaStyle
	{
		[FieldOffset(8)]
		public FSlateBrush CollapsedImage;
		[FieldOffset(128)]
		public FSlateBrush ExpandedImage;
		
	}
	
}
#endif
#endif
