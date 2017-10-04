using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSpawn:UParticleModuleSpawnBase
	{
		/// <summary>The rate at which to spawn particles.</summary>
		public FRawDistributionFloat Rate;
		
		/// <summary>The scalar to apply to the rate.</summary>
		public FRawDistributionFloat RateScale;
		
		/// <summary>The method to utilize when burst-emitting particles.</summary>
		public EParticleBurstMethod ParticleBurstMethod;
		
		/// <summary>Scale all burst entries by this amount.</summary>
		public FRawDistributionFloat BurstScale;
		
		/// <summary>If true, the SpawnRate will be scaled by the global CVar r.EmitterSpawnRateScale</summary>
		public bool bApplyGlobalSpawnRateScale;
		
		
	}
	
}
