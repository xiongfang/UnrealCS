using System;
namespace UnrealEngine
{
	public partial class UEditableText:UWidget
	{
		public extern void SetIsReadOnly(bool InbIsReadyOnly);
		public extern void SetHintText(FText InHintText);
		public extern void SetIsPassword(bool InbIsPassword);
		/// <summary>
		/// Directly sets the widget text.
		/// Warning: This will wipe any binding created for the Text property!
		/// @param InText The text to assign to the widget
		/// </summary>
		public extern void SetText(FText InText);
		/// <summary>
		/// Gets the widget text
		/// @return The widget text
		/// </summary>
		public extern FText GetText();
		/// <summary>The text content for this editable text box widget</summary>
		public FText Text;
		
		/// <summary>Hint text that appears when there is no text in the text box</summary>
		public FText HintText;
		
		/// <summary>The style</summary>
		public FEditableTextStyle WidgetStyle;
		
		/// <summary>Text style</summary>
		public USlateWidgetStyleAsset Style;
		
		/// <summary>Background image for the selected text (overrides Style)</summary>
		public USlateBrushAsset BackgroundImageSelected;
		
		/// <summary>Background image for the composing text (overrides Style)</summary>
		public USlateBrushAsset BackgroundImageComposing;
		
		/// <summary>Image brush used for the caret (overrides Style)</summary>
		public USlateBrushAsset CaretImage;
		
		/// <summary>Font color and opacity (overrides Style)</summary>
		public FSlateFontInfo Font;
		
		/// <summary>Text color and opacity (overrides Style)</summary>
		public FSlateColor ColorAndOpacity;
		
		/// <summary>Sets whether this text box can actually be modified interactively by the user</summary>
		public bool IsReadOnly;
		
		/// <summary>Sets whether this text box is for storing a password</summary>
		public bool IsPassword;
		
		/// <summary>Minimum width that a text block should be</summary>
		public float MinimumDesiredWidth;
		
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
