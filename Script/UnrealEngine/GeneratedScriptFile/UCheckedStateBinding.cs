using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCheckedStateBinding:UPropertyBinding 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetValue(IntPtr _this);
public  ECheckBoxState GetValue()
{
	CheckIsValid();
	int ___ret = GetValue(_this.Get());
	return (ECheckBoxState)___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
