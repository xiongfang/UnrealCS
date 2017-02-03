using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Particle Selection Method, for any emitters that utilize particles
	/// as the source points.
	/// </summary>
	public enum EParticleSourceSelectionMethod:byte
	{
		/// <summary>Random         - select a particle at random</summary>
		EPSSM_Random=0,
		/// <summary>Sequential     - select a particle in order</summary>
		EPSSM_Sequential=1,
		EPSSM_MAX=2,
		
	}
	
}
