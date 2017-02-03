using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The method to use in determining the source/target.</summary>
	public enum Beam2SourceTargetMethod:byte
	{
		/// <summary>
		/// Default        - use the distribution.
		///     This is the fallback for when other modes can't be resolved.
		/// </summary>
		PEB2STM_Default=0,
		/// <summary>
		/// UserSet        - use the user set value.
		///     Primarily intended for weapon effects.
		/// </summary>
		PEB2STM_UserSet=1,
		/// <summary>Emitter        - use the emitter position as the source/target.</summary>
		PEB2STM_Emitter=2,
		/// <summary>
		/// Particle       - use the particles from a given emitter in the system.
		///     The name of the emitter should be set in <Source/Target>Name.
		/// </summary>
		PEB2STM_Particle=3,
		/// <summary>
		/// Actor          - use the actor as the source/target.
		///     The name of the actor should be set in <Source/Target>Name.
		/// </summary>
		PEB2STM_Actor=4,
		PEB2STM_MAX=5,
		
	}
	
}
