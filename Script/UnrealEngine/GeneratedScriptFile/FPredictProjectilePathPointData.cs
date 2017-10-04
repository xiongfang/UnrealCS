using System;
namespace UnrealEngine
{
	/// <summary>Data about a single point in a projectile path trace.</summary>
	public partial struct FPredictProjectilePathPointData
	{
		/// <summary>Location of this point</summary>
		public FVector Location;
		/// <summary>Velocity at this point</summary>
		public FVector Velocity;
		/// <summary>Elapsed time at this point from the start of the trace.</summary>
		public float Time;
		
	}
	
}
