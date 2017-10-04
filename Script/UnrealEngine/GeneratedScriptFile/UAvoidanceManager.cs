using System;
namespace UnrealEngine
{
	public partial class UAvoidanceManager:UObject
	{
		/// <summary>Only use if you want manual velocity planning. Will not ignore your own volume if you are registered.</summary>
		public extern FVector GetAvoidanceVelocity(FNavAvoidanceData AvoidanceData,float DeltaTime);
		/// <summary>Only use if you want manual velocity planning. Provide your AvoidanceUID in order to avoid colliding with yourself.</summary>
		public extern FVector GetAvoidanceVelocityIgnoringUID(FNavAvoidanceData AvoidanceData,float DeltaTime,int IgnoreThisUID);
		/// <summary>Calculate avoidance velocity for component (avoids collisions with the supplied component)</summary>
		public extern FVector GetAvoidanceVelocityForComponent(UMovementComponent MovementComp);
		/// <summary>
		/// Register with the given avoidance manager.
		/// @param AvoidanceWeight      When avoiding each other, actors divert course in proportion to their relative weights. Range is 0.0 to 1.0. Special: at 1.0, actor will not divert course at all.
		/// </summary>
		public extern bool RegisterMovementComponent(UMovementComponent MovementComp,float AvoidanceWeight=0.500000f);
		/// <summary>Get appropriate UID for use when reporting to this function or requesting RVO assistance.</summary>
		public extern int GetNewAvoidanceUID();
		/// <summary>Get the number of avoidance objects currently in the manager.</summary>
		public extern int GetObjectCount();
		/// <summary>How long an avoidance UID must not be updated before the system will put it back in the pool. Actual delay is up to 150% of this value.</summary>
		public float DefaultTimeToLive;
		
		/// <summary>How long to stay on course (barring collision) after making an avoidance move</summary>
		public float LockTimeAfterAvoid;
		
		/// <summary>How long to stay on course (barring collision) after making an unobstructed move (should be > 0.0, but can be less than a full frame)</summary>
		public float LockTimeAfterClean;
		
		/// <summary>This is how far forward in time (seconds) we extend our velocity cones and thus our prediction</summary>
		public float DeltaTimeToPredict;
		
		/// <summary>Multiply the radius of all STORED avoidance objects by this value to allow a little extra room for avoidance maneuvers.</summary>
		public float ArtificialRadiusExpansion;
		
		/// <summary>Deprecated - use HeightCheckMargin, generally a much smaller value.</summary>
		public float TestHeightDifference;
		
		/// <summary>Allowable height margin between obstacles and agents. This is over and above the difference in agent heights.</summary>
		public float HeightCheckMargin;
		
		
	}
	
}
