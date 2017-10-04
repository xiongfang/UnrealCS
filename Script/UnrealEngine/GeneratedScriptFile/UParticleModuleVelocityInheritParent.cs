using System;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityInheritParent:UParticleModuleVelocityBase
	{
		/// <summary>
		/// The scale to apply tot he parent velocity prior to adding it to the particle velocity during spawn.
		/// Value is retrieved using the EmitterTime of the emitter.
		/// </summary>
		public FRawDistributionVector Scale;
		
		
	}
	
}
