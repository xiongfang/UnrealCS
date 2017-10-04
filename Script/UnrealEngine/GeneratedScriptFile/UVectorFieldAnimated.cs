using System;
namespace UnrealEngine
{
	public partial class UVectorFieldAnimated:UVectorField
	{
		/// <summary>The texture from which to create the vector field.</summary>
		public UTexture2D Texture;
		
		/// <summary>The operation used to construct the vector field.</summary>
		public EVectorFieldConstructionOp ConstructionOp;
		
		/// <summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
		public int VolumeSizeX;
		
		/// <summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
		public int VolumeSizeY;
		
		/// <summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
		public int VolumeSizeZ;
		
		/// <summary>The number of horizontal subimages in the texture atlas.</summary>
		public int SubImagesX;
		
		/// <summary>The number of vertical subimages in the texture atlas.</summary>
		public int SubImagesY;
		
		/// <summary>The number of frames in the atlas.</summary>
		public int FrameCount;
		
		/// <summary>The rate at which to interpolate between frames.</summary>
		public float FramesPerSecond;
		
		/// <summary>Whether or not the simulation should loop.</summary>
		public bool bLoop;
		
		/// <summary>A static vector field used to add noise.</summary>
		public UVectorFieldStatic NoiseField;
		
		/// <summary>Scale to apply to vectors in the noise field.</summary>
		public float NoiseScale;
		
		/// <summary>The maximum magnitude of noise vectors to apply.</summary>
		public float NoiseMax;
		
		
	}
	
}
