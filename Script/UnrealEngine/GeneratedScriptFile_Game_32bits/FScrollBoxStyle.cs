#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=488)]
	public partial struct FScrollBoxStyle
	{
		[FieldOffset(8)]
		public FSlateBrush TopShadowBrush;
		[FieldOffset(128)]
		public FSlateBrush BottomShadowBrush;
		[FieldOffset(248)]
		public FSlateBrush LeftShadowBrush;
		[FieldOffset(368)]
		public FSlateBrush RightShadowBrush;
		
	}
	
}
#endif
#endif
