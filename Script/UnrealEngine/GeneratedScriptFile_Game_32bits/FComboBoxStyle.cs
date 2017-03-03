#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=868)]
	public partial struct FComboBoxStyle
	{
		[FieldOffset(4)]
		public FComboButtonStyle ComboButtonStyle;
		[FieldOffset(812)]
		public FSlateSound PressedSlateSound;
		[FieldOffset(832)]
		public FSlateSound SelectionChangeSlateSound;
		[FieldOffset(852)]
		public FName PressedSound;
		[FieldOffset(860)]
		public FName SelectionChangeSound;
		
	}
	
}
#endif
#endif
