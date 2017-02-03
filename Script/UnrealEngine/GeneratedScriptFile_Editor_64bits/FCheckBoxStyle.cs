#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SCheckBox</summary>
	[StructLayout(LayoutKind.Explicit,Size=1616)]
	public partial struct FCheckBoxStyle
	{
		/// <summary>The visual type of the checkbox</summary>
		[FieldOffset(8)]
		public ESlateCheckBoxType CheckBoxType;
		/// <summary>CheckBox appearance when the CheckBox is unchecked (normal)</summary>
		[FieldOffset(16)]
		public FSlateBrush UncheckedImage;
		/// <summary>CheckBox appearance when the CheckBox is unchecked and hovered</summary>
		[FieldOffset(168)]
		public FSlateBrush UncheckedHoveredImage;
		/// <summary>CheckBox appearance when the CheckBox is unchecked and hovered</summary>
		[FieldOffset(320)]
		public FSlateBrush UncheckedPressedImage;
		/// <summary>CheckBox appearance when the CheckBox is checked</summary>
		[FieldOffset(472)]
		public FSlateBrush CheckedImage;
		/// <summary>CheckBox appearance when checked and hovered</summary>
		[FieldOffset(624)]
		public FSlateBrush CheckedHoveredImage;
		/// <summary>CheckBox appearance when checked and pressed</summary>
		[FieldOffset(776)]
		public FSlateBrush CheckedPressedImage;
		/// <summary>CheckBox appearance when the CheckBox is undetermined</summary>
		[FieldOffset(928)]
		public FSlateBrush UndeterminedImage;
		/// <summary>CheckBox appearance when CheckBox is undetermined and hovered</summary>
		[FieldOffset(1080)]
		public FSlateBrush UndeterminedHoveredImage;
		/// <summary>CheckBox appearance when CheckBox is undetermined and pressed</summary>
		[FieldOffset(1232)]
		public FSlateBrush UndeterminedPressedImage;
		/// <summary>Padding</summary>
		[FieldOffset(1384)]
		public FMargin Padding;
		/// <summary>The foreground color</summary>
		[FieldOffset(1400)]
		public FSlateColor ForegroundColor;
		/// <summary>BorderBackgroundColor refers to the actual color and opacity of the supplied border image on toggle buttons</summary>
		[FieldOffset(1440)]
		public FSlateColor BorderBackgroundColor;
		/// <summary>The sound the check box should play when checked</summary>
		[FieldOffset(1480)]
		public FSlateSound CheckedSlateSound;
		/// <summary>The sound the check box should play when unchecked</summary>
		[FieldOffset(1512)]
		public FSlateSound UncheckedSlateSound;
		/// <summary>The sound the check box should play when initially hovered over</summary>
		[FieldOffset(1544)]
		public FSlateSound HoveredSlateSound;
		[FieldOffset(1576)]
		public FName CheckedSound;
		[FieldOffset(1588)]
		public FName UncheckedSound;
		[FieldOffset(1600)]
		public FName HoveredSound;
		
	}
	
}
#endif
#endif
