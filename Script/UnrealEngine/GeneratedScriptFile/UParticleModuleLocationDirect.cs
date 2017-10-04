using System;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationDirect:UParticleModuleLocationBase
	{
		/// <summary>
		/// The location of the particle at a give time. Retrieved using the particle RelativeTime.
		/// IMPORTANT: the particle location is set to this value, thereby over-writing any previous module impacts.
		/// </summary>
		public FRawDistributionVector Location;
		
		/// <summary>
		/// An offset to apply to the position retrieved from the Location calculation.
		/// The offset is retrieved using the EmitterTime.
		/// The offset will remain constant over the life of the particle.
		/// </summary>
		public FRawDistributionVector LocationOffset;
		
		/// <summary>Scales the velocity of the object at a given point in the time-line.</summary>
		public FRawDistributionVector ScaleFactor;
		
		/// <summary>Currently unused.</summary>
		public FRawDistributionVector Direction;
		
		
	}
	
}
