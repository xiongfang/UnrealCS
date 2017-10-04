using System;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationOverLifetime:UParticleModuleAccelerationBase
	{
		/// <summary>
		/// The acceleration of the particle over its lifetime.
		/// Value is obtained using the RelativeTime of the partice.
		/// The current and base velocity values of the particle
		/// are then updated using the formula
		///         velocity += acceleration* DeltaTime
		/// where DeltaTime is the time passed since the last frame.
		/// </summary>
		public FRawDistributionVector AccelOverLife;
		
		
	}
	
}
