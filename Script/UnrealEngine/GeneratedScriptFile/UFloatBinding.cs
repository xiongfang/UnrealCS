using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UFloatBinding:UPropertyBinding 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetValue(IntPtr _this);
public  float GetValue()
{
	CheckIsValid();
	float ___ret = GetValue(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
