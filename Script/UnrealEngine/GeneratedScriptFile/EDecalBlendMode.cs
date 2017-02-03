using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines how the GBuffer channels are getting manipulated by a decal material pass. Actual index is used to control shader parameters so don't change order.</summary>
	public enum EDecalBlendMode:byte
	{
		/// <summary>Blend full material, updating the GBuffer, does not work for baked lighting.</summary>
		DBM_Translucent=0,
		/// <summary>Modulate BaseColor, blend rest, updating the GBuffer, does not work for baked lighting.</summary>
		DBM_Stain=1,
		/// <summary>Only blend normal, updating the GBuffer, does not work for baked lighting.</summary>
		DBM_Normal=2,
		/// <summary>Additive emissive only.</summary>
		DBM_Emissive=3,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well (becomes DBM_TranslucentNormal if normal is not hooked up).</summary>
		DBM_DBuffer_ColorNormalRoughness=4,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well.</summary>
		DBM_DBuffer_Color=5,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well (becomes DBM_DBuffer_Color if normal is not hooked up).</summary>
		DBM_DBuffer_ColorNormal=6,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well.</summary>
		DBM_DBuffer_ColorRoughness=7,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well.</summary>
		DBM_DBuffer_Normal=8,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well (becomes DBM_DBuffer_Roughness if normal is not hooked up).</summary>
		DBM_DBuffer_NormalRoughness=9,
		/// <summary>Non metal, put into DBuffer to work for baked lighting as well.</summary>
		DBM_DBuffer_Roughness=10,
		/// <summary>Output signed distance in Opacity depending on LightVector. Note: Can be costly, no shadow casting but receiving, no per pixel normal yet, no quality settings yet</summary>
		DBM_Volumetric_DistanceFunction=11,
		DBM_MAX=12,
		
	}
	
}
