#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=584)]
	public partial struct FEditableTextStyle
	{
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		[FieldOffset(112)]
		public FSlateColor ColorAndOpacity;
		[FieldOffset(152)]
		public FSlateBrush BackgroundImageSelected;
		[FieldOffset(296)]
		public FSlateBrush BackgroundImageComposing;
		[FieldOffset(440)]
		public FSlateBrush CaretImage;
		
	}
	
}
#endif
#endif
