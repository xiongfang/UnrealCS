using System;
namespace UnrealEngine
{
	/// <summary>Texture source data management.</summary>
	public partial struct FTextureSource
	{
		/// <summary>GUID used to track changes to the source data.</summary>
		public FGuid Id;
		/// <summary>Width of the texture.</summary>
		public int SizeX;
		/// <summary>Height of the texture.</summary>
		public int SizeY;
		/// <summary>Depth (volume textures) or faces (cube maps).</summary>
		public int NumSlices;
		/// <summary>Number of mips provided as source data for the texture.</summary>
		public int NumMips;
		/// <summary>RGBA8 source data is optionally compressed as PNG.</summary>
		public bool bPNGCompressed;
		/// <summary>Legacy textures use a hash instead of a GUID.</summary>
		public bool bGuidIsHash;
		/// <summary>Format in which the source data is stored.</summary>
		public ETextureSourceFormat Format;
		
	}
	
}
