#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=336)]
	public partial struct FTextBlockStyle
	{
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		[FieldOffset(72)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(112)]
		public FVector2D ShadowOffset;
		[FieldOffset(120)]
		public FLinearColor ShadowColorAndOpacity;
		[FieldOffset(136)]
		public FSlateColor SelectedBackgroundColor;
		[FieldOffset(176)]
		public FLinearColor HighlightColor;
		[FieldOffset(192)]
		public FSlateBrush HighlightShape;
		
	}
	
}
#endif
#endif
