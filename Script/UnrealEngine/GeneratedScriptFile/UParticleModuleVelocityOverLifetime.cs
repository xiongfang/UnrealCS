using System;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityOverLifetime:UParticleModuleVelocityBase
	{
		/// <summary>
		/// The scaling  value applied to the velocity.
		/// Value is retrieved using the RelativeTime of the particle.
		/// </summary>
		public FRawDistributionVector VelOverLife;
		
		/// <summary>
		/// If true, the velocity will be SET to the value from the above dist.
		/// If false, the velocity will be scaled by the above dist.
		/// </summary>
		public bool Absolute;
		
		
	}
	
}
