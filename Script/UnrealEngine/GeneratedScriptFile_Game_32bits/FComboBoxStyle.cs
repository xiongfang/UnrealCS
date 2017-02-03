#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=920)]
	public partial struct FComboBoxStyle
	{
		[FieldOffset(8)]
		public FComboButtonStyle ComboButtonStyle;
		[FieldOffset(856)]
		public FSlateSound PressedSlateSound;
		[FieldOffset(880)]
		public FSlateSound SelectionChangeSlateSound;
		[FieldOffset(904)]
		public FName PressedSound;
		[FieldOffset(912)]
		public FName SelectionChangeSound;
		
	}
	
}
#endif
#endif
