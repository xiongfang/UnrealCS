#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=448)]
	public partial struct FEditableTextStyle
	{
		[FieldOffset(4)]
		public FSlateFontInfo Font;
		[FieldOffset(72)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(100)]
		public FSlateBrush BackgroundImageSelected;
		[FieldOffset(216)]
		public FSlateBrush BackgroundImageComposing;
		[FieldOffset(332)]
		public FSlateBrush CaretImage;
		
	}
	
}
#endif
#endif
