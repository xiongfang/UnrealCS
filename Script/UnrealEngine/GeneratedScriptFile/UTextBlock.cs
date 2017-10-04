using System;
namespace UnrealEngine
{
	public partial class UTextBlock:UTextLayoutWidget
	{
		/// <summary>
		/// Directly sets the widget text.
		/// Warning: This will wipe any binding created for the Text property!
		/// @param InText The text to assign to the widget
		/// </summary>
		public extern virtual void SetText(FText InText);
		/// <summary>
		/// Gets the widget text
		/// @return The widget text
		/// </summary>
		public extern FText GetText();
		/// <summary>
		/// Set the minimum desired width for this text block
		/// @param InMinDesiredWidth new minimum desired width
		/// </summary>
		public extern void SetMinDesiredWidth(float InMinDesiredWidth);
		/// <summary>
		/// Set the text justification for this text block
		/// @param InJustification new justification
		/// </summary>
		public extern void SetJustification(ETextJustify InJustification);
		/// <summary>
		/// Dynamically set the font info for this text block
		/// @param InFontInfo THe new font info
		/// </summary>
		public extern void SetFont(FSlateFontInfo InFontInfo);
		/// <summary>
		/// Sets the offset that the text drop shadow should be drawn at
		/// @param InShadowOffset                The new offset
		/// </summary>
		public extern void SetShadowOffset(FVector2D InShadowOffset);
		/// <summary>
		/// Sets the color and opacity of the text drop shadow
		/// Note: if opacity is zero no shadow will be drawn
		/// @param InShadowColorAndOpacity               The new drop shadow color and opacity
		/// </summary>
		public extern void SetShadowColorAndOpacity(FLinearColor InShadowColorAndOpacity);
		/// <summary>
		/// Sets the opacity of the text in this text block
		/// @param InOpacity              The new text opacity
		/// </summary>
		public extern void SetOpacity(float InOpacity);
		/// <summary>
		/// Sets the color and opacity of the text in this text block
		/// @param InColorAndOpacity             The new text color and opacity
		/// </summary>
		public extern void SetColorAndOpacity(FSlateColor InColorAndOpacity);
		/// <summary>The text to display</summary>
		public FText Text;
		
		/// <summary>The color of the text</summary>
		public FSlateColor ColorAndOpacity;
		
		/// <summary>The font to render the text with</summary>
		public FSlateFontInfo Font;
		
		/// <summary>The direction the shadow is cast</summary>
		public FVector2D ShadowOffset;
		
		/// <summary>The color of the shadow</summary>
		public FLinearColor ShadowColorAndOpacity;
		
		/// <summary>The minimum desired size for the text</summary>
		public float MinDesiredWidth;
		
		/// <summary>If true, it will automatically wrap this text widget with an invalidation panel</summary>
		public bool bWrapWithInvalidationPanel;
		
		
	}
	
}
