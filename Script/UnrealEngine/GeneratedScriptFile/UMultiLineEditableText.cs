using System;
namespace UnrealEngine
{
	public partial class UMultiLineEditableText:UTextLayoutWidget
	{
		public extern void SetText(FText InText);
		public extern FText GetText();
		/// <summary>The text content for this editable text box widget</summary>
		public FText Text;
		
		/// <summary>Hint text that appears when there is no text in the text box</summary>
		public FText HintText;
		
		/// <summary>The style</summary>
		public FTextBlockStyle WidgetStyle;
		
		/// <summary>Font color and opacity (overrides Style)</summary>
		public FSlateFontInfo Font;
		
		/// <summary>Whether the context menu can be opened</summary>
		public bool AllowContextMenu;
		
		
	}
	
}
