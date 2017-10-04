using System;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationRateMultiplyLife:UParticleModuleRotationRateBase
	{
		/// <summary>
		/// The scale factor that should be applied to the rotation rate.
		/// The value is retrieved using the RelativeTime of the particle.
		/// </summary>
		public FRawDistributionFloat LifeMultiplier;
		
		
	}
	
}
