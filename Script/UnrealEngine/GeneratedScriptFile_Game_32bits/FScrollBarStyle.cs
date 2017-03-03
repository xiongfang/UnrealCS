#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1048)]
	public partial struct FScrollBarStyle
	{
		[FieldOffset(4)]
		public FSlateBrush HorizontalBackgroundImage;
		[FieldOffset(120)]
		public FSlateBrush VerticalBackgroundImage;
		[FieldOffset(236)]
		public FSlateBrush VerticalTopSlotImage;
		[FieldOffset(352)]
		public FSlateBrush HorizontalTopSlotImage;
		[FieldOffset(468)]
		public FSlateBrush VerticalBottomSlotImage;
		[FieldOffset(584)]
		public FSlateBrush HorizontalBottomSlotImage;
		[FieldOffset(700)]
		public FSlateBrush NormalThumbImage;
		[FieldOffset(816)]
		public FSlateBrush HoveredThumbImage;
		[FieldOffset(932)]
		public FSlateBrush DraggedThumbImage;
		
	}
	
}
#endif
#endif
