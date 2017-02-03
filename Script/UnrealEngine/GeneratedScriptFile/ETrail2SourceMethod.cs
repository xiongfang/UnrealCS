using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETrail2SourceMethod:byte
	{
		/// <summary>
		/// Default        - use the emitter position.
		///     This is the fallback for when other modes can't be resolved.
		/// </summary>
		PET2SRCM_Default=0,
		/// <summary>
		/// Particle       - use the particles from a given emitter in the system.
		///     The name of the emitter should be set in SourceName.
		/// </summary>
		PET2SRCM_Particle=1,
		/// <summary>
		/// Actor          - use the actor as the source.
		///     The name of the actor should be set in SourceName.
		/// </summary>
		PET2SRCM_Actor=2,
		PET2SRCM_MAX=3,
		
	}
	
}
