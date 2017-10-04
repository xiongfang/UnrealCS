using System;
namespace UnrealEngine
{
	/// <summary>Container for the result of a projectile path trace (using PredictProjectilePath).</summary>
	public partial struct FPredictProjectilePathResult
	{
		/// <summary>Info on the last point we tried to trace to, which may have been beyond the final hit.</summary>
		public FPredictProjectilePathPointData LastTraceDestination;
		/// <summary>Hit along the trace, if tracing with collision was enabled.</summary>
		public FHitResult HitResult;
		
	}
	
}
