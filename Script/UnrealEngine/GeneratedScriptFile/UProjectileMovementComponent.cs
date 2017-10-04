using System;
namespace UnrealEngine
{
	public partial class UProjectileMovementComponent:UMovementComponent
	{
		/// <summary>Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true).</summary>
		public extern virtual void StopSimulating(FHitResult HitResult);
		/// <summary>Sets the velocity to the new value, rotated into Actor space.</summary>
		public extern virtual void SetVelocityInLocalSpace(FVector NewVelocity);
		/// <summary>Initial speed of projectile. If greater than zero, this will override the initial Velocity value and instead treat Velocity as a direction.</summary>
		public float InitialSpeed;
		
		/// <summary>Limit on speed of projectile (0 means no limit).</summary>
		public float MaxSpeed;
		
		/// <summary>If true, this projectile will have its rotation updated each frame to match the direction of its velocity.</summary>
		public bool bRotationFollowsVelocity;
		
		/// <summary>If true, simple bounces will be simulated. Set this to false to stop simulating on contact.</summary>
		public bool bShouldBounce;
		
		/// <summary>
		/// If true, the initial Velocity is interpreted as being in local space upon startup.
		/// @see SetVelocityInLocalSpace()
		/// </summary>
		public bool bInitialVelocityInLocalSpace;
		
		/// <summary>
		/// If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.
		/// Objects that move in a straight line typically do *not* need to set this, as movement always uses continuous collision detection (sweeps) so collision is not missed.
		/// Sub-stepping is automatically enabled when under the effects of gravity or when homing towards a target.
		/// @see MaxSimulationTimeStep, MaxSimulationIterations
		/// </summary>
		public bool bForceSubStepping;
		
		/// <summary>
		/// If true, we will accelerate toward our homing target. HomingTargetComponent must be set after the projectile is spawned.
		/// @see HomingTargetComponent, HomingAccelerationMagnitude
		/// </summary>
		public bool bIsHomingProjectile;
		
		/// <summary>
		/// Controls the effects of friction on velocity parallel to the impact surface when bouncing.
		/// If true, friction will be modified based on the angle of impact, making friction higher for perpendicular impacts and lower for glancing impacts.
		/// If false, a bounce will retain a proportion of tangential velocity equal to (1.0 - Friction), acting as a "horizontal restitution".
		/// </summary>
		public bool bBounceAngleAffectsFriction;
		
		/// <summary>If true, projectile is sliding / rolling along a surface.</summary>
		public bool bIsSliding;
		
		/// <summary>Saved HitResult Time (0 to 1) from previous simulation step. Equal to 1.0 when there was no impact.</summary>
		public float PreviousHitTime;
		
		/// <summary>Saved HitResult Normal from previous simulation step that resulted in an impact. If PreviousHitTime is 1.0, then the hit was not in the last step.</summary>
		public FVector PreviousHitNormal;
		
		/// <summary>Custom gravity scale for this projectile. Set to 0 for no gravity.</summary>
		public float ProjectileGravityScale;
		
		/// <summary>Buoyancy of UpdatedComponent in fluid. 0.0=sinks as fast as in air, 1.0=neutral buoyancy</summary>
		public float Buoyancy;
		
		/// <summary>
		/// Percentage of velocity maintained after the bounce in the direction of the normal of impact (coefficient of restitution).
		/// 1.0 = no velocity lost, 0.0 = no bounce. Ignored if bShouldBounce is false.
		/// </summary>
		public float Bounciness;
		
		/// <summary>
		/// Coefficient of friction, affecting the resistance to sliding along a surface.
		/// Normal range is [0,1] : 0.0 = no friction, 1.0+ = very high friction.
		/// Also affects the percentage of velocity maintained after the bounce in the direction tangent to the normal of impact.
		/// Ignored if bShouldBounce is false.
		/// @see bBounceAngleAffectsFriction
		/// </summary>
		public float Friction;
		
		/// <summary>
		/// If velocity is below this threshold after a bounce, stops simulating and triggers the OnProjectileStop event.
		/// Ignored if bShouldBounce is false, in which case the projectile stops simulating on the first impact.
		/// @see StopSimulating(), OnProjectileStop
		/// </summary>
		public float BounceVelocityStopSimulatingThreshold;
		
		/// <summary>The magnitude of our acceleration towards the homing target. Overall velocity magnitude will still be limited by MaxSpeed.</summary>
		public float HomingAccelerationMagnitude;
		
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
