using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMouseCursorBinding:UPropertyBinding 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetValue(IntPtr _this);
public  EMouseCursor GetValue()
{
	CheckIsValid();
	int ___ret = GetValue(_this.Get());
	return (EMouseCursor)___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
