using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UVehicleWheel:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetSuspensionOffset(IntPtr _this);
public  float GetSuspensionOffset()
{
	CheckIsValid();
	float ___ret = GetSuspensionOffset(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetRotationAngle(IntPtr _this);
public  float GetRotationAngle()
{
	CheckIsValid();
	float ___ret = GetRotationAngle(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetSteerAngle(IntPtr _this);
public  float GetSteerAngle()
{
	CheckIsValid();
	float ___ret = GetSteerAngle(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
