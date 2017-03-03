#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an STextBlock</summary>
	[StructLayout(LayoutKind.Explicit,Size=536)]
	public partial struct FTextBlockStyle
	{
		/// <summary>Font family and size to be used when displaying this text.</summary>
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		/// <summary>The color and opacity of this text</summary>
		[FieldOffset(112)]
		public FSlateColor ColorAndOpacity;
		/// <summary>How much should the shadow be offset? An offset of 0 implies no shadow.</summary>
		[FieldOffset(152)]
		public FVector2D ShadowOffset;
		/// <summary>The color and opacity of the shadow</summary>
		[FieldOffset(160)]
		public FLinearColor ShadowColorAndOpacity;
		/// <summary>The background color of selected text</summary>
		[FieldOffset(176)]
		public FSlateColor SelectedBackgroundColor;
		/// <summary>The color of highlighted text</summary>
		[FieldOffset(216)]
		public FLinearColor HighlightColor;
		/// <summary>The shape of highlighted text</summary>
		[FieldOffset(232)]
		public FSlateBrush HighlightShape;
		/// <summary>The brush used to draw an underline under the text (if any)</summary>
		[FieldOffset(384)]
		public FSlateBrush UnderlineBrush;
		
	}
	
}
#endif
#endif
