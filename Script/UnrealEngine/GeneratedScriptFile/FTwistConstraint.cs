using System;
namespace UnrealEngine
{
	/// <summary>Angular roll constraint</summary>
	public partial struct FTwistConstraint
	{
		/// <summary>Symmetric angle of roll along the X-axis.</summary>
		public float TwistLimitDegrees;
		/// <summary>Indicates whether the Swing1 limit is used.</summary>
		public EAngularConstraintMotion TwistMotion;
		/// <summary>Stiffness of the soft constraint. Only used when Soft Constraint is on.</summary>
		public float Stiffness;
		/// <summary>Damping of the soft constraint. Only used when Soft Constraint is on.</summary>
		public float Damping;
		/// <summary>Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.</summary>
		public float Restitution;
		/// <summary>Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.</summary>
		public float ContactDistance;
		/// <summary>Whether we want to use a soft constraint (spring).</summary>
		public bool bSoftConstraint;
		
	}
	
}
