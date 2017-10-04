using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SCheckBox</summary>
	public partial struct FCheckBoxStyle
	{
		/// <summary>The visual type of the checkbox</summary>
		public ESlateCheckBoxType CheckBoxType;
		/// <summary>CheckBox appearance when the CheckBox is unchecked (normal)</summary>
		public FSlateBrush UncheckedImage;
		/// <summary>CheckBox appearance when the CheckBox is unchecked and hovered</summary>
		public FSlateBrush UncheckedHoveredImage;
		/// <summary>CheckBox appearance when the CheckBox is unchecked and hovered</summary>
		public FSlateBrush UncheckedPressedImage;
		/// <summary>CheckBox appearance when the CheckBox is checked</summary>
		public FSlateBrush CheckedImage;
		/// <summary>CheckBox appearance when checked and hovered</summary>
		public FSlateBrush CheckedHoveredImage;
		/// <summary>CheckBox appearance when checked and pressed</summary>
		public FSlateBrush CheckedPressedImage;
		/// <summary>CheckBox appearance when the CheckBox is undetermined</summary>
		public FSlateBrush UndeterminedImage;
		/// <summary>CheckBox appearance when CheckBox is undetermined and hovered</summary>
		public FSlateBrush UndeterminedHoveredImage;
		/// <summary>CheckBox appearance when CheckBox is undetermined and pressed</summary>
		public FSlateBrush UndeterminedPressedImage;
		/// <summary>Padding</summary>
		public FMargin Padding;
		/// <summary>The foreground color</summary>
		public FSlateColor ForegroundColor;
		/// <summary>BorderBackgroundColor refers to the actual color and opacity of the supplied border image on toggle buttons</summary>
		public FSlateColor BorderBackgroundColor;
		/// <summary>The sound the check box should play when checked</summary>
		public FSlateSound CheckedSlateSound;
		/// <summary>The sound the check box should play when unchecked</summary>
		public FSlateSound UncheckedSlateSound;
		/// <summary>The sound the check box should play when initially hovered over</summary>
		public FSlateSound HoveredSlateSound;
		public FName CheckedSound;
		public FName UncheckedSound;
		public FName HoveredSound;
		
	}
	
}
