using System;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationDragScaleOverLife:UParticleModuleAccelerationBase
	{
		/// <summary>Per-particle drag scale. Evaluted using particle relative time.</summary>
		public UDistributionFloat DragScale;
		
		/// <summary>Per-particle drag scale. Evaluted using particle relative time.</summary>
		public FRawDistributionFloat DragScaleRaw;
		
		
	}
	
}
