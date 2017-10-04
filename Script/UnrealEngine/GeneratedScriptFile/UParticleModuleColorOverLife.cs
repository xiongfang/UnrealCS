using System;
namespace UnrealEngine
{
	public partial class UParticleModuleColorOverLife:UParticleModuleColorBase
	{
		/// <summary>The color to apply to the particle, as a function of the particle RelativeTime.</summary>
		public FRawDistributionVector ColorOverLife;
		
		/// <summary>The alpha to apply to the particle, as a function of the particle RelativeTime.</summary>
		public FRawDistributionFloat AlphaOverLife;
		
		/// <summary>If true, the alpha value will be clamped to the [0..1] range.</summary>
		public bool bClampAlpha;
		
		
	}
	
}
