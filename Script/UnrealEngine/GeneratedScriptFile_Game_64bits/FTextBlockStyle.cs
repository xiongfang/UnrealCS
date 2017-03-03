#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=520)]
	public partial struct FTextBlockStyle
	{
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		[FieldOffset(112)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(152)]
		public FVector2D ShadowOffset;
		[FieldOffset(160)]
		public FLinearColor ShadowColorAndOpacity;
		[FieldOffset(176)]
		public FSlateColor SelectedBackgroundColor;
		[FieldOffset(216)]
		public FLinearColor HighlightColor;
		[FieldOffset(232)]
		public FSlateBrush HighlightShape;
		[FieldOffset(376)]
		public FSlateBrush UnderlineBrush;
		
	}
	
}
#endif
#endif
