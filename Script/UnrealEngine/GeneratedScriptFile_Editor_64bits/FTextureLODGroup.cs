#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>LOD settings for a single texture group.</summary>
	[StructLayout(LayoutKind.Explicit,Size=60)]
	public partial struct FTextureLODGroup
	{
		/// <summary>Minimum LOD mip count below which the code won't bias.</summary>
		[FieldOffset(0)]
		public TextureGroup Group;
		/// <summary>Group LOD bias.</summary>
		[FieldOffset(12)]
		public int LODBias;
		/// <summary>Number of mip-levels that can be streamed. -1 means all mips can stream.</summary>
		[FieldOffset(20)]
		public int NumStreamedMips;
		/// <summary>Defines how the the mip-map generation works, e.g. sharpening</summary>
		[FieldOffset(24)]
		public TextureMipGenSettings MipGenSettings;
		[FieldOffset(28)]
		public int MinLODSize;
		[FieldOffset(32)]
		public int MaxLODSize;
		[FieldOffset(36)]
		public FName MinMagFilter;
		[FieldOffset(48)]
		public FName MipFilter;
		
	}
	
}
#endif
#endif
