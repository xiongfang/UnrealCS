using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USimpleWheeledVehicleMovementComponent:UWheeledVehicleMovementComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSteerAngle(IntPtr _this,float SteerAngle,int WheelIndex);
/// <summary>Set the steer angle (in degrees) to be applied to a specific wheel</summary>
public  void SetSteerAngle(float SteerAngle,int WheelIndex)
{
	CheckIsValid();
	SetSteerAngle(_this.Get(),SteerAngle,WheelIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDriveTorque(IntPtr _this,float DriveTorque,int WheelIndex);
/// <summary>Set the drive torque to be applied to a specific wheel</summary>
public  void SetDriveTorque(float DriveTorque,int WheelIndex)
{
	CheckIsValid();
	SetDriveTorque(_this.Get(),DriveTorque,WheelIndex);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBrakeTorque(IntPtr _this,float BrakeTorque,int WheelIndex);
/// <summary>Set the brake torque to be applied to a specific wheel</summary>
public  void SetBrakeTorque(float BrakeTorque,int WheelIndex)
{
	CheckIsValid();
	SetBrakeTorque(_this.Get(),BrakeTorque,WheelIndex);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
