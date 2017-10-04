using System;
namespace UnrealEngine
{
	public partial class UCheckBox:UContentWidget
	{
		/// <summary>Sets the checked state.</summary>
		public extern void SetIsChecked(bool InIsChecked);
		/// <summary>Returns true if the checkbox is currently checked</summary>
		public extern bool IsChecked();
		/// <summary>Returns true if this button is currently pressed</summary>
		public extern bool IsPressed();
		/// <summary>The checkbox bar style</summary>
		public FCheckBoxStyle WidgetStyle;
		
		/// <summary>Style of the check box</summary>
		public USlateWidgetStyleAsset Style;
		
		/// <summary>Image to use when the checkbox is unchecked</summary>
		public USlateBrushAsset UncheckedImage;
		
		/// <summary>Image to use when the checkbox is unchecked and hovered</summary>
		public USlateBrushAsset UncheckedHoveredImage;
		
		/// <summary>Image to use when the checkbox is unchecked and pressed</summary>
		public USlateBrushAsset UncheckedPressedImage;
		
		/// <summary>Image to use when the checkbox is checked</summary>
		public USlateBrushAsset CheckedImage;
		
		/// <summary>Image to use when the checkbox is checked and hovered</summary>
		public USlateBrushAsset CheckedHoveredImage;
		
		/// <summary>Image to use when the checkbox is checked and pressed</summary>
		public USlateBrushAsset CheckedPressedImage;
		
		/// <summary>Image to use when the checkbox is in an ambiguous state and hovered</summary>
		public USlateBrushAsset UndeterminedImage;
		
		/// <summary>Image to use when the checkbox is checked and hovered</summary>
		public USlateBrushAsset UndeterminedHoveredImage;
		
		/// <summary>Image to use when the checkbox is in an ambiguous state and pressed</summary>
		public USlateBrushAsset UndeterminedPressedImage;
		
		/// <summary>How the content of the toggle button should align within the given space</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>Spacing between the check box image and its content</summary>
		public FMargin Padding;
		
		/// <summary>The color of the background border</summary>
		public FSlateColor BorderBackgroundColor;
		
		/// <summary>Sometimes a button should only be mouse-clickable and never keyboard focusable.</summary>
		public bool IsFocusable;
		
		
	}
	
}
