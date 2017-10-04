using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionVectorNoise:UMaterialExpression
	{
		/// <summary>2 to 3 dimensional vector</summary>
		public FExpressionInput Position;
		
		/// <summary>Noise function, affects performance and look</summary>
		public EVectorNoiseFunction NoiseFunction;
		
		/// <summary>For noise functions where applicable, lower numbers are faster and lower quality, higher numbers are slower and higher quality</summary>
		public int Quality;
		
		/// <summary>Whether tile the noise pattern, useful for baking to seam-free repeating textures</summary>
		public bool bTiling;
		
		/// <summary>
		/// How many units in each tile (if Tiling is on)
		/// For Perlin noise functions, Tile Size must be a multiple of three
		/// </summary>
		public uint TileSize;
		
		
	}
	
}
