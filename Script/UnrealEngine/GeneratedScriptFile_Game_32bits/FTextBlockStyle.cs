#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=272)]
	public partial struct FTextBlockStyle
	{
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		[FieldOffset(56)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(84)]
		public FVector2D ShadowOffset;
		[FieldOffset(92)]
		public FLinearColor ShadowColorAndOpacity;
		[FieldOffset(108)]
		public FSlateColor SelectedBackgroundColor;
		[FieldOffset(136)]
		public FLinearColor HighlightColor;
		[FieldOffset(152)]
		public FSlateBrush HighlightShape;
		
	}
	
}
#endif
#endif
