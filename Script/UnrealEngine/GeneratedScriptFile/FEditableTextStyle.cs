using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SEditableText</summary>
	public partial struct FEditableTextStyle
	{
		/// <summary>Font family and size to be used when displaying this text.</summary>
		public FSlateFontInfo Font;
		/// <summary>The color and opacity of this text</summary>
		public FSlateColor ColorAndOpacity;
		/// <summary>Background image for the selected text</summary>
		public FSlateBrush BackgroundImageSelected;
		/// <summary>Background image for the selected text</summary>
		public FSlateBrush BackgroundImageComposing;
		/// <summary>Image brush used for the caret</summary>
		public FSlateBrush CaretImage;
		
	}
	
}
