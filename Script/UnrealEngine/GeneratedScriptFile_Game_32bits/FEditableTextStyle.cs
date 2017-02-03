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
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		[FieldOffset(56)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(88)]
		public FSlateBrush BackgroundImageSelected;
		[FieldOffset(208)]
		public FSlateBrush BackgroundImageComposing;
		[FieldOffset(328)]
		public FSlateBrush CaretImage;
		
	}
	
}
#endif
#endif
