using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines how the material reacts on DBuffer decals, later we can expose more variants between None and Default.</summary>
	public enum EMaterialDecalResponse:byte
	{
		/// <summary>Do not receive decals (Later we still can read the DBuffer channels to customize the effect, this frees up some interpolators).</summary>
		MDR_None=0,
		/// <summary>Receive Decals, applies all DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_ColorNormalRoughness=1,
		/// <summary>Receive Decals, applies color DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_Color=2,
		/// <summary>Receive Decals, applies all DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_ColorNormal=3,
		/// <summary>Receive Decals, applies all DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_ColorRoughness=4,
		/// <summary>Receive Decals, applies all DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_Normal=5,
		/// <summary>Receive Decals, applies all DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_NormalRoughness=6,
		/// <summary>Receive Decals, applies all DBuffer channels, assumes the decal is non metal and mask the subsurface scattering.</summary>
		MDR_Roughness=7,
		MDR_MAX=8,
		
	}
	
}
