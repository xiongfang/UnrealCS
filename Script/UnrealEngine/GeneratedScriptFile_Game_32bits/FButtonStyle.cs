#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=556)]
	public partial struct FButtonStyle
	{
		[FieldOffset(4)]
		public FSlateBrush Normal;
		[FieldOffset(120)]
		public FSlateBrush Hovered;
		[FieldOffset(236)]
		public FSlateBrush Pressed;
		[FieldOffset(352)]
		public FSlateBrush Disabled;
		[FieldOffset(468)]
		public FMargin NormalPadding;
		[FieldOffset(484)]
		public FMargin PressedPadding;
		[FieldOffset(500)]
		public FSlateSound PressedSlateSound;
		[FieldOffset(520)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(540)]
		public FName PressedSound;
		[FieldOffset(548)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
