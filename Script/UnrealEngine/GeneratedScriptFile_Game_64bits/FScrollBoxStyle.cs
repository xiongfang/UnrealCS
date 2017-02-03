#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=584)]
	public partial struct FScrollBoxStyle
	{
		[FieldOffset(8)]
		public FSlateBrush TopShadowBrush;
		[FieldOffset(152)]
		public FSlateBrush BottomShadowBrush;
		[FieldOffset(296)]
		public FSlateBrush LeftShadowBrush;
		[FieldOffset(440)]
		public FSlateBrush RightShadowBrush;
		
	}
	
}
#endif
#endif
