using System;
namespace UnrealEngine
{
	public partial class UFloatingPawnMovement:UPawnMovementComponent
	{
		/// <summary>Maximum velocity magnitude allowed for the controlled Pawn.</summary>
		public float MaxSpeed;
		
		/// <summary>Acceleration applied by input (rate of change of velocity)</summary>
		public float Acceleration;
		
		/// <summary>Deceleration applied when there is no input (rate of change of velocity)</summary>
		public float Deceleration;
		
		/// <summary>
		/// Setting affecting extra force applied when changing direction, making turns have less drift and become more responsive.
		/// Velocity magnitude is not allowed to increase, that only happens due to normal acceleration. It may decrease with large direction changes.
		/// Larger values apply extra force to reach the target direction more quickly, while a zero value disables any extra turn force.
		/// </summary>
		public float TurningBoost;
		
		/// <summary>Set to true when a position correction is applied. Used to avoid recalculating velocity when this occurs.</summary>
		public bool bPositionCorrected;
		
		
	}
	
}
