using System;
namespace UnrealEngine
{
	public partial class UImage:UWidget
	{
		public extern UMaterialInstanceDynamic GetDynamicMaterial();
		public extern void SetBrushFromMaterial(UMaterialInterface Material);
		public extern void SetBrushFromTextureDynamic(UTexture2DDynamic Texture,bool bMatchSize=false);
		public extern void SetBrushFromTexture(UTexture2D Texture,bool bMatchSize=false);
		public extern void SetBrushFromAsset(USlateBrushAsset Asset);
		public extern void SetBrush(FSlateBrush InBrush);
		public extern void SetOpacity(float InOpacity);
		public extern void SetColorAndOpacity(FLinearColor InColorAndOpacity);
		/// <summary>Image to draw</summary>
		public USlateBrushAsset Image;
		
		/// <summary>Image to draw</summary>
		public FSlateBrush Brush;
		
		/// <summary>Color and opacity</summary>
		public FLinearColor ColorAndOpacity;
		
		
	}
	
}
