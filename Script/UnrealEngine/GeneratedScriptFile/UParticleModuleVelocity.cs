using System;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocity:UParticleModuleVelocityBase
	{
		/// <summary>
		/// The velocity to apply to a particle when it is spawned.
		/// Value is retrieved using the EmitterTime of the emitter.
		/// </summary>
		public FRawDistributionVector StartVelocity;
		
		/// <summary>
		/// The velocity to apply to a particle along its radial direction.
		/// Direction is determined by subtracting the location of the emitter from the particle location at spawn.
		/// Value is retrieved using the EmitterTime of the emitter.
		/// </summary>
		public FRawDistributionFloat StartVelocityRadial;
		
		
	}
	
}
