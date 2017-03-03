#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SEditableText</summary>
	[StructLayout(LayoutKind.Explicit,Size=608)]
	public partial struct FEditableTextStyle
	{
		/// <summary>Font family and size to be used when displaying this text.</summary>
		[FieldOffset(8)]
		public FSlateFontInfo Font;
		/// <summary>The color and opacity of this text</summary>
		[FieldOffset(112)]
		public FSlateColor ColorAndOpacity;
		/// <summary>Background image for the selected text</summary>
		[FieldOffset(152)]
		public FSlateBrush BackgroundImageSelected;
		/// <summary>Background image for the selected text</summary>
		[FieldOffset(304)]
		public FSlateBrush BackgroundImageComposing;
		/// <summary>Image brush used for the caret</summary>
		[FieldOffset(456)]
		public FSlateBrush CaretImage;
		
	}
	
}
#endif
#endif
