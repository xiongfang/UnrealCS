using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCurveLinearColor:UCurveBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor GetLinearColorValue(IntPtr _this,float InTime);
public  FLinearColor GetLinearColorValue(float InTime)
{
	CheckIsValid();
	FLinearColor ___ret = GetLinearColorValue(_this.Get(),InTime);
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
