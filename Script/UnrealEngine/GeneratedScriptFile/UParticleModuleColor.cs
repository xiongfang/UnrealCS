using System;
namespace UnrealEngine
{
	public partial class UParticleModuleColor:UParticleModuleColorBase
	{
		/// <summary>Initial color for a particle as a function of Emitter time.</summary>
		public FRawDistributionVector StartColor;
		
		/// <summary>Initial alpha for a particle as a function of Emitter time.</summary>
		public FRawDistributionFloat StartAlpha;
		
		/// <summary>If true, the alpha value will be clamped to the [0..1] range.</summary>
		public bool bClampAlpha;
		
		
	}
	
}
