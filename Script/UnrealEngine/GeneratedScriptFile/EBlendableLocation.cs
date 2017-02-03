using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Where to place a material node in the post processing graph.</summary>
	public enum EBlendableLocation:byte
	{
		/// <summary>Input0:former pass color, Input1:SeparateTranslucency.</summary>
		BL_AfterTonemapping=0,
		/// <summary>Input0:former pass color, Input1:SeparateTranslucency.</summary>
		BL_BeforeTonemapping=1,
		/// <summary>Input0:former pass color, Input1:SeparateTranslucency.</summary>
		BL_BeforeTranslucency=2,
		/// <summary>
		/// Input0:former pass color, Input1:SeparateTranslucency, Input2: BloomOutput
		/// vector parameters: Engine.FilmWhitePoint
		/// scalar parameters: Engine.FilmSaturation, Engine.FilmContrast
		/// </summary>
		BL_ReplacingTonemapper=3,
		/// <summary>
		/// BL_AfterOpaque,
		/// BL_AfterFog,
		/// BL_AfterTranslucency,
		/// BL_AfterPostProcessAA,
		/// </summary>
		BL_MAX=4,
		
	}
	
}
