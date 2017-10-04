using System;
namespace UnrealEngine
{
	public partial class UInterpToMovementComponent:UMovementComponent
	{
		/// <summary>Initialise the control points array. Call after adding control points if they are add after begin play .</summary>
		public extern void FinaliseControlPoints();
		/// <summary>Reset to start. Sets time to zero and direction to 1.</summary>
		public extern void RestartMovement(float InitialDirection=1.000000f);
		/// <summary>Clears the reference to UpdatedComponent, fires stop event, and stops ticking.</summary>
		public extern void StopSimulating(FHitResult HitResult);
		/// <summary>How long to take to move from the first point to the last (or vice versa)</summary>
		public float Duration;
		
		/// <summary>If true, will pause movement on impact. If false it will behave as if the end of the movement range was reached based on the BehaviourType.</summary>
		public bool bPauseOnImpact;
		
		/// <summary>
		/// If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.
		/// Objects that move in a straight line typically do *not* need to set this, as movement always uses continuous collision detection (sweeps) so collision is not missed.
		/// Sub-stepping is automatically enabled when under the effects of gravity or when homing towards a target.
		/// @see MaxSimulationTimeStep, MaxSimulationIterations
		/// </summary>
		public bool bForceSubStepping;
		
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationIterations, bForceSubStepping
		/// </summary>
		public float MaxSimulationTimeStep;
		
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationTimeStep, bForceSubStepping
		/// </summary>
		public int MaxSimulationIterations;
		
		
	}
	
}
