using System;
namespace UnrealEngine
{
	public partial class UNavMovementComponent:UMovementComponent
	{
		/// <summary>@return true if currently flying (moving through a non-fluid volume without resting on the ground)</summary>
		public extern virtual bool IsFlying();
		/// <summary>@return true if currently swimming (moving through a fluid volume)</summary>
		public extern virtual bool IsSwimming();
		/// <summary>@return true if currently moving on the ground (e.g. walking or driving)</summary>
		public extern virtual bool IsMovingOnGround();
		/// <summary>@return true if currently falling (not flying, in a non-fluid volume, and not on the ground)</summary>
		public extern virtual bool IsFalling();
		/// <summary>@return true if currently crouching</summary>
		public extern virtual bool IsCrouching();
		/// <summary>Stops movement immediately (reset velocity) but keeps following current path</summary>
		public extern void StopMovementKeepPathing();
		/// <summary>Stops applying further movement (usually zeros acceleration).</summary>
		public extern virtual void StopActiveMovement();
		/// <summary>Properties that define how the component can move.</summary>
		public FNavAgentProperties NavAgentProps;
		
		/// <summary>Braking distance override used with acceleration driven path following (bUseAccelerationForPaths)</summary>
		public float FixedPathBrakingDistance;
		
		/// <summary>If set to true NavAgentProps' radius and height will be updated with Owner's collision capsule size</summary>
		public bool bUpdateNavAgentWithOwnersCollision;
		
		/// <summary>If set, pathfollowing will control character movement via acceleration values. If false, it will set velocities directly.</summary>
		public bool bUseAccelerationForPaths;
		
		/// <summary>If set, FixedPathBrakingDistance will be used for path following deceleration</summary>
		public bool bUseFixedBrakingDistanceForPaths;
		
		/// <summary>Expresses runtime state of character's movement. Put all temporal changes to movement properties here</summary>
		public FMovementProperties MovementState;
		
		
	}
	
}
