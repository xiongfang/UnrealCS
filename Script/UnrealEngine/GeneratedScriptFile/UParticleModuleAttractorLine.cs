using System;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorLine:UParticleModuleAttractorBase
	{
		/// <summary>The first endpoint of the line.</summary>
		public FVector EndPoint0;
		
		/// <summary>The second endpoint of the line.</summary>
		public FVector EndPoint1;
		
		/// <summary>The range of the line attractor.</summary>
		public FRawDistributionFloat Range;
		
		/// <summary>The strength of the line attractor.</summary>
		public FRawDistributionFloat Strength;
		
		
	}
	
}
