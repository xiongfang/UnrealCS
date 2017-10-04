using System;
namespace UnrealEngine
{
	public partial class UParticleModuleVectorFieldScaleOverLife:UParticleModuleVectorFieldBase
	{
		/// <summary>Per-particle vector field scale. Evaluated using particle relative time.</summary>
		public UDistributionFloat VectorFieldScaleOverLife;
		
		/// <summary>Per-particle vector field scale. Evaluated using particle relative time.</summary>
		public FRawDistributionFloat VectorFieldScaleOverLifeRaw;
		
		
	}
	
}
