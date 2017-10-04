using System;
namespace UnrealEngine
{
	public partial class UBorder:UContentWidget
	{
		/// <summary>
		/// Sets the DesireSizeScale of this border.
		/// @param InScale    The X and Y multipliers for the desired size
		/// </summary>
		public extern void SetDesiredSizeScale(FVector2D InScale);
		public extern UMaterialInstanceDynamic GetDynamicMaterial();
		public extern void SetBrushFromMaterial(UMaterialInterface Material);
		public extern void SetBrushFromTexture(UTexture2D Texture);
		public extern void SetBrushFromAsset(USlateBrushAsset Asset);
		public extern void SetBrush(FSlateBrush InBrush);
		public extern void SetBrushColor(FLinearColor InBrushColor);
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		public extern void SetPadding(FMargin InPadding);
		public extern void SetContentColorAndOpacity(FLinearColor InContentColorAndOpacity);
		/// <summary>Color and opacity multiplier of content in the border</summary>
		public FLinearColor ContentColorAndOpacity;
		
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding;
		
		/// <summary>The alignment of the content horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>The alignment of the content vertically.</summary>
		public EVerticalAlignment VerticalAlignment;
		
		/// <summary>Brush to drag as the background</summary>
		public FSlateBrush Background;
		
		/// <summary>Color and opacity of the actual border image</summary>
		public FLinearColor BrushColor;
		
		/// <summary>
		/// Scales the computed desired size of this border and its contents. Useful
		/// for making things that slide open without having to hard-code their size.
		/// Note: if the parent widget is set up to ignore this widget's desired size,
		/// then changing this value will have no effect.
		/// </summary>
		public FVector2D DesiredSizeScale;
		
		/// <summary>Whether or not to show the disabled effect when this border is disabled</summary>
		public bool bShowEffectWhenDisabled;
		
		/// <summary>Image to use for the border</summary>
		public USlateBrushAsset Brush;
		
		
	}
	
}
