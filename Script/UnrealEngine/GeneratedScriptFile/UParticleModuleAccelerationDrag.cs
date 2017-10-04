using System;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationDrag:UParticleModuleAccelerationBase
	{
		/// <summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
		public UDistributionFloat DragCoefficient;
		
		/// <summary>Per-particle drag coefficient. Evaluted using emitter time.</summary>
		public FRawDistributionFloat DragCoefficientRaw;
		
		
	}
	
}
