#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=468)]
	public partial struct FScrollBoxStyle
	{
		[FieldOffset(4)]
		public FSlateBrush TopShadowBrush;
		[FieldOffset(120)]
		public FSlateBrush BottomShadowBrush;
		[FieldOffset(236)]
		public FSlateBrush LeftShadowBrush;
		[FieldOffset(352)]
		public FSlateBrush RightShadowBrush;
		
	}
	
}
#endif
#endif
