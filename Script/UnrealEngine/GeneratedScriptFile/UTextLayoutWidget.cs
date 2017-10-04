using System;
namespace UnrealEngine
{
	public partial class UTextLayoutWidget:UWidget
	{
		/// <summary>Controls how the text within this widget should be shaped.</summary>
		public FShapedTextOptions ShapedTextOptions;
		
		/// <summary>How the text should be aligned with the margin.</summary>
		public ETextJustify Justification;
		
		/// <summary>True if we're wrapping text automatically based on the computed horizontal space for this widget.</summary>
		public bool AutoWrapText;
		
		/// <summary>Whether text wraps onto a new line when it's length exceeds this width; if this value is zero or negative, no wrapping occurs.</summary>
		public float WrapTextAt;
		
		/// <summary>The amount of blank space left around the edges of text area.</summary>
		public FMargin Margin;
		
		/// <summary>The amount to scale each lines height by.</summary>
		public float LineHeightPercentage;
		
		
	}
	
}
