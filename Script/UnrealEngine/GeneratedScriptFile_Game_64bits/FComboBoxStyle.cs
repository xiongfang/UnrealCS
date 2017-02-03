#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1064)]
	public partial struct FComboBoxStyle
	{
		[FieldOffset(8)]
		public FComboButtonStyle ComboButtonStyle;
		[FieldOffset(1000)]
		public FSlateSound PressedSlateSound;
		[FieldOffset(1024)]
		public FSlateSound SelectionChangeSlateSound;
		[FieldOffset(1048)]
		public FName PressedSound;
		[FieldOffset(1056)]
		public FName SelectionChangeSound;
		
	}
	
}
#endif
#endif
