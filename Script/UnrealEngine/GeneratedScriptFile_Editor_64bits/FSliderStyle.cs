#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SSlider</summary>
	[StructLayout(LayoutKind.Explicit,Size=624)]
	public partial struct FSliderStyle
	{
		/// <summary>Image to use when the slider bar is in its normal state</summary>
		[FieldOffset(8)]
		public FSlateBrush NormalBarImage;
		/// <summary>Image to use when the slider bar is in its disabled state</summary>
		[FieldOffset(160)]
		public FSlateBrush DisabledBarImage;
		/// <summary>Image to use when the slider thumb is in its normal state</summary>
		[FieldOffset(312)]
		public FSlateBrush NormalThumbImage;
		/// <summary>Image to use when the slider thumb is in its disabled state</summary>
		[FieldOffset(464)]
		public FSlateBrush DisabledThumbImage;
		[FieldOffset(616)]
		public float BarThickness;
		
	}
	
}
#endif
#endif
