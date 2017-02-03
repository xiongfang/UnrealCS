#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTexture
	{
		static readonly int Source__Offset;
		public FTextureSource Source
		{
			get{ CheckIsValid();return (FTextureSource)Marshal.PtrToStructure(_this.Get()+Source__Offset, typeof(FTextureSource));}
			
		}
		
		static readonly int LightingGuid__Offset;
		/// <summary>Unique ID for this material, used for caching during distributed lighting</summary>
		public FGuid LightingGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+LightingGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int SourceFilePath__Offset;
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int AssetImportData__Offset;
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static readonly int AdjustBrightness__Offset;
		/// <summary>Static texture brightness adjustment (scales HSV value.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustBrightness
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustBrightness__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustBrightness__Offset, false);}
			
		}
		
		static readonly int AdjustBrightnessCurve__Offset;
		/// <summary>Static texture curve adjustment (raises HSV value to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustBrightnessCurve
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustBrightnessCurve__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustBrightnessCurve__Offset, false);}
			
		}
		
		static readonly int AdjustVibrance__Offset;
		/// <summary>Static texture "vibrance" adjustment (0 - 1) (HSV saturation algorithm adjustment.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustVibrance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustVibrance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustVibrance__Offset, false);}
			
		}
		
		static readonly int AdjustSaturation__Offset;
		/// <summary>Static texture saturation adjustment (scales HSV saturation.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustSaturation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustSaturation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustSaturation__Offset, false);}
			
		}
		
		static readonly int AdjustRGBCurve__Offset;
		/// <summary>Static texture RGB curve adjustment (raises linear-space RGB color to the specified power.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustRGBCurve
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustRGBCurve__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustRGBCurve__Offset, false);}
			
		}
		
		static readonly int AdjustHue__Offset;
		/// <summary>Static texture hue adjustment (0 - 360) (offsets HSV hue by value in degrees.)  (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustHue
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustHue__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustHue__Offset, false);}
			
		}
		
		static readonly int AdjustMinAlpha__Offset;
		/// <summary>Remaps the alpha to the specified min/max range, defines the new value of 0 (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustMinAlpha
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustMinAlpha__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustMinAlpha__Offset, false);}
			
		}
		
		static readonly int AdjustMaxAlpha__Offset;
		/// <summary>Remaps the alpha to the specified min/max range, defines the new value of 1 (Non-destructive; Requires texture source art to be available.)</summary>
		public float AdjustMaxAlpha
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AdjustMaxAlpha__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AdjustMaxAlpha__Offset, false);}
			
		}
		
		static readonly int CompressionNoAlpha__Offset;
		/// <summary>If enabled, the texture's alpha channel will be discarded during compression</summary>
		public bool CompressionNoAlpha
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CompressionNoAlpha__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CompressionNoAlpha__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CompressionNone__Offset;
		public bool CompressionNone
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CompressionNone__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DeferCompression__Offset;
		/// <summary>If enabled, defer compression of the texture until save.</summary>
		public bool DeferCompression
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DeferCompression__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), DeferCompression__Offset, 1,0,4,4);}
			
		}
		
		static readonly int MaxTextureSize__Offset;
		/// <summary>The maximum resolution for generated textures. A value of 0 means the maximum size for the format on each platform, except HDR long/lat cubemaps, which default to a resolution of 512.</summary>
		public int MaxTextureSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxTextureSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxTextureSize__Offset, false);}
			
		}
		
		static readonly int bDitherMipMapAlpha__Offset;
		/// <summary>When true, the alpha channel of mip-maps and the base image are dithered for smooth LOD transitions.</summary>
		public bool bDitherMipMapAlpha
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDitherMipMapAlpha__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDitherMipMapAlpha__Offset, 1,0,1,1);}
			
		}
		
		static readonly int AlphaCoverageThresholds__Offset;
		/// <summary>Alpha values per channel to compare to when preserving alpha coverage.</summary>
		public FVector4 AlphaCoverageThresholds
		{
			get{ CheckIsValid();return (FVector4)Marshal.PtrToStructure(_this.Get()+AlphaCoverageThresholds__Offset, typeof(FVector4));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaCoverageThresholds__Offset, false);}
			
		}
		
		static readonly int bPreserveBorder__Offset;
		/// <summary>When true the texture's border will be preserved during mipmap generation.</summary>
		public bool bPreserveBorder
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPreserveBorder__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPreserveBorder__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bFlipGreenChannel__Offset;
		/// <summary>When true the texture's green channel will be inverted. This is useful for some normal maps.</summary>
		public bool bFlipGreenChannel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFlipGreenChannel__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFlipGreenChannel__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bForcePVRTC4__Offset;
		/// <summary>For DXT1 textures, setting this will cause the texture to be twice the size, but better looking, on iPhone</summary>
		public bool bForcePVRTC4
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForcePVRTC4__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int PowerOfTwoMode__Offset;
		/// <summary>How to pad the texture to a power of 2 size (if necessary)</summary>
		public ETexturePowerOfTwoSetting PowerOfTwoMode
		{
			get{ CheckIsValid();return (ETexturePowerOfTwoSetting)Marshal.PtrToStructure(_this.Get()+PowerOfTwoMode__Offset, typeof(ETexturePowerOfTwoSetting));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PowerOfTwoMode__Offset, false);}
			
		}
		
		static readonly int PaddingColor__Offset;
		/// <summary>The color used to pad the texture out if it is resized due to PowerOfTwoMode</summary>
		public FColor PaddingColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+PaddingColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PaddingColor__Offset, false);}
			
		}
		
		static readonly int bChromaKeyTexture__Offset;
		/// <summary>Whether to chroma key the image, replacing any pixels that match ChromaKeyColor with transparent black</summary>
		public bool bChromaKeyTexture
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bChromaKeyTexture__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bChromaKeyTexture__Offset, 1,0,1,255);}
			
		}
		
		static readonly int ChromaKeyThreshold__Offset;
		/// <summary>The threshold that components have to match for the texel to be considered equal to the ChromaKeyColor when chroma keying (<=, set to 0 to require a perfect exact match)</summary>
		public float ChromaKeyThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ChromaKeyThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChromaKeyThreshold__Offset, false);}
			
		}
		
		static readonly int ChromaKeyColor__Offset;
		/// <summary>The color that will be replaced with transparent black if chroma keying is enabled</summary>
		public FColor ChromaKeyColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+ChromaKeyColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChromaKeyColor__Offset, false);}
			
		}
		
		static readonly int MipGenSettings__Offset;
		/// <summary>Per asset specific setting to define the mip-map generation properties like sharpening and kernel size.</summary>
		public TextureMipGenSettings MipGenSettings
		{
			get{ CheckIsValid();return (TextureMipGenSettings)Marshal.PtrToStructure(_this.Get()+MipGenSettings__Offset, typeof(TextureMipGenSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MipGenSettings__Offset, false);}
			
		}
		
		static readonly int CompositeTexture__Offset;
		/// <summary>
		/// Can be defined to modify the roughness based on the normal map variation (mostly from mip maps).
		/// MaxAlpha comes in handy to define a base roughness if no source alpha was there.
		/// Make sure the normal map has at least as many mips as this texture.
		/// </summary>
		public UTexture CompositeTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CompositeTexture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CompositeTexture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CompositeTexture__Offset, value._this.Get()); }
			
		}
		
		static readonly int CompositeTextureMode__Offset;
		/// <summary>defines how the CompositeTexture is applied, e.g. CTM_RoughnessFromNormalAlpha</summary>
		public ECompositeTextureMode CompositeTextureMode
		{
			get{ CheckIsValid();return (ECompositeTextureMode)Marshal.PtrToStructure(_this.Get()+CompositeTextureMode__Offset, typeof(ECompositeTextureMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompositeTextureMode__Offset, false);}
			
		}
		
		static readonly int CompositePower__Offset;
		/// <summary>
		/// default 1, high values result in a stronger effect e.g 1, 2, 4, 8
		/// this is no slider because the texture update would not be fast enough
		/// </summary>
		public float CompositePower
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CompositePower__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompositePower__Offset, false);}
			
		}
		
		static readonly int LODBias__Offset;
		/// <summary>A bias to the index of the top mip level to use.</summary>
		public int LODBias
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LODBias__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODBias__Offset, false);}
			
		}
		
		static readonly int NumCinematicMipLevels__Offset;
		/// <summary>Number of mip-levels to use for cinematic quality.</summary>
		public int NumCinematicMipLevels
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumCinematicMipLevels__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NumCinematicMipLevels__Offset, false);}
			
		}
		
		static readonly int SRGB__Offset;
		/// <summary>This should be unchecked if using alpha channels individually as masks.</summary>
		public bool SRGB
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), SRGB__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), SRGB__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseLegacyGamma__Offset;
		/// <summary>A flag for using the simplified legacy gamma space e.g pow(color,1/2.2) for converting from FColor to FLinearColor, if we're doing sRGB.</summary>
		public bool bUseLegacyGamma
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLegacyGamma__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLegacyGamma__Offset, 1,0,2,2);}
			
		}
		
		static readonly int NeverStream__Offset;
		public bool NeverStream
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), NeverStream__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), NeverStream__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bNoTiling__Offset;
		/// <summary>If true, the RHI texture will be created using TexCreate_NoTiling</summary>
		public bool bNoTiling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoTiling__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bUseCinematicMipLevels__Offset;
		/// <summary>Whether to use the extra cinematic quality mip-levels, when we're forcing mip-levels to be resident.</summary>
		public bool bUseCinematicMipLevels
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseCinematicMipLevels__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the asset</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static readonly int CachedCombinedLODBias__Offset;
		/// <summary>Cached combined group and texture LOD bias to use.</summary>
		public int CachedCombinedLODBias
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CachedCombinedLODBias__Offset, typeof(int));}
			
		}
		
		static readonly int bAsyncResourceReleaseHasBeenStarted__Offset;
		/// <summary>Whether the async resource release process has already been kicked off or not</summary>
		public bool bAsyncResourceReleaseHasBeenStarted
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAsyncResourceReleaseHasBeenStarted__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int CompressionSettings__Offset;
		/// <summary>Compression settings to use when building the texture.</summary>
		public TextureCompressionSettings CompressionSettings
		{
			get{ CheckIsValid();return (TextureCompressionSettings)Marshal.PtrToStructure(_this.Get()+CompressionSettings__Offset, typeof(TextureCompressionSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompressionSettings__Offset, false);}
			
		}
		
		static readonly int Filter__Offset;
		/// <summary>The texture filtering mode to use when sampling this texture.</summary>
		public TextureFilter Filter
		{
			get{ CheckIsValid();return (TextureFilter)Marshal.PtrToStructure(_this.Get()+Filter__Offset, typeof(TextureFilter));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Filter__Offset, false);}
			
		}
		
		static readonly int LODGroup__Offset;
		/// <summary>Texture group this texture belongs to</summary>
		public TextureGroup LODGroup
		{
			get{ CheckIsValid();return (TextureGroup)Marshal.PtrToStructure(_this.Get()+LODGroup__Offset, typeof(TextureGroup));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODGroup__Offset, false);}
			
		}
		
		static UTexture()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Texture");
			Source__Offset=GetPropertyOffset(NativeClassPtr,"Source");
			LightingGuid__Offset=GetPropertyOffset(NativeClassPtr,"LightingGuid");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			AdjustBrightness__Offset=GetPropertyOffset(NativeClassPtr,"AdjustBrightness");
			AdjustBrightnessCurve__Offset=GetPropertyOffset(NativeClassPtr,"AdjustBrightnessCurve");
			AdjustVibrance__Offset=GetPropertyOffset(NativeClassPtr,"AdjustVibrance");
			AdjustSaturation__Offset=GetPropertyOffset(NativeClassPtr,"AdjustSaturation");
			AdjustRGBCurve__Offset=GetPropertyOffset(NativeClassPtr,"AdjustRGBCurve");
			AdjustHue__Offset=GetPropertyOffset(NativeClassPtr,"AdjustHue");
			AdjustMinAlpha__Offset=GetPropertyOffset(NativeClassPtr,"AdjustMinAlpha");
			AdjustMaxAlpha__Offset=GetPropertyOffset(NativeClassPtr,"AdjustMaxAlpha");
			CompressionNoAlpha__Offset=GetPropertyOffset(NativeClassPtr,"CompressionNoAlpha");
			CompressionNone__Offset=GetPropertyOffset(NativeClassPtr,"CompressionNone");
			DeferCompression__Offset=GetPropertyOffset(NativeClassPtr,"DeferCompression");
			MaxTextureSize__Offset=GetPropertyOffset(NativeClassPtr,"MaxTextureSize");
			bDitherMipMapAlpha__Offset=GetPropertyOffset(NativeClassPtr,"bDitherMipMapAlpha");
			AlphaCoverageThresholds__Offset=GetPropertyOffset(NativeClassPtr,"AlphaCoverageThresholds");
			bPreserveBorder__Offset=GetPropertyOffset(NativeClassPtr,"bPreserveBorder");
			bFlipGreenChannel__Offset=GetPropertyOffset(NativeClassPtr,"bFlipGreenChannel");
			bForcePVRTC4__Offset=GetPropertyOffset(NativeClassPtr,"bForcePVRTC4");
			PowerOfTwoMode__Offset=GetPropertyOffset(NativeClassPtr,"PowerOfTwoMode");
			PaddingColor__Offset=GetPropertyOffset(NativeClassPtr,"PaddingColor");
			bChromaKeyTexture__Offset=GetPropertyOffset(NativeClassPtr,"bChromaKeyTexture");
			ChromaKeyThreshold__Offset=GetPropertyOffset(NativeClassPtr,"ChromaKeyThreshold");
			ChromaKeyColor__Offset=GetPropertyOffset(NativeClassPtr,"ChromaKeyColor");
			MipGenSettings__Offset=GetPropertyOffset(NativeClassPtr,"MipGenSettings");
			CompositeTexture__Offset=GetPropertyOffset(NativeClassPtr,"CompositeTexture");
			CompositeTextureMode__Offset=GetPropertyOffset(NativeClassPtr,"CompositeTextureMode");
			CompositePower__Offset=GetPropertyOffset(NativeClassPtr,"CompositePower");
			LODBias__Offset=GetPropertyOffset(NativeClassPtr,"LODBias");
			NumCinematicMipLevels__Offset=GetPropertyOffset(NativeClassPtr,"NumCinematicMipLevels");
			SRGB__Offset=GetPropertyOffset(NativeClassPtr,"SRGB");
			bUseLegacyGamma__Offset=GetPropertyOffset(NativeClassPtr,"bUseLegacyGamma");
			NeverStream__Offset=GetPropertyOffset(NativeClassPtr,"NeverStream");
			bNoTiling__Offset=GetPropertyOffset(NativeClassPtr,"bNoTiling");
			bUseCinematicMipLevels__Offset=GetPropertyOffset(NativeClassPtr,"bUseCinematicMipLevels");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			CachedCombinedLODBias__Offset=GetPropertyOffset(NativeClassPtr,"CachedCombinedLODBias");
			bAsyncResourceReleaseHasBeenStarted__Offset=GetPropertyOffset(NativeClassPtr,"bAsyncResourceReleaseHasBeenStarted");
			CompressionSettings__Offset=GetPropertyOffset(NativeClassPtr,"CompressionSettings");
			Filter__Offset=GetPropertyOffset(NativeClassPtr,"Filter");
			LODGroup__Offset=GetPropertyOffset(NativeClassPtr,"LODGroup");
			
		}
		
	}
	
}
#endif
#endif
