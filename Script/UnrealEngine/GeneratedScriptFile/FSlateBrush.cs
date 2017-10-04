using System;
namespace UnrealEngine
{
	/// <summary>An brush which contains information about how to draw a Slate element</summary>
	public partial struct FSlateBrush
	{
		/// <summary>Size of the resource in Slate Units</summary>
		public FVector2D ImageSize;
		/// <summary>How to draw the image</summary>
		public ESlateBrushDrawType DrawAs;
		/// <summary>The margin to use in Box and Border modes</summary>
		public FMargin Margin;
		/// <summary>Tinting applied to the image.</summary>
		public FLinearColor Tint;
		/// <summary>Tinting applied to the image.</summary>
		public FSlateColor TintColor;
		/// <summary>How to tile the image in Image mode</summary>
		public ESlateBrushTileType Tiling;
		/// <summary>
		/// How to mirror the image in Image mode.  This is normally only used for dynamic image brushes where the source texture
		///           comes from a hardware device such as a web camera.
		/// </summary>
		public ESlateBrushMirrorType Mirroring;
		/// <summary>The type of image</summary>
		public ESlateBrushImageType ImageType;
		/// <summary>
		/// The image to render for this brush, can be a UTexture or UMaterialInterface or an object implementing
		/// the AtlasedTextureInterface.
		/// </summary>
		public UObject ResourceObject;
		/// <summary>The name of the rendering resource to use</summary>
		public FName ResourceName;
		/// <summary>Whether or not the brush path is a path to a UObject</summary>
		public bool bIsDynamicallyLoaded;
		/// <summary>Whether or not the brush has a UTexture resource</summary>
		public bool bHasUObject;
		/// <summary>
		/// Optional UV region for an image
		/// When valid - overrides UV region specified in resource proxy
		/// </summary>
		public FBox2D UVRegion;
		
	}
	
}
