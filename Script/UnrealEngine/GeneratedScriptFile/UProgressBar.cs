using System;
namespace UnrealEngine
{
	public partial class UProgressBar:UWidget
	{
		/// <summary>Sets the progress bar to show as a marquee.</summary>
		public extern void SetIsMarquee(bool InbIsMarquee);
		/// <summary>Sets the fill color of the progress bar.</summary>
		public extern void SetFillColorAndOpacity(FLinearColor InColor);
		/// <summary>Sets the current value of the ProgressBar.</summary>
		public extern void SetPercent(float InPercent);
		/// <summary>The progress bar style</summary>
		public FProgressBarStyle WidgetStyle;
		
		/// <summary>Style used for the progress bar</summary>
		public USlateWidgetStyleAsset Style;
		
		/// <summary>The brush to use as the background of the progress bar</summary>
		public USlateBrushAsset BackgroundImage;
		
		/// <summary>The brush to use as the fill image</summary>
		public USlateBrushAsset FillImage;
		
		/// <summary>The brush to use as the marquee image</summary>
		public USlateBrushAsset MarqueeImage;
		
		/// <summary>Used to determine the fill position of the progress bar ranging 0..1</summary>
		public float Percent;
		
		/// <summary>Defines if this progress bar fills Left to right or right to left</summary>
		public EProgressBarFillType BarFillType;
		
		public bool bIsMarquee;
		
		/// <summary>Fill Color and Opacity</summary>
		public FLinearColor FillColorAndOpacity;
		
		
	}
	
}
