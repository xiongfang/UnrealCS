#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1208)]
	public partial struct FCheckBoxStyle
	{
		[FieldOffset(4)]
		public ESlateCheckBoxType CheckBoxType;
		[FieldOffset(8)]
		public FSlateBrush UncheckedImage;
		[FieldOffset(124)]
		public FSlateBrush UncheckedHoveredImage;
		[FieldOffset(240)]
		public FSlateBrush UncheckedPressedImage;
		[FieldOffset(356)]
		public FSlateBrush CheckedImage;
		[FieldOffset(472)]
		public FSlateBrush CheckedHoveredImage;
		[FieldOffset(588)]
		public FSlateBrush CheckedPressedImage;
		[FieldOffset(704)]
		public FSlateBrush UndeterminedImage;
		[FieldOffset(820)]
		public FSlateBrush UndeterminedHoveredImage;
		[FieldOffset(936)]
		public FSlateBrush UndeterminedPressedImage;
		[FieldOffset(1052)]
		public FMargin Padding;
		[FieldOffset(1068)]
		public FSlateColor ForegroundColor;
		[FieldOffset(1096)]
		public FSlateColor BorderBackgroundColor;
		[FieldOffset(1124)]
		public FSlateSound CheckedSlateSound;
		[FieldOffset(1144)]
		public FSlateSound UncheckedSlateSound;
		[FieldOffset(1164)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(1184)]
		public FName CheckedSound;
		[FieldOffset(1192)]
		public FName UncheckedSound;
		[FieldOffset(1200)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
