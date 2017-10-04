using System;
namespace UnrealEngine
{
	public partial class UTexture:UObject
	{
		public FTextureSource Source;
		
		/// <summary>Unique ID for this material, used for caching during distributed lighting</summary>
		public FGuid LightingGuid;
		
		public FString SourceFilePath;
		
		public UAssetImportData AssetImportData;
		
		/// <summary>Static texture brightness adjustment (scales HSV value.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustBrightness;
		
		/// <summary>Static texture curve adjustment (raises HSV value to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustBrightnessCurve;
		
		/// <summary>Static texture "vibrance" adjustment (0 - 1) (HSV saturation algorithm adjustment.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustVibrance;
		
		/// <summary>Static texture saturation adjustment (scales HSV saturation.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustSaturation;
		
		/// <summary>Static texture RGB curve adjustment (raises linear-space RGB color to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustRGBCurve;
		
		/// <summary>Static texture hue adjustment (0 - 360) (offsets HSV hue by value in degrees.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustHue;
		
		/// <summary>Remaps the alpha to the specified min/max range, defines the new value of 0 (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustMinAlpha;
		
		/// <summary>Remaps the alpha to the specified min/max range, defines the new value of 1 (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustMaxAlpha;
		
		/// <summary>If enabled, the texture's alpha channel will be discarded during compression</summary>
		public bool CompressionNoAlpha;
		
		public bool CompressionNone;
		
		/// <summary>If enabled, defer compression of the texture until save.</summary>
		public bool DeferCompression;
		
		/// <summary>The maximum resolution for generated textures. A value of 0 means the maximum size for the format on each platform, except HDR long/lat cubemaps, which default to a resolution of 512.</summary>
		public int MaxTextureSize;
		
		/// <summary>When true, the alpha channel of mip-maps and the base image are dithered for smooth LOD transitions.</summary>
		public bool bDitherMipMapAlpha;
		
		/// <summary>Alpha values per channel to compare to when preserving alpha coverage.</summary>
		public FVector4 AlphaCoverageThresholds;
		
		/// <summary>When true the texture's border will be preserved during mipmap generation.</summary>
		public bool bPreserveBorder;
		
		/// <summary>When true the texture's green channel will be inverted. This is useful for some normal maps.</summary>
		public bool bFlipGreenChannel;
		
		/// <summary>For DXT1 textures, setting this will cause the texture to be twice the size, but better looking, on iPhone</summary>
		public bool bForcePVRTC4;
		
		/// <summary>How to pad the texture to a power of 2 size (if necessary)</summary>
		public ETexturePowerOfTwoSetting PowerOfTwoMode;
		
		/// <summary>The color used to pad the texture out if it is resized due to PowerOfTwoMode</summary>
		public FColor PaddingColor;
		
		/// <summary>Whether to chroma key the image, replacing any pixels that match ChromaKeyColor with transparent black</summary>
		public bool bChromaKeyTexture;
		
		/// <summary>The threshold that components have to match for the texel to be considered equal to the ChromaKeyColor when chroma keying (<=, set to 0 to require a perfect exact match)</summary>
		public float ChromaKeyThreshold;
		
		/// <summary>The color that will be replaced with transparent black if chroma keying is enabled</summary>
		public FColor ChromaKeyColor;
		
		/// <summary>Per asset specific setting to define the mip-map generation properties like sharpening and kernel size.</summary>
		public TextureMipGenSettings MipGenSettings;
		
		/// <summary>
		/// Can be defined to modify the roughness based on the normal map variation (mostly from mip maps).
		/// MaxAlpha comes in handy to define a base roughness if no source alpha was there.
		/// Make sure the normal map has at least as many mips as this texture.
		/// </summary>
		public UTexture CompositeTexture;
		
		/// <summary>defines how the CompositeTexture is applied, e.g. CTM_RoughnessFromNormalAlpha</summary>
		public ECompositeTextureMode CompositeTextureMode;
		
		/// <summary>
		/// default 1, high values result in a stronger effect e.g 1, 2, 4, 8
		/// this is no slider because the texture update would not be fast enough
		/// </summary>
		public float CompositePower;
		
		/// <summary>A bias to the index of the top mip level to use.</summary>
		public int LODBias;
		
		/// <summary>Number of mip-levels to use for cinematic quality.</summary>
		public int NumCinematicMipLevels;
		
		/// <summary>This should be unchecked if using alpha channels individually as masks.</summary>
		public bool SRGB;
		
		/// <summary>A flag for using the simplified legacy gamma space e.g pow(color,1/2.2) for converting from FColor to FLinearColor, if we're doing sRGB.</summary>
		public bool bUseLegacyGamma;
		
		public bool NeverStream;
		
		/// <summary>If true, the RHI texture will be created using TexCreate_NoTiling</summary>
		public bool bNoTiling;
		
		/// <summary>Whether to use the extra cinematic quality mip-levels, when we're forcing mip-levels to be resident.</summary>
		public bool bUseCinematicMipLevels;
		
		/// <summary>Cached combined group and texture LOD bias to use.</summary>
		public int CachedCombinedLODBias;
		
		/// <summary>Whether the async resource release process has already been kicked off or not</summary>
		public bool bAsyncResourceReleaseHasBeenStarted;
		
		/// <summary>Compression settings to use when building the texture.</summary>
		public TextureCompressionSettings CompressionSettings;
		
		/// <summary>The texture filtering mode to use when sampling this texture.</summary>
		public TextureFilter Filter;
		
		/// <summary>Texture group this texture belongs to</summary>
		public TextureGroup LODGroup;
		
		
	}
	
}
