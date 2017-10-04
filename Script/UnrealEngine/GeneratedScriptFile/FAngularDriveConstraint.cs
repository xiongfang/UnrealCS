using System;
namespace UnrealEngine
{
	/// <summary>Angular Drive</summary>
	public partial struct FAngularDriveConstraint
	{
		/// <summary>Controls the twist (roll) constraint drive between current orientation/velocity and target orientation/velocity. This is available as long as the twist limit is set to free or limited.</summary>
		public FConstraintDrive TwistDrive;
		/// <summary>Controls the cone constraint drive between current orientation/velocity and target orientation/velocity. This is available as long as there is at least one swing limit set to free or limited.</summary>
		public FConstraintDrive SwingDrive;
		/// <summary>Controls the SLERP (spherical lerp) drive between current orientation/velocity and target orientation/velocity. NOTE: This is only available when all three angular limits are either free or limited. Locking any angular limit will turn off the drive implicitly.</summary>
		public FConstraintDrive SlerpDrive;
		/// <summary>Target orientation relative to the the body reference frame.</summary>
		public FRotator OrientationTarget;
		/// <summary>Target angular velocity relative to the body reference frame.</summary>
		public FVector AngularVelocityTarget;
		/// <summary>Whether motors use SLERP (spherical lerp) or decompose into a Swing motor (cone constraints) and Twist motor (roll constraints). NOTE: SLERP will NOT work if any of the angular constraints are locked.</summary>
		public EAngularDriveMode AngularDriveMode;
		
	}
	
}
