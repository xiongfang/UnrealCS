using System;
namespace UnrealEngine
{
	public partial class USubUVAnimation:UObject
	{
		/// <summary>Texture to generate bounding geometry from.</summary>
		public UTexture2D SubUVTexture;
		
		/// <summary>The number of sub-images horizontally in the texture</summary>
		public int SubImages_Horizontal;
		
		/// <summary>The number of sub-images vertically in the texture</summary>
		public int SubImages_Vertical;
		
		/// <summary>
		/// More bounding vertices results in reduced overdraw, but adds more triangle overhead.
		/// The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
		/// and when the particles using the texture will be few and large.
		/// </summary>
		public ESubUVBoundingVertexCount BoundingMode;
		
		public EOpacitySourceMode OpacitySourceMode;
		
		/// <summary>
		/// Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.
		/// Raising this threshold slightly can reduce overdraw in particles using this animation asset.
		/// </summary>
		public float AlphaThreshold;
		
		
	}
	
}
