using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Occlusion method enumeration</summary>
	public enum EParticleSystemOcclusionBoundsMethod:byte
	{
		/// <summary>Don't determine occlusion on this particle system</summary>
		EPSOBM_None=0,
		/// <summary>Use the bounds of the particle system component when determining occlusion</summary>
		EPSOBM_ParticleBounds=1,
		/// <summary>Use the custom occlusion bounds when determining occlusion</summary>
		EPSOBM_CustomBounds=2,
		EPSOBM_MAX=3,
		
	}
	
}
