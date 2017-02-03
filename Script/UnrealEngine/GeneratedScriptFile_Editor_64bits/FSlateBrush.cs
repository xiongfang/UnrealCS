#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An brush which contains information about how to draw a Slate element</summary>
	[StructLayout(LayoutKind.Explicit,Size=152)]
	public partial struct FSlateBrush
	{
		/// <summary>Size of the resource in Slate Units</summary>
		[FieldOffset(8)]
		public FVector2D ImageSize;
		/// <summary>How to draw the image</summary>
		[FieldOffset(16)]
		public ESlateBrushDrawType DrawAs;
		/// <summary>The margin to use in Box and Border modes</summary>
		[FieldOffset(20)]
		public FMargin Margin;
		/// <summary>Tinting applied to the image.</summary>
		[FieldOffset(36)]
		public FLinearColor Tint;
		/// <summary>Tinting applied to the image.</summary>
		[FieldOffset(56)]
		public FSlateColor TintColor;
		/// <summary>How to tile the image in Image mode</summary>
		[FieldOffset(96)]
		public ESlateBrushTileType Tiling;
		/// <summary>
		/// How to mirror the image in Image mode.  This is normally only used for dynamic image brushes where the source texture
		///           comes from a hardware device such as a web camera.
		/// </summary>
		[FieldOffset(97)]
		public ESlateBrushMirrorType Mirroring;
		/// <summary>The type of image</summary>
		[FieldOffset(98)]
		public ESlateBrushImageType ImageType;
		/// <summary>
		/// The image to render for this brush, can be a UTexture or UMaterialInterface or an object implementing
		/// the AtlasedTextureInterface.
		/// </summary>
		/// <summary>The name of the rendering resource to use</summary>
		[FieldOffset(112)]
		public FName ResourceName;
		/// <summary>Whether or not the brush path is a path to a UObject</summary>
		public bool bIsDynamicallyLoaded
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not the brush has a UTexture resource</summary>
		public bool bHasUObject
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 125, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 125, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Optional UV region for an image
		/// When valid - overrides UV region specified in resource proxy
		/// </summary>
		[FieldOffset(128)]
		public FBox2D UVRegion;
		
	}
	
}
#endif
#endif
