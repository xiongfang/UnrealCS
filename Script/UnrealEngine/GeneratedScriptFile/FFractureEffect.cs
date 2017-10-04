using System;
namespace UnrealEngine
{
	/// <summary>Struct used to hold effects for destructible damage events</summary>
	public partial struct FFractureEffect
	{
		/// <summary>Particle system effect to play at fracture location.</summary>
		public UParticleSystem ParticleSystem;
		/// <summary>Sound cue to play at fracture location.</summary>
		public USoundBase Sound;
		
	}
	
}
