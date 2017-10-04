using System;
namespace UnrealEngine
{
	/// <summary>Container for properties of a physics constraint that can be easily swapped at runtime. This is useful for switching different setups when going from ragdoll to standup for example</summary>
	public partial struct FConstraintProfileProperties
	{
		/// <summary>Linear tolerance value in world units. If the distance error exceeds this tolerence limit, the body will be projected.</summary>
		public float ProjectionLinearTolerance;
		/// <summary>Angular tolerance value in world units. If the distance error exceeds this tolerence limit, the body will be projected.</summary>
		public float ProjectionAngularTolerance;
		/// <summary>Force needed to break the distance constraint.</summary>
		public float LinearBreakThreshold;
		/// <summary>Torque needed to break the joint.</summary>
		public float AngularBreakThreshold;
		public FLinearConstraint LinearLimit;
		public FConeConstraint ConeLimit;
		public FTwistConstraint TwistLimit;
		public FLinearDriveConstraint LinearDrive;
		public FAngularDriveConstraint AngularDrive;
		/// <summary>Disable collision between bodies joined by this constraint.</summary>
		public bool bDisableCollision;
		/// <summary>
		/// If distance error between bodies exceeds 0.1 units, or rotation error exceeds 10 degrees, body will be projected to fix this.
		/// For example a chain spinning too fast will have its elements appear detached due to velocity, this will project all bodies so they still appear attached to each other.
		/// </summary>
		public bool bEnableProjection;
		/// <summary>Whether it is possible to break the joint with angular force.</summary>
		public bool bAngularBreakable;
		/// <summary>Whether it is possible to break the joint with linear force.</summary>
		public bool bLinearBreakable;
		
	}
	
}
