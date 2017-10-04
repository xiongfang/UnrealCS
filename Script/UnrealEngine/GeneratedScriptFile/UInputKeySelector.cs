using System;
namespace UnrealEngine
{
	public partial class UInputKeySelector:UWidget
	{
		/// <summary>Returns true if the widget is currently selecting a key, otherwise returns false.</summary>
		public extern bool GetIsSelectingKey();
		/// <summary>Sets whether or not modifier keys are allowed in the selected key.</summary>
		public extern void SetAllowModifierKeys(bool bInAllowModifierKeys);
		/// <summary>Sets the text which is displayed while selecting keys.</summary>
		public extern void SetKeySelectionText(FText InKeySelectionText);
		/// <summary>Sets the currently selected key.</summary>
		public extern void SetSelectedKey(FInputChord InSelectedKey);
		/// <summary>The currently selected key chord.</summary>
		public FInputChord SelectedKey;
		
		/// <summary>The font used to display the currently selected key.</summary>
		public FSlateFontInfo Font;
		
		/// <summary>The amount of blank space around the text used to display the currently selected key.</summary>
		public FMargin Margin;
		
		/// <summary>The color of the text used to display the currently selected key.</summary>
		public FLinearColor ColorAndOpacity;
		
		/// <summary>Sets the text which is displayed while selecting keys.</summary>
		public FText KeySelectionText;
		
		/// <summary>input chord representing the selected key, if false modifier keys are ignored.</summary>
		public bool bAllowModifierKeys;
		
		
	}
	
}
