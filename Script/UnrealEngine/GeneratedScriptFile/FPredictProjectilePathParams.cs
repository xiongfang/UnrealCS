using System;
namespace UnrealEngine
{
	/// <summary>Input parameters to PredictProjectilePath functions.</summary>
	public partial struct FPredictProjectilePathParams
	{
		/// <summary>Location of the start of the trace.</summary>
		public FVector StartLocation;
		/// <summary>Initial launch velocity at the start of the trace.</summary>
		public FVector LaunchVelocity;
		/// <summary>Whether to trace along the path looking for blocking collision and stopping at the first hit.</summary>
		public bool bTraceWithCollision;
		/// <summary>Projectile radius, used when tracing for collision. If <= 0, a line trace is used instead.</summary>
		public float ProjectileRadius;
		/// <summary>Maximum simulation time for the virtual projectile.</summary>
		public float MaxSimTime;
		/// <summary>Whether or not to use TraceChannel, if tracing with collision.</summary>
		public bool bTraceWithChannel;
		/// <summary>Trace channel to use, if tracing with collision.</summary>
		public ECollisionChannel TraceChannel;
		/// <summary>Determines size of each sub-step in the simulation (chopping up MaxSimTime). Recommended between 10 to 30 depending on desired quality versus performance.</summary>
		public float SimFrequency;
		/// <summary>Optional override of Gravity (if 0, uses WorldGravityZ).</summary>
		public float OverrideGravityZ;
		/// <summary>Debug drawing duration option.</summary>
		public EDrawDebugTrace DrawDebugType;
		/// <summary>Duration of debug lines (only relevant for DrawDebugType::Duration)</summary>
		public float DrawDebugTime;
		/// <summary>Trace against complex collision (triangles rather than simple primitives) if tracing with collision.</summary>
		public bool bTraceComplex;
		
	}
	
}
