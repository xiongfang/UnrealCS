using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UWheeledVehicleMovementComponent:UMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAvoidanceEnabled(IntPtr _this,int bEnable);
/// <summary>Change avoidance state and register with RVO manager if necessary</summary>
public  void SetAvoidanceEnabled(bool bEnable)
{
	CheckIsValid();
	SetAvoidanceEnabled(_this.Get(),bEnable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGroupsToIgnoreMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
public  void SetGroupsToIgnoreMask(FNavAvoidanceMask GroupMask)
{
	CheckIsValid();
	SetGroupsToIgnoreMask(_this.Get(),ref GroupMask);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGroupsToAvoidMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
public  void SetGroupsToAvoidMask(FNavAvoidanceMask GroupMask)
{
	CheckIsValid();
	SetGroupsToAvoidMask(_this.Get(),ref GroupMask);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAvoidanceGroupMask(IntPtr _this,ref FNavAvoidanceMask GroupMask);
public  void SetAvoidanceGroupMask(FNavAvoidanceMask GroupMask)
{
	CheckIsValid();
	SetAvoidanceGroupMask(_this.Get(),ref GroupMask);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetUseAutoGears(IntPtr _this);
/// <summary>Are gears being changed automatically?</summary>
public  bool GetUseAutoGears()
{
	CheckIsValid();
	int ___ret = GetUseAutoGears(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetTargetGear(IntPtr _this);
/// <summary>Get target gear</summary>
public  int GetTargetGear()
{
	CheckIsValid();
	int ___ret = GetTargetGear(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCurrentGear(IntPtr _this);
/// <summary>Get current gear</summary>
public  int GetCurrentGear()
{
	CheckIsValid();
	int ___ret = GetCurrentGear(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetEngineMaxRotationSpeed(IntPtr _this);
/// <summary>Get current engine's max rotation speed</summary>
public  float GetEngineMaxRotationSpeed()
{
	CheckIsValid();
	float ___ret = GetEngineMaxRotationSpeed(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetEngineRotationSpeed(IntPtr _this);
/// <summary>Get current engine's rotation speed</summary>
public  float GetEngineRotationSpeed()
{
	CheckIsValid();
	float ___ret = GetEngineRotationSpeed(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetForwardSpeed(IntPtr _this);
/// <summary>How fast the vehicle is moving forward</summary>
public  float GetForwardSpeed()
{
	CheckIsValid();
	float ___ret = GetForwardSpeed(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetUseAutoGears(IntPtr _this,int bUseAuto);
/// <summary>Set the flag that will be used to select auto-gears</summary>
public  void SetUseAutoGears(bool bUseAuto)
{
	CheckIsValid();
	SetUseAutoGears(_this.Get(),bUseAuto?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTargetGear(IntPtr _this,int GearNum,int bImmediate);
/// <summary>Set the user input for gear (-1 reverse, 0 neutral, 1+ forward)</summary>
public  void SetTargetGear(int GearNum,bool bImmediate)
{
	CheckIsValid();
	SetTargetGear(_this.Get(),GearNum,bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGearDown(IntPtr _this,int bNewGearDown);
/// <summary>Set the user input for gear down</summary>
public  void SetGearDown(bool bNewGearDown)
{
	CheckIsValid();
	SetGearDown(_this.Get(),bNewGearDown?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetGearUp(IntPtr _this,int bNewGearUp);
/// <summary>Set the user input for gear up</summary>
public  void SetGearUp(bool bNewGearUp)
{
	CheckIsValid();
	SetGearUp(_this.Get(),bNewGearUp?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetHandbrakeInput(IntPtr _this,int bNewHandbrake);
/// <summary>Set the user input for handbrake</summary>
public  void SetHandbrakeInput(bool bNewHandbrake)
{
	CheckIsValid();
	SetHandbrakeInput(_this.Get(),bNewHandbrake?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSteeringInput(IntPtr _this,float Steering);
/// <summary>Set the user input for the vehicle steering</summary>
public  void SetSteeringInput(float Steering)
{
	CheckIsValid();
	SetSteeringInput(_this.Get(),Steering);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrakeInput(IntPtr _this,float Brake);
/// <summary>Set the user input for the vehicle Brake</summary>
public  void SetBrakeInput(float Brake)
{
	CheckIsValid();
	SetBrakeInput(_this.Get(),Brake);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetThrottleInput(IntPtr _this,float Throttle);
/// <summary>Set the user input for the vehicle throttle</summary>
public  void SetThrottleInput(float Throttle)
{
	CheckIsValid();
	SetThrottleInput(_this.Get(),Throttle);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
