#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=400)]
	public partial struct FTextBlockStyle
	{
		[FieldOffset(4)]
		public FSlateFontInfo Font;
		[FieldOffset(72)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(100)]
		public FVector2D ShadowOffset;
		[FieldOffset(108)]
		public FLinearColor ShadowColorAndOpacity;
		[FieldOffset(124)]
		public FSlateColor SelectedBackgroundColor;
		[FieldOffset(152)]
		public FLinearColor HighlightColor;
		[FieldOffset(168)]
		public FSlateBrush HighlightShape;
		[FieldOffset(284)]
		public FSlateBrush UnderlineBrush;
		
	}
	
}
#endif
#endif
