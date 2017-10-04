using System;
namespace UnrealEngine
{
	/// <summary>Distance constraint</summary>
	public partial struct FLinearConstraint
	{
		/// <summary>The distance allowed between between the two joint reference frames. Distance applies on all axes enabled (one axis means line, two axes implies circle, three axes implies sphere)</summary>
		public float Limit;
		/// <summary>Indicates the linear constraint applied along the X-axis. Free implies no constraint at all. Locked implies no movement along X is allowed. Limited implies the distance in the joint along all active axes must be less than the Distance provided.</summary>
		public ELinearConstraintMotion XMotion;
		/// <summary>Indicates the linear constraint applied along the X-axis. Free implies no constraint at all. Locked implies no movement along X is allowed. Limited implies the distance in the joint along all active axes must be less than the Distance provided.</summary>
		public ELinearConstraintMotion YMotion;
		/// <summary>Indicates the linear constraint applied along the X-axis. Free implies no constraint at all. Locked implies no movement along X is allowed. Limited implies the distance in the joint along all active axes must be less than the Distance provided.</summary>
		public ELinearConstraintMotion ZMotion;
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
