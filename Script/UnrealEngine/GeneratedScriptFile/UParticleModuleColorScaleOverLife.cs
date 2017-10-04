using System;
namespace UnrealEngine
{
	public partial class UParticleModuleColorScaleOverLife:UParticleModuleColorBase
	{
		/// <summary>The scale factor for the color.</summary>
		public FRawDistributionVector ColorScaleOverLife;
		
		/// <summary>The scale factor for the alpha.</summary>
		public FRawDistributionFloat AlphaScaleOverLife;
		
		/// <summary>Whether it is EmitterTime or ParticleTime related.</summary>
		public bool bEmitterTime;
		
		
	}
	
}
