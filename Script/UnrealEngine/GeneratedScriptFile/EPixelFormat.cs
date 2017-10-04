using System;
namespace UnrealEngine
{
	/// <summary>
	/// @warning:      When you update this, you must add an entry to GPixelFormats(see RenderUtils.cpp)
	/// @warning:     When you update this, you must add an entries to PixelFormat.h, usually just copy the generated section on the header into EPixelFormat
	/// @warning:     The *Tools DLLs will also need to be recompiled if the ordering is changed, but should not need code changes.
	/// </summary>
	public enum EPixelFormat:byte
	{
		PF_Unknown=0,
		PF_A32B32G32R32F=1,
		PF_B8G8R8A8=2,
		/// <summary>UNORM red (0..1)</summary>
		PF_G8=3,
		PF_G16=4,
		PF_DXT1=5,
		PF_DXT3=6,
		PF_DXT5=7,
		PF_UYVY=8,
		/// <summary>A RGB FP format with platform-specific implementation, for use with render targets.</summary>
		PF_FloatRGB=9,
		/// <summary>A RGBA FP format with platform-specific implementation, for use with render targets.</summary>
		PF_FloatRGBA=10,
		/// <summary>A depth+stencil format with platform-specific implementation, for use with render targets.</summary>
		PF_DepthStencil=11,
		/// <summary>A depth format with platform-specific implementation, for use with render targets.</summary>
		PF_ShadowDepth=12,
		PF_R32_FLOAT=13,
		PF_G16R16=14,
		PF_G16R16F=15,
		PF_G16R16F_FILTER=16,
		PF_G32R32F=17,
		PF_A2B10G10R10=18,
		PF_A16B16G16R16=19,
		PF_D24=20,
		PF_R16F=21,
		PF_R16F_FILTER=22,
		PF_BC5=23,
		/// <summary>SNORM red, green (-1..1). Not supported on all RHI e.g. Metal</summary>
		PF_V8U8=24,
		PF_A1=25,
		/// <summary>A low precision floating point format.</summary>
		PF_FloatR11G11B10=26,
		PF_A8=27,
		PF_R32_UINT=28,
		PF_R32_SINT=29,
		PF_PVRTC2=30,
		PF_PVRTC4=31,
		PF_R16_UINT=32,
		PF_R16_SINT=33,
		PF_R16G16B16A16_UINT=34,
		PF_R16G16B16A16_SINT=35,
		PF_R5G6B5_UNORM=36,
		PF_R8G8B8A8=37,
		/// <summary>Only used for legacy loading; do NOT use!</summary>
		PF_A8R8G8B8=38,
		/// <summary>High precision single channel block compressed, equivalent to a single channel BC5, 8 bytes per 4x4 block.</summary>
		PF_BC4=39,
		/// <summary>UNORM red, green (0..1).</summary>
		PF_R8G8=40,
		/// <summary>ATITC format.</summary>
		PF_ATC_RGB=41,
		/// <summary>ATITC format.</summary>
		PF_ATC_RGBA_E=42,
		/// <summary>ATITC format.</summary>
		PF_ATC_RGBA_I=43,
		/// <summary>Used for creating SRVs to alias a DepthStencil buffer to read Stencil.  Don't use for creating textures.</summary>
		PF_X24_G8=44,
		PF_ETC1=45,
		PF_ETC2_RGB=46,
		PF_ETC2_RGBA=47,
		PF_R32G32B32A32_UINT=48,
		PF_R16G16_UINT=49,
		/// <summary>8.00 bpp</summary>
		PF_ASTC_4x4=50,
		/// <summary>3.56 bpp</summary>
		PF_ASTC_6x6=51,
		/// <summary>2.00 bpp</summary>
		PF_ASTC_8x8=52,
		/// <summary>1.28 bpp</summary>
		PF_ASTC_10x10=53,
		/// <summary>0.89 bpp</summary>
		PF_ASTC_12x12=54,
		PF_BC6H=55,
		PF_BC7=56,
		PF_R8_UINT=57,
		PF_MAX=58,
		
	}
	
}
