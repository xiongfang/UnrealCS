using System;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationOverLifetime:UParticleModuleRotationBase
	{
		/// <summary>
		/// The rotation of the particle (1.0 = 360 degrees).
		/// The value is retrieved using the RelativeTime of the particle.
		/// </summary>
		public FRawDistributionFloat RotationOverLife;
		
		/// <summary>
		/// If true,  the particle rotation is multiplied by the value retrieved from RotationOverLife.
		/// If false, the particle rotation is incremented by the value retrieved from RotationOverLife.
		/// </summary>
		public bool Scale;
		
		
	}
	
}
