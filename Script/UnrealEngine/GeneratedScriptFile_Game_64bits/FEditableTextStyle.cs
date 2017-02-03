#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=544)]
	public partial struct FEditableTextStyle
	{
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		[FieldOffset(72)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(112)]
		public FSlateBrush BackgroundImageSelected;
		[FieldOffset(256)]
		public FSlateBrush BackgroundImageComposing;
		[FieldOffset(400)]
		public FSlateBrush CaretImage;
		
	}
	
}
#endif
#endif
