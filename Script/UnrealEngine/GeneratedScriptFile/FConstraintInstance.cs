using System;
namespace UnrealEngine
{
	/// <summary>Container for a physics representation of an object.</summary>
	public partial struct FConstraintInstance
	{
		/// <summary>Name of bone that this joint is associated with.</summary>
		public FName JointName;
		/// <summary>
		/// Name of first bone (body) that this constraint is connecting.
		/// This will be the 'child' bone in a PhysicsAsset.
		/// </summary>
		public FName ConstraintBone1;
		/// <summary>
		/// Name of second bone (body) that this constraint is connecting.
		/// This will be the 'parent' bone in a PhysicsAset.
		/// </summary>
		public FName ConstraintBone2;
		/// <summary>Location of constraint in Body1 reference frame.</summary>
		public FVector Pos1;
		/// <summary>Primary (twist) axis in Body1 reference frame.</summary>
		public FVector PriAxis1;
		/// <summary>Seconday axis in Body1 reference frame. Orthogonal to PriAxis1.</summary>
		public FVector SecAxis1;
		/// <summary>Location of constraint in Body2 reference frame.</summary>
		public FVector Pos2;
		/// <summary>Primary (twist) axis in Body2 reference frame.</summary>
		public FVector PriAxis2;
		/// <summary>Seconday axis in Body2 reference frame. Orthogonal to PriAxis2.</summary>
		public FVector SecAxis2;
		/// <summary>
		/// Specifies the angular offset between the two frames of reference. By default limit goes from (-Angle, +Angle)
		/// This allows you to bias the limit for swing1 swing2 and twist.
		/// </summary>
		public FRotator AngularRotationOffset;
		/// <summary>If true, linear limits scale using the absolute min of the 3d scale of the owning component</summary>
		public bool bScaleLinearLimits;
		/// <summary>Constraint Data (properties easily swapped at runtime based on different constraint profiles)</summary>
		public FConstraintProfileProperties ProfileInstance;
		public bool bDisableCollision;
		public bool bEnableProjection;
		public float ProjectionLinearTolerance;
		public float ProjectionAngularTolerance;
		public ELinearConstraintMotion LinearXMotion;
		public ELinearConstraintMotion LinearYMotion;
		public ELinearConstraintMotion LinearZMotion;
		public float LinearLimitSize;
		public bool bLinearLimitSoft;
		public float LinearLimitStiffness;
		public float LinearLimitDamping;
		public bool bLinearBreakable;
		public float LinearBreakThreshold;
		public EAngularConstraintMotion AngularSwing1Motion;
		public EAngularConstraintMotion AngularTwistMotion;
		public EAngularConstraintMotion AngularSwing2Motion;
		public bool bSwingLimitSoft;
		public bool bTwistLimitSoft;
		public float Swing1LimitAngle;
		public float TwistLimitAngle;
		public float Swing2LimitAngle;
		public float SwingLimitStiffness;
		public float SwingLimitDamping;
		public float TwistLimitStiffness;
		public float TwistLimitDamping;
		public bool bAngularBreakable;
		public float AngularBreakThreshold;
		public bool bLinearXPositionDrive;
		public bool bLinearXVelocityDrive;
		public bool bLinearYPositionDrive;
		public bool bLinearYVelocityDrive;
		public bool bLinearZPositionDrive;
		public bool bLinearZVelocityDrive;
		public bool bLinearPositionDrive;
		public bool bLinearVelocityDrive;
		public FVector LinearPositionTarget;
		public FVector LinearVelocityTarget;
		public float LinearDriveSpring;
		public float LinearDriveDamping;
		public float LinearDriveForceLimit;
		public bool bSwingPositionDrive;
		public bool bSwingVelocityDrive;
		public bool bTwistPositionDrive;
		public bool bTwistVelocityDrive;
		public bool bAngularSlerpDrive;
		public bool bAngularOrientationDrive;
		public bool bEnableSwingDrive;
		public bool bEnableTwistDrive;
		public bool bAngularVelocityDrive;
		public FQuat AngularPositionTarget;
		public EAngularDriveMode AngularDriveMode;
		public FRotator AngularOrientationTarget;
		public FVector AngularVelocityTarget;
		/// <summary>Revolutions per second</summary>
		public float AngularDriveSpring;
		public float AngularDriveDamping;
		public float AngularDriveForceLimit;
		
	}
	
}
