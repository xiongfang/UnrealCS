using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSize:UParticleModuleSizeBase
	{
		/// <summary>
		/// The initial size that should be used for a particle.
		/// The value is retrieved using the EmitterTime during the spawn of a particle.
		/// It is added to the Size and BaseSize fields of the spawning particle.
		/// </summary>
		public FRawDistributionVector StartSize;
		
		
	}
	
}
