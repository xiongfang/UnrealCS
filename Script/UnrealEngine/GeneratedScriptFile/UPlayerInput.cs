using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPlayerInput:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearSmoothing(IntPtr _this);
/// <summary>Exec function to reset mouse smoothing values</summary>
public  void ClearSmoothing()
{
	CheckIsValid();
	ClearSmoothing(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvertAxis(IntPtr _this,string AxisName);
/// <summary>Exec function to invert an axis mapping</summary>
public  void InvertAxis(string AxisName)
{
	CheckIsValid();
	InvertAxis(_this.Get(),AxisName);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvertAxisKey(IntPtr _this,ref FKey AxisKey);
/// <summary>Exec function to invert an axis key</summary>
public  void InvertAxisKey(FKey AxisKey)
{
	CheckIsValid();
	InvertAxisKey(_this.Get(),ref AxisKey);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBind(IntPtr _this,string BindName,string Command);
/// <summary>Exec function to add a debug exec command</summary>
public  void SetBind(string BindName,string Command)
{
	CheckIsValid();
	SetBind(_this.Get(),BindName,Command);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMouseSensitivity(IntPtr _this,float Sensitivity);
/// <summary>Exec function to change the mouse sensitivity</summary>
public  void SetMouseSensitivity(float Sensitivity)
{
	CheckIsValid();
	SetMouseSensitivity(_this.Get(),Sensitivity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
