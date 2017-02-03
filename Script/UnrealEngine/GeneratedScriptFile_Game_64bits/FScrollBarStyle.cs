#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1304)]
	public partial struct FScrollBarStyle
	{
		[FieldOffset(8)]
		public FSlateBrush HorizontalBackgroundImage;
		[FieldOffset(152)]
		public FSlateBrush VerticalBackgroundImage;
		[FieldOffset(296)]
		public FSlateBrush VerticalTopSlotImage;
		[FieldOffset(440)]
		public FSlateBrush HorizontalTopSlotImage;
		[FieldOffset(584)]
		public FSlateBrush VerticalBottomSlotImage;
		[FieldOffset(728)]
		public FSlateBrush HorizontalBottomSlotImage;
		[FieldOffset(872)]
		public FSlateBrush NormalThumbImage;
		[FieldOffset(1016)]
		public FSlateBrush HoveredThumbImage;
		[FieldOffset(1160)]
		public FSlateBrush DraggedThumbImage;
		
	}
	
}
#endif
#endif
