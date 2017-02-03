using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBrushBinding:UPropertyBinding 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateBrush GetValue(IntPtr _this);
public  FSlateBrush GetValue()
{
	CheckIsValid();
	FSlateBrush ___ret = GetValue(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
