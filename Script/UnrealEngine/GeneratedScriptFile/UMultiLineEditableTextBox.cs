using System;
namespace UnrealEngine
{
	public partial class UMultiLineEditableTextBox:UTextLayoutWidget
	{
		public extern void SetError(FText InError);
		public extern void SetText(FText InText);
		public extern FText GetText();
		/// <summary>The text content for this editable text box widget</summary>
		public FText Text;
		
		/// <summary>Hint text that appears when there is no text in the text box</summary>
		public FText HintText;
		
		/// <summary>The style</summary>
		public FEditableTextBoxStyle WidgetStyle;
		
		/// <summary>The text style</summary>
		public FTextBlockStyle TextStyle;
		
		/// <summary>Whether the context menu can be opened</summary>
		public bool AllowContextMenu;
		
		public USlateWidgetStyleAsset Style;
		
		/// <summary>Font color and opacity (overrides Style)</summary>
		public FSlateFontInfo Font;
		
		/// <summary>Text color and opacity (overrides Style)</summary>
		public FLinearColor ForegroundColor;
		
		/// <summary>The color of the background/border around the editable text (overrides Style)</summary>
		public FLinearColor BackgroundColor;
		
		/// <summary>Text color and opacity when read-only (overrides Style)</summary>
		public FLinearColor ReadOnlyForegroundColor;
		
		
	}
	
}
