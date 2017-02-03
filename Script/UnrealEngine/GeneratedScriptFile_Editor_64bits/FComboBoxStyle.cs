#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SComboBox</summary>
	[StructLayout(LayoutKind.Explicit,Size=1160)]
	public partial struct FComboBoxStyle
	{
		/// <summary>The style to use for our SComboButton</summary>
		[FieldOffset(8)]
		public FComboButtonStyle ComboButtonStyle;
		/// <summary>The sound the button should play when pressed</summary>
		[FieldOffset(1072)]
		public FSlateSound PressedSlateSound;
		/// <summary>The Sound to play when the selection is changed</summary>
		[FieldOffset(1104)]
		public FSlateSound SelectionChangeSlateSound;
		[FieldOffset(1136)]
		public FName PressedSound;
		[FieldOffset(1148)]
		public FName SelectionChangeSound;
		
	}
	
}
#endif
#endif
