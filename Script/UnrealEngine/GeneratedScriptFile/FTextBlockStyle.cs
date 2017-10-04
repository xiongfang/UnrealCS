using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an STextBlock</summary>
	public partial struct FTextBlockStyle
	{
		/// <summary>Font family and size to be used when displaying this text.</summary>
		public FSlateFontInfo Font;
		/// <summary>The color and opacity of this text</summary>
		public FSlateColor ColorAndOpacity;
		/// <summary>How much should the shadow be offset? An offset of 0 implies no shadow.</summary>
		public FVector2D ShadowOffset;
		/// <summary>The color and opacity of the shadow</summary>
		public FLinearColor ShadowColorAndOpacity;
		/// <summary>The background color of selected text</summary>
		public FSlateColor SelectedBackgroundColor;
		/// <summary>The color of highlighted text</summary>
		public FLinearColor HighlightColor;
		/// <summary>The shape of highlighted text</summary>
		public FSlateBrush HighlightShape;
		/// <summary>The brush used to draw an underline under the text (if any)</summary>
		public FSlateBrush UnderlineBrush;
		
	}
	
}
