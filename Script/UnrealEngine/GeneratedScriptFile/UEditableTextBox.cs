using System;
namespace UnrealEngine
{
	public partial class UEditableTextBox:UWidget
	{
		public extern bool HasError();
		public extern void ClearError();
		public extern void SetError(FText InError);
		public extern void SetText(FText InText);
		public extern FText GetText();
		/// <summary>The text content for this editable text box widget</summary>
		public FText Text;
		
		/// <summary>The style</summary>
		public FEditableTextBoxStyle WidgetStyle;
		
		/// <summary>Style used for the text box</summary>
		public USlateWidgetStyleAsset Style;
		
		/// <summary>Hint text that appears when there is no text in the text box</summary>
		public FText HintText;
		
		/// <summary>Font color and opacity (overrides Style)</summary>
		public FSlateFontInfo Font;
		
		/// <summary>Text color and opacity (overrides Style)</summary>
		public FLinearColor ForegroundColor;
		
		/// <summary>The color of the background/border around the editable text (overrides Style)</summary>
		public FLinearColor BackgroundColor;
		
		/// <summary>Text color and opacity when read-only (overrides Style)</summary>
		public FLinearColor ReadOnlyForegroundColor;
		
		/// <summary>Sets whether this text box can actually be modified interactively by the user</summary>
		public bool IsReadOnly;
		
		/// <summary>Sets whether this text box is for storing a password</summary>
		public bool IsPassword;
		
		/// <summary>Minimum width that a text block should be</summary>
		public float MinimumDesiredWidth;
		
		/// <summary>Padding between the box/border and the text widget inside (overrides Style)</summary>
		public FMargin Padding;
		
		/// <summary>Workaround as we lose focus when the auto completion closes.</summary>
		public bool IsCaretMovedWhenGainFocus;
		
		/// <summary>Whether to select all text when the user clicks to give focus on the widget</summary>
		public bool SelectAllTextWhenFocused;
		
		/// <summary>Whether to allow the user to back out of changes when they press the escape key</summary>
		public bool RevertTextOnEscape;
		
		/// <summary>Whether to clear keyboard focus when pressing enter to commit changes</summary>
		public bool ClearKeyboardFocusOnCommit;
		
		/// <summary>Whether to select all text when pressing enter to commit changes</summary>
		public bool SelectAllTextOnCommit;
		
		/// <summary>Whether the context menu can be opened</summary>
		public bool AllowContextMenu;
		
		/// <summary>If we're on a platform that requires a virtual keyboard, what kind of keyboard should this widget use?</summary>
		public EVirtualKeyboardType KeyboardType;
		
		/// <summary>Controls how the text within this widget should be shaped.</summary>
		public FShapedTextOptions ShapedTextOptions;
		
		
	}
	
}
