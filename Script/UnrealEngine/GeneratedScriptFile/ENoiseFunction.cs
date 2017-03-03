using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ENoiseFunction:byte
	{
		/// <summary>
		/// High quality for direct use and bumps
		/// ~77 instructions per level, 4 texture lookups
		/// Cannot tile
		/// </summary>
		NOISEFUNCTION_SimplexTex=0,
		/// <summary>
		/// High quality for direct use and bumps
		/// Non-tiled: ~61 instructions per level, 8 texture lookups
		/// Tiling: ~74 instructions per level, 8 texture lookups
		/// Even "non-tiled" mode has a repeat of 128. Useful Repeat Size range <= 128
		/// Formerly labeled as Perlin noise
		/// </summary>
		NOISEFUNCTION_GradientTex=1,
		/// <summary>
		/// High quality for direct use, BAD for bumps; doesn't work on Mobile
		/// ~16 instructions per level, 1 texture lookup
		/// Always tiles with a repeat of 16, "Tiling" mode is not an option for Fast Gradient noise
		/// </summary>
		NOISEFUNCTION_GradientTex3D=2,
		/// <summary>
		/// High quality for direct use and bumps
		/// Non-tiled: ~80 instructions per level, no textures
		/// Tiling: ~143 instructions per level, no textures
		/// </summary>
		NOISEFUNCTION_GradientALU=3,
		/// <summary>
		/// Low quality, but pure computation
		/// Non-tiled: ~53 instructions per level, no textures
		/// Tiling: ~118 instructions per level, no textures
		/// Formerly mis-labeled as Gradient noise
		/// </summary>
		NOISEFUNCTION_ValueALU=4,
		/// <summary>
		/// Also known as Worley or Cellular noise
		/// Quality=1 searches 8 cells, Quality=2 searches 16 cells
		/// Quality=3 searches 27 cells, Quality=4 searches 32 cells
		/// All are about 20 instructions per cell searched
		/// </summary>
		NOISEFUNCTION_VoronoiALU=5,
		NOISEFUNCTION_MAX=6,
		
	}
	
}
