#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1088)]
	public partial struct FScrollBarStyle
	{
		[FieldOffset(8)]
		public FSlateBrush HorizontalBackgroundImage;
		[FieldOffset(128)]
		public FSlateBrush VerticalBackgroundImage;
		[FieldOffset(248)]
		public FSlateBrush VerticalTopSlotImage;
		[FieldOffset(368)]
		public FSlateBrush HorizontalTopSlotImage;
		[FieldOffset(488)]
		public FSlateBrush VerticalBottomSlotImage;
		[FieldOffset(608)]
		public FSlateBrush HorizontalBottomSlotImage;
		[FieldOffset(728)]
		public FSlateBrush NormalThumbImage;
		[FieldOffset(848)]
		public FSlateBrush HoveredThumbImage;
		[FieldOffset(968)]
		public FSlateBrush DraggedThumbImage;
		
	}
	
}
#endif
#endif
