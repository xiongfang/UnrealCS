using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SComboBox</summary>
	public partial struct FComboBoxStyle
	{
		/// <summary>The style to use for our SComboButton</summary>
		public FComboButtonStyle ComboButtonStyle;
		/// <summary>The sound the button should play when pressed</summary>
		public FSlateSound PressedSlateSound;
		/// <summary>The Sound to play when the selection is changed</summary>
		public FSlateSound SelectionChangeSlateSound;
		public FName PressedSound;
		public FName SelectionChangeSound;
		
	}
	
}
