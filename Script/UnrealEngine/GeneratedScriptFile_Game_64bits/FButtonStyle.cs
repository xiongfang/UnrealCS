#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=680)]
	public partial struct FButtonStyle
	{
		[FieldOffset(8)]
		public FSlateBrush Normal;
		[FieldOffset(152)]
		public FSlateBrush Hovered;
		[FieldOffset(296)]
		public FSlateBrush Pressed;
		[FieldOffset(440)]
		public FSlateBrush Disabled;
		[FieldOffset(584)]
		public FMargin NormalPadding;
		[FieldOffset(600)]
		public FMargin PressedPadding;
		[FieldOffset(616)]
		public FSlateSound PressedSlateSound;
		[FieldOffset(640)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(664)]
		public FName PressedSound;
		[FieldOffset(672)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
