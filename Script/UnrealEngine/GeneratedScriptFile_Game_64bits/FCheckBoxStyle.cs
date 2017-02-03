#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1504)]
	public partial struct FCheckBoxStyle
	{
		[FieldOffset(8)]
		public ESlateCheckBoxType CheckBoxType;
		[FieldOffset(16)]
		public FSlateBrush UncheckedImage;
		[FieldOffset(160)]
		public FSlateBrush UncheckedHoveredImage;
		[FieldOffset(304)]
		public FSlateBrush UncheckedPressedImage;
		[FieldOffset(448)]
		public FSlateBrush CheckedImage;
		[FieldOffset(592)]
		public FSlateBrush CheckedHoveredImage;
		[FieldOffset(736)]
		public FSlateBrush CheckedPressedImage;
		[FieldOffset(880)]
		public FSlateBrush UndeterminedImage;
		[FieldOffset(1024)]
		public FSlateBrush UndeterminedHoveredImage;
		[FieldOffset(1168)]
		public FSlateBrush UndeterminedPressedImage;
		[FieldOffset(1312)]
		public FMargin Padding;
		[FieldOffset(1328)]
		public FSlateColor ForegroundColor;
		[FieldOffset(1368)]
		public FSlateColor BorderBackgroundColor;
		[FieldOffset(1408)]
		public FSlateSound CheckedSlateSound;
		[FieldOffset(1432)]
		public FSlateSound UncheckedSlateSound;
		[FieldOffset(1456)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(1480)]
		public FName CheckedSound;
		[FieldOffset(1488)]
		public FName UncheckedSound;
		[FieldOffset(1496)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
