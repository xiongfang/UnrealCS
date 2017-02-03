#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=584)]
	public partial struct FButtonStyle
	{
		[FieldOffset(8)]
		public FSlateBrush Normal;
		[FieldOffset(128)]
		public FSlateBrush Hovered;
		[FieldOffset(248)]
		public FSlateBrush Pressed;
		[FieldOffset(368)]
		public FSlateBrush Disabled;
		[FieldOffset(488)]
		public FMargin NormalPadding;
		[FieldOffset(504)]
		public FMargin PressedPadding;
		[FieldOffset(520)]
		public FSlateSound PressedSlateSound;
		[FieldOffset(544)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(568)]
		public FName PressedSound;
		[FieldOffset(576)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
