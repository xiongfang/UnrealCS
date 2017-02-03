using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicsConstraintComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetConstraintForce(IntPtr _this,out FVector OutLinearForce,out FVector OutAngularForce);
/// <summary>Retrieve the constraint force most recently applied to maintain this constraint. Returns 0 forces if the constraint is not initialized or broken.</summary>
public  void GetConstraintForce(out FVector OutLinearForce,out FVector OutAngularForce)
{
	CheckIsValid();
	GetConstraintForce(_this.Get(),out OutLinearForce,out OutAngularForce);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDisableCollision(IntPtr _this,int bDisableCollision);
/// <summary>If true, the collision between the two rigid bodies of the constraint will be disabled.</summary>
public  void SetDisableCollision(bool bDisableCollision)
{
	CheckIsValid();
	SetDisableCollision(_this.Get(),bDisableCollision?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintReferenceOrientation(IntPtr _this,int Frame,ref FVector PriAxis,ref FVector SecAxis);
/// <summary>Pass in reference orientation in (maintains reference position). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
public  void SetConstraintReferenceOrientation(EConstraintFrame Frame,FVector PriAxis,FVector SecAxis)
{
	CheckIsValid();
	SetConstraintReferenceOrientation(_this.Get(),(int)Frame,ref PriAxis,ref SecAxis);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintReferencePosition(IntPtr _this,int Frame,ref FVector RefPosition);
/// <summary>Pass in reference position in (maintains reference orientation). If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
public  void SetConstraintReferencePosition(EConstraintFrame Frame,FVector RefPosition)
{
	CheckIsValid();
	SetConstraintReferencePosition(_this.Get(),(int)Frame,ref RefPosition);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstraintReferenceFrame(IntPtr _this,int Frame,ref FTransform RefFrame);
/// <summary>Pass in reference frame in. If the constraint is currently active, this will set its active local pose. Otherwise the change will take affect in InitConstraint.</summary>
public  void SetConstraintReferenceFrame(EConstraintFrame Frame,FTransform RefFrame)
{
	CheckIsValid();
	SetConstraintReferenceFrame(_this.Get(),(int)Frame,ref RefFrame);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentSwing2(IntPtr _this);
/// <summary>Gets the current Swing2 of the constraint</summary>
public  float GetCurrentSwing2()
{
	CheckIsValid();
	float ___ret = GetCurrentSwing2(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentSwing1(IntPtr _this);
/// <summary>Gets the current Swing1 of the constraint</summary>
public  float GetCurrentSwing1()
{
	CheckIsValid();
	float ___ret = GetCurrentSwing1(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetCurrentTwist(IntPtr _this);
/// <summary>Gets the current Angular Twist of the constraint</summary>
public  float GetCurrentTwist()
{
	CheckIsValid();
	float ___ret = GetCurrentTwist(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularTwistLimit(IntPtr _this,int ConstraintType,float TwistLimitAngle);
/// <summary>
/// Sets the Angular Twist Motion Type
///      @param ConstraintType   New Constraint Type
///      @param TwistLimitAngle  Size of limit in degrees
/// </summary>
public  void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType,float TwistLimitAngle)
{
	CheckIsValid();
	SetAngularTwistLimit(_this.Get(),(int)ConstraintType,TwistLimitAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularSwing2Limit(IntPtr _this,int MotionType,float Swing2LimitAngle);
/// <summary>
/// Sets the Angular Swing2 Motion Type
///      @param ConstraintType   New Constraint Type
///      @param Swing2LimitAngle Size of limit in degrees
/// </summary>
public  void SetAngularSwing2Limit(EAngularConstraintMotion MotionType,float Swing2LimitAngle)
{
	CheckIsValid();
	SetAngularSwing2Limit(_this.Get(),(int)MotionType,Swing2LimitAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularSwing1Limit(IntPtr _this,int MotionType,float Swing1LimitAngle);
/// <summary>
/// Sets the Angular Swing1 Motion Type
///      @param ConstraintType   New Constraint Type
///      @param Swing1LimitAngle Size of limit in degrees
/// </summary>
public  void SetAngularSwing1Limit(EAngularConstraintMotion MotionType,float Swing1LimitAngle)
{
	CheckIsValid();
	SetAngularSwing1Limit(_this.Get(),(int)MotionType,Swing1LimitAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearZLimit(IntPtr _this,int ConstraintType,float LimitSize);
/// <summary>
/// Sets the LinearZ Motion Type
///      @param ConstraintType   New Constraint Type
///      @param LimitSize                Size of limit
/// </summary>
public  void SetLinearZLimit(ELinearConstraintMotion ConstraintType,float LimitSize)
{
	CheckIsValid();
	SetLinearZLimit(_this.Get(),(int)ConstraintType,LimitSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearYLimit(IntPtr _this,int ConstraintType,float LimitSize);
/// <summary>
/// Sets the LinearY Motion Type
///      @param ConstraintType   New Constraint Type
///      @param LimitSize                Size of limit
/// </summary>
public  void SetLinearYLimit(ELinearConstraintMotion ConstraintType,float LimitSize)
{
	CheckIsValid();
	SetLinearYLimit(_this.Get(),(int)ConstraintType,LimitSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearXLimit(IntPtr _this,int ConstraintType,float LimitSize);
/// <summary>
/// Sets the LinearX Motion Type
///      @param ConstraintType   New Constraint Type
///      @param LimitSize                Size of limit
/// </summary>
public  void SetLinearXLimit(ELinearConstraintMotion ConstraintType,float LimitSize)
{
	CheckIsValid();
	SetLinearXLimit(_this.Get(),(int)ConstraintType,LimitSize);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularDriveParams(IntPtr _this,float InSpring,float InDamping,float InForceLimit);
/// <summary>
/// Sets the drive params for the angular drive.
///     @param InSpring         Spring force for the drive
///     @param InDamping        Damping of the drive
///     @param InForceLimit     Max force applied by the drive
/// </summary>
public  void SetAngularDriveParams(float InSpring,float InDamping,float InForceLimit)
{
	CheckIsValid();
	SetAngularDriveParams(_this.Get(),InSpring,InDamping,InForceLimit);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularVelocityTarget(IntPtr _this,ref FVector InVelTarget);
/// <summary>
/// Sets the target velocity for the angular drive.
///     @param InVelTarget              Target velocity
/// </summary>
public  void SetAngularVelocityTarget(FVector InVelTarget)
{
	CheckIsValid();
	SetAngularVelocityTarget(_this.Get(),ref InVelTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularOrientationTarget(IntPtr _this,ref FRotator InPosTarget);
/// <summary>
/// Sets the target orientation for the angular drive.
///     @param InPosTarget              Target orientation
/// </summary>
public  void SetAngularOrientationTarget(FRotator InPosTarget)
{
	CheckIsValid();
	SetAngularOrientationTarget(_this.Get(),ref InPosTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearDriveParams(IntPtr _this,float InSpring,float InDamping,float InForceLimit);
/// <summary>
/// Sets the drive params for the linear drive.
///     @param InSpring         Spring force for the drive
///     @param InDamping        Damping of the drive
///     @param InForceLimit     Max force applied by the drive
/// </summary>
public  void SetLinearDriveParams(float InSpring,float InDamping,float InForceLimit)
{
	CheckIsValid();
	SetLinearDriveParams(_this.Get(),InSpring,InDamping,InForceLimit);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearVelocityTarget(IntPtr _this,ref FVector InVelTarget);
/// <summary>
/// Sets the target velocity for the linear drive.
///     @param InVelTarget              Target velocity
/// </summary>
public  void SetLinearVelocityTarget(FVector InVelTarget)
{
	CheckIsValid();
	SetLinearVelocityTarget(_this.Get(),ref InVelTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearPositionTarget(IntPtr _this,ref FVector InPosTarget);
/// <summary>
/// Sets the target position for the linear drive.
///     @param InPosTarget              Target position
/// </summary>
public  void SetLinearPositionTarget(FVector InPosTarget)
{
	CheckIsValid();
	SetLinearPositionTarget(_this.Get(),ref InPosTarget);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularVelocityDrive(IntPtr _this,int bEnableSwingDrive,int bEnableTwistDrive);
/// <summary>
/// Enables/Disables angular velocity drive
///     @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled
///     @param bEnableTwistDrive        Indicates whether the drive for the twit axis should be enabled
/// </summary>
public  void SetAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive)
{
	CheckIsValid();
	SetAngularVelocityDrive(_this.Get(),bEnableSwingDrive?1:0,bEnableTwistDrive?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAngularOrientationDrive(IntPtr _this,int bEnableSwingDrive,int bEnableTwistDrive);
/// <summary>
/// Enables/Disables angular orientation drive
///     @param bEnableSwingDrive        Indicates whether the drive for the swing axis should be enabled
///     @param bEnableTwistDrive        Indicates whether the drive for the twist axis should be enabled
/// </summary>
public  void SetAngularOrientationDrive(bool bEnableSwingDrive,bool bEnableTwistDrive)
{
	CheckIsValid();
	SetAngularOrientationDrive(_this.Get(),bEnableSwingDrive?1:0,bEnableTwistDrive?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearVelocityDrive(IntPtr _this,int bEnableDriveX,int bEnableDriveY,int bEnableDriveZ);
/// <summary>
/// Enables/Disables linear position drive
///     @param bEnableDriveX    Indicates whether the drive for the X-Axis should be enabled
///     @param bEnableDriveY    Indicates whether the drive for the Y-Axis should be enabled
///     @param bEnableDriveZ    Indicates whether the drive for the Z-Axis should be enabled
/// </summary>
public  void SetLinearVelocityDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ)
{
	CheckIsValid();
	SetLinearVelocityDrive(_this.Get(),bEnableDriveX?1:0,bEnableDriveY?1:0,bEnableDriveZ?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLinearPositionDrive(IntPtr _this,int bEnableDriveX,int bEnableDriveY,int bEnableDriveZ);
/// <summary>
/// Enables/Disables linear position drive
///     @param bEnableDriveX    Indicates whether the drive for the X-Axis should be enabled
///     @param bEnableDriveY    Indicates whether the drive for the Y-Axis should be enabled
///     @param bEnableDriveZ    Indicates whether the drive for the Z-Axis should be enabled
/// </summary>
public  void SetLinearPositionDrive(bool bEnableDriveX,bool bEnableDriveY,bool bEnableDriveZ)
{
	CheckIsValid();
	SetLinearPositionDrive(_this.Get(),bEnableDriveX?1:0,bEnableDriveY?1:0,bEnableDriveZ?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void BreakConstraint(IntPtr _this);
/// <summary>Break this constraint</summary>
public  void BreakConstraint()
{
	CheckIsValid();
	BreakConstraint(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetConstrainedComponents(IntPtr _this,IntPtr Component1,string BoneName1,IntPtr Component2,string BoneName2);
/// <summary>Directly specify component to connect. Will update frames based on current position.</summary>
public  void SetConstrainedComponents(UPrimitiveComponent Component1,string BoneName1,UPrimitiveComponent Component2,string BoneName2)
{
	CheckIsValid();
	SetConstrainedComponents(_this.Get(),Component1,BoneName1,Component2,BoneName2);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
