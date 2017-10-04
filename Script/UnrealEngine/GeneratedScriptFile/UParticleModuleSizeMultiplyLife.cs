using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSizeMultiplyLife:UParticleModuleSizeBase
	{
		/// <summary>
		/// The scale factor for the size that should be used for a particle.
		/// The value is retrieved using the RelativeTime of the particle during its update.
		/// </summary>
		public FRawDistributionVector LifeMultiplier;
		
		/// <summary>
		/// If true, the X-component of the scale factor will be applied to the particle size X-component.
		/// If false, the X-component is left unaltered.
		/// </summary>
		public bool MultiplyX;
		
		/// <summary>
		/// If true, the Y-component of the scale factor will be applied to the particle size Y-component.
		/// If false, the Y-component is left unaltered.
		/// </summary>
		public bool MultiplyY;
		
		/// <summary>
		/// If true, the Z-component of the scale factor will be applied to the particle size Z-component.
		/// If false, the Z-component is left unaltered.
		/// </summary>
		public bool MultiplyZ;
		
		
	}
	
}
