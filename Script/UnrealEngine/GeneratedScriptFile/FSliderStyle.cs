using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SSlider</summary>
	public partial struct FSliderStyle
	{
		/// <summary>Image to use when the slider bar is in its normal state</summary>
		public FSlateBrush NormalBarImage;
		/// <summary>Image to use when the slider bar is in its disabled state</summary>
		public FSlateBrush DisabledBarImage;
		/// <summary>Image to use when the slider thumb is in its normal state</summary>
		public FSlateBrush NormalThumbImage;
		/// <summary>Image to use when the slider thumb is in its disabled state</summary>
		public FSlateBrush DisabledThumbImage;
		public float BarThickness;
		
	}
	
}
