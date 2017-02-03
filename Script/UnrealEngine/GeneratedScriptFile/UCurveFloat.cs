using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCurveFloat:UCurveBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetFloatValue(IntPtr _this,float InTime);
/// <summary>Evaluate this float curve at the specified time</summary>
public  float GetFloatValue(float InTime)
{
	CheckIsValid();
	float ___ret = GetFloatValue(_this.Get(),InTime);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
