using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSourceMovement:UParticleModuleLocationBase
	{
		/// <summary>
		/// The scale factor to apply to the source movement before adding to the particle location.
		/// The value is looked up using the particles RELATIVE time [0..1].
		/// </summary>
		public FRawDistributionVector SourceMovementScale;
		
		
	}
	
}
