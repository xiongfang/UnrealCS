using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Determines what a particle system will do when all of it's emitters become insignificant.</summary>
	public enum EParticleSystemInsignificanceReaction:byte
	{
		/// <summary>Looping systems will DisableTick. Non-looping systems will Complete.</summary>
		Auto=0,
		/// <summary>The system will be considered complete and will auto destroy if desired etc.</summary>
		Complete=1,
		/// <summary>The system will simply stop ticking. Tick will be re-enabled when any emitters become significant again. This is useful for persistent fx such as environmental fx.</summary>
		DisableTick=2,
		/// <summary>As DisableTick but will also kill all particles.</summary>
		DisableTickAndKill=3,
		/// <summary>Hidden for now until I make it useful i.e. Killing particles saves memory.</summary>
		Num=4,
		EParticleSystemInsignificanceReaction_MAX=5,
		
	}
	
}
