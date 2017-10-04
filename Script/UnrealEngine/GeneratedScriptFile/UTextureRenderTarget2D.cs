using System;
namespace UnrealEngine
{
	public partial class UTextureRenderTarget2D:UTextureRenderTarget
	{
		/// <summary>The width of the texture.</summary>
		public int SizeX;
		
		/// <summary>The height of the texture.</summary>
		public int SizeY;
		
		/// <summary>the color the texture is cleared to</summary>
		public FLinearColor ClearColor;
		
		/// <summary>The addressing mode to use for the X axis.</summary>
		public TextureAddress AddressX;
		
		/// <summary>The addressing mode to use for the Y axis.</summary>
		public TextureAddress AddressY;
		
		/// <summary>True to force linear gamma space for this render target</summary>
		public bool bForceLinearGamma;
		
		/// <summary>Whether to support storing HDR values, which requires more memory.</summary>
		public bool bHDR;
		
		/// <summary>Whether to support GPU sharing of the underlying native texture resource.</summary>
		public bool bGPUSharedFlag;
		
		/// <summary>Whether to support Mip maps for this render target texture</summary>
		public bool bAutoGenerateMips;
		
		/// <summary>Normally the format is derived from bHDR, this allows code to set the format explicitly.</summary>
		public EPixelFormat OverrideFormat;
		
		
	}
	
}
