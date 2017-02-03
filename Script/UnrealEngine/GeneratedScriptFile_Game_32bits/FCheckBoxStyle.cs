#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1256)]
	public partial struct FCheckBoxStyle
	{
		[FieldOffset(4)]
		public ESlateCheckBoxType CheckBoxType;
		[FieldOffset(8)]
		public FSlateBrush UncheckedImage;
		[FieldOffset(128)]
		public FSlateBrush UncheckedHoveredImage;
		[FieldOffset(248)]
		public FSlateBrush UncheckedPressedImage;
		[FieldOffset(368)]
		public FSlateBrush CheckedImage;
		[FieldOffset(488)]
		public FSlateBrush CheckedHoveredImage;
		[FieldOffset(608)]
		public FSlateBrush CheckedPressedImage;
		[FieldOffset(728)]
		public FSlateBrush UndeterminedImage;
		[FieldOffset(848)]
		public FSlateBrush UndeterminedHoveredImage;
		[FieldOffset(968)]
		public FSlateBrush UndeterminedPressedImage;
		[FieldOffset(1088)]
		public FMargin Padding;
		[FieldOffset(1104)]
		public FSlateColor ForegroundColor;
		[FieldOffset(1132)]
		public FSlateColor BorderBackgroundColor;
		[FieldOffset(1160)]
		public FSlateSound CheckedSlateSound;
		[FieldOffset(1184)]
		public FSlateSound UncheckedSlateSound;
		[FieldOffset(1208)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(1232)]
		public FName CheckedSound;
		[FieldOffset(1240)]
		public FName UncheckedSound;
		[FieldOffset(1248)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
