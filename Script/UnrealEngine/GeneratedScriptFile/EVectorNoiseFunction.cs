using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EVectorNoiseFunction:byte
	{
		/// <summary>
		/// Random color for each unit cell in 3D space.
		/// RGB output range 0 to 1
		/// R only = 9 instructions, RGB = 11 instructions
		/// </summary>
		VNF_CellnoiseALU=0,
		/// <summary>
		/// Perlin-style noise with 3D vector/color output.
		/// RGB output range -1 to 1
		/// R only = ~83 instructions, RGB = ~125 instructions
		/// </summary>
		VNF_VectorALU=1,
		/// <summary>
		/// Gradient of Perlin noise, useful for bumps.
		/// RGB = Gradient of scalar noise (signed 3D vector)
		/// A = Base scalar noise with range -1 to 1
		/// A only = ~83 instructions, RGBA = ~106 instructions
		/// </summary>
		VNF_GradientALU=2,
		/// <summary>
		/// Curl of Perlin noise, useful for 3D flow directions.
		/// RGB = signed curl vector
		/// ~162 instructions
		/// </summary>
		VNF_CurlALU=3,
		/// <summary>
		/// Also known as Worley or Cellular noise.
		/// RGB = *position* of closest point at center of Voronoi cell
		/// A = distance to closest point with range 0 to about 4
		/// Quality levels 1-4 search 8, 16, 27 & 32 cells
		/// All ~20 instructions per cell searched
		/// </summary>
		VNF_VoronoiALU=4,
		VNF_MAX=5,
		
	}
	
}
