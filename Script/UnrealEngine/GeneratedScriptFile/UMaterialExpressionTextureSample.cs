using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureSample:UMaterialExpressionTextureBase
	{
		/// <summary>Defaults to 'ConstCoordinate' if not specified</summary>
		public FExpressionInput Coordinates;
		
		/// <summary>Defaults to 'Texture' if not specified</summary>
		public FExpressionInput TextureObject;
		
		/// <summary>Defaults to 'ConstMipValue' if not specified</summary>
		public FExpressionInput MipValue;
		
		/// <summary>Coordinates derivative over the X axis</summary>
		public FExpressionInput CoordinatesDX;
		
		/// <summary>Coordinates derivative over the Y axis</summary>
		public FExpressionInput CoordinatesDY;
		
		/// <summary>Defines how the MipValue property is applied to the texture lookup</summary>
		public ETextureMipValueMode MipValueMode;
		
		/// <summary>
		/// Controls where the sampler for this texture lookup will come from.
		/// Choose 'from texture asset' to make use of the UTexture addressing settings,
		/// Otherwise use one of the global samplers, which will not consume a sampler slot.
		/// This allows materials to use more than 16 unique textures on SM5 platforms.
		/// </summary>
		public ESamplerSourceMode SamplerSource;
		
		/// <summary>only used if Coordinates is not hooked up</summary>
		public uint ConstCoordinate;
		
		/// <summary>only used if MipValue is not hooked up</summary>
		public int ConstMipValue;
		
		
	}
	
}
