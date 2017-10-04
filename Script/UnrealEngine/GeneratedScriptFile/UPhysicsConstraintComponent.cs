using System;
namespace UnrealEngine
{
	public partial class UPhysicsConstraintComponent:USceneComponent
	{
		/// <summary>Retrieve the constraint force most recently applied to maintain this constraint. Returns 0 forces if the constraint is not initialized or broken.</summary>
		public extern void GetConstraintForce(out FVector OutLinearForce,out FVector OutAngularForce);
		/// <summary>If true, the collision between the two rigid bodies of the constraint will be disabled.</summary>
		public extern void SetDisableCollision(bool bDisableCollision);
		/// <summary>Pass in reference orientation in (maintains reference position). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
		public extern void SetConstraintReferenceOrientation(EConstraintFrame Frame,FVector PriAxis,FVector SecAxis);
		/// <summary>Pass in reference position in (maintains reference orientation). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
		public extern void SetConstraintReferencePosition(EConstraintFrame Frame,FVector RefPosition);
		/// <summary>Pass in reference frame in. If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
		public extern void SetConstraintReferenceFrame(EConstraintFrame Frame,FTransform RefFrame);
		/// <summary>Gets the current Swing2 of the constraint</summary>
		public extern float GetCurrentSwing2();
		/// <summary>Gets the current Swing1 of the constraint</summary>
		public extern float GetCurrentSwing1();
		/// <summary>Gets the current Angular Twist of the constraint</summary>
		public extern float GetCurrentTwist();
		/// <summary>
		/// Sets the Angular Twist Motion Type
		///      @param ConstraintType   New Constraint Type
		///      @param TwistLimitAngle  Size of limit in degrees
		/// </summary>
		public extern void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType,float TwistLimitAngle);
		/// <summary>
		/// Sets the Angular Swing2 Motion Type
		///      @param ConstraintType   New Constraint Type
		///      @param Swing2LimitAngle Size of limit in degrees
		/// </summary>
		public extern void SetAngularSwing2Limit(EAngularConstraintMotion MotionType,float Swing2LimitAngle);
		/// <summary>
		/// Sets the Angular Swing1 Motion Type
		///      @param ConstraintType   New Constraint Type
		///      @param Swing1LimitAngle Size of limit in degrees
		/// </summary>
		public extern void SetAngularSwing1Limit(EAngularConstraintMotion MotionType,float Swing1LimitAngle);
		/// <summary>
		/// Sets the LinearZ Motion Type
		///      @param ConstraintType   New Constraint Type
		///      @param LimitSize                Size of limit
		/// </summary>
		public extern void SetLinearZLimit(ELinearConstraintMotion ConstraintType,float LimitSize);
		/// <summary>
		/// Sets the LinearY Motion Type
		///      @param ConstraintType   New Constraint Type
		///      @param LimitSize                Size of limit
		/// </summary>
		public extern void SetLinearYLimit(ELinearConstraintMotion ConstraintType,float LimitSize);
		/// <summary>
		/// Sets the LinearX Motion Type
		///      @param ConstraintType   New Constraint Type
		///      @param LimitSize                Size of limit
		/// </summary>
		public extern void SetLinearXLimit(ELinearConstraintMotion ConstraintType,float LimitSize);
		/// <summary>
		/// Sets the drive params for the angular drive.
		///     @param PositionStrength         Positional strength for the drive (stiffness)
		///     @param VelocityStrength         Velocity strength of the drive (damping)
		///     @param InForceLimit     Max force applied by the drive
		/// </summary>
		public extern void SetAngularDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit);
		/// <summary>
		/// Sets the target velocity for the angular drive.
		///     @param InVelTarget              Target velocity
		/// </summary>
		public extern void SetAngularVelocityTarget(FVector InVelTarget);
		/// <summary>
		/// Sets the target orientation for the angular drive.
		///     @param InPosTarget              Target orientation
		/// </summary>
		public extern void SetAngularOrientationTarget(FRotator InPosTarget);
		/// <summary>
		/// Sets the drive params for the linear drive.
		///     @param PositionStrength         Positional strength for the drive (stiffness)
		///     @param VelocityStrength         Velocity strength of the drive (damping)
		///     @param InForceLimit     Max force applied by the drive
		/// </summary>
		public extern void SetLinearDriveParams(float PositionStrength,float VelocityStrength,float InForceLimit);
		/// <summary>
		/// Sets the target velocity for the linear drive.
		///     @param InVelTarget              Target velocity
		/// </summary>
		public extern void SetLinearVelocityTarget(FVector InVelTarget);
		/// <summary>
		/// Sets the target position for the linear drive.
		///     @param InPosTarget              Target position
		/// </summary>
		public extern void SetLinearPositionTarget(FVector InPosTarget);
		/// <summary>
		/// Switches the angular drive mode between SLERP and Twist And Swing
		///      @param DriveMode        The angular drive mode to use. SLERP uses shortest spherical path, but will not work if any angular constraints are locked. Twist and Swing decomposes the path into the different angular degrees of freedom but may experience gimbal lock
		/// </summary>
		public extern void SetAngularDriveMode(EAngularDriveMode DriveMode);
		/// <summary>
		/// Enables/Disables the angular velocity slerp drive. Only relevant if the AngularDriveMode is set to SLERP
		///      @param bEnableSLERP             Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </summary>
		public extern void SetAngularVelocityDriveSLERP(bool bEnableSLERP);
		/// <summary>
		/// Enables/Disables angular velocity twist and swing drive. Only relevant if the AngularDriveMode is set to Twist and Swing
		///      @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		///      @param bEnableTwistDrive        Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </summary>
		public extern void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive);
		/// <summary>
		/// Enables/Disables the angular orientation slerp drive. Only relevant if the AngularDriveMode is set to SLERP
		///      @param bEnableSLERP             Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </summary>
		public extern void SetOrientationDriveSLERP(bool bEnableSLERP);
		/// <summary>
		/// Enables/Disables angular orientation drive. Only relevant if the AngularDriveMode is set to Twist and Swing
		///      @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		///      @param bEnableTwistDrive        Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </summary>
		public extern void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive,bool bEnableSwingDrive);
		/// <summary>
		/// Enables/Disables linear position drive
		///     @param bEnableDriveX    Indicates whether the drive for the X-Axis should be enabled
		///     @param bEnableDriveY    Indicates whether the drive for the Y-Axis should be enabled
		///     @param bEnableDriveZ    Indicates whether the drive for the Z-Axis should be enabled
		/// </summary>
		public extern void SetLinearVelocityDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ);
		/// <summary>
		/// Enables/Disables linear position drive
		///     @param bEnableDriveX    Indicates whether the drive for the X-Axis should be enabled
		///     @param bEnableDriveY    Indicates whether the drive for the Y-Axis should be enabled
		///     @param bEnableDriveZ    Indicates whether the drive for the Z-Axis should be enabled
		/// </summary>
		public extern void SetLinearPositionDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ);
		/// <summary>Break this constraint</summary>
		public extern void BreakConstraint();
		/// <summary>Directly specify component to connect. Will update frames based on current position.</summary>
		public extern void SetConstrainedComponents(UPrimitiveComponent Component1,FName BoneName1,UPrimitiveComponent Component2,FName BoneName2);
		/// <summary>Pointer to first Actor to constrain.</summary>
		public AActor ConstraintActor1;
		
		/// <summary>
		/// Name of first component property to constrain. If Actor1 is NULL, will look within Owner.
		/// If this is NULL, will use RootComponent of Actor1
		/// </summary>
		public FConstrainComponentPropName ComponentName1;
		
		/// <summary>Pointer to second Actor to constrain.</summary>
		public AActor ConstraintActor2;
		
		/// <summary>
		/// Name of second component property to constrain. If Actor2 is NULL, will look within Owner.
		/// If this is NULL, will use RootComponent of Actor2
		/// </summary>
		public FConstrainComponentPropName ComponentName2;
		
		public UPhysicsConstraintTemplate ConstraintSetup;
		
		/// <summary>All constraint settings</summary>
		public FConstraintInstance ConstraintInstance;
		
		
	}
	
}
