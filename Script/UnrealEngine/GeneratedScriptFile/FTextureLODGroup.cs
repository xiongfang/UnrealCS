using System;
namespace UnrealEngine
{
	/// <summary>LOD settings for a single texture group.</summary>
	public partial struct FTextureLODGroup
	{
		/// <summary>Minimum LOD mip count below which the code won't bias.</summary>
		public TextureGroup Group;
		/// <summary>Group LOD bias.</summary>
		public int LODBias;
		/// <summary>Number of mip-levels that can be streamed. -1 means all mips can stream.</summary>
		public int NumStreamedMips;
		/// <summary>Defines how the the mip-map generation works, e.g. sharpening</summary>
		public TextureMipGenSettings MipGenSettings;
		public int MinLODSize;
		public int MaxLODSize;
		public FName MinMagFilter;
		public FName MipFilter;
		
	}
	
}
