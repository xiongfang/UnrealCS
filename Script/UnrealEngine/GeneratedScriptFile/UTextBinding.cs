using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UTextBinding:UPropertyBinding 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetStringValue(IntPtr _this);
public  string GetStringValue()
{
	CheckIsValid();
	string ___ret = GetStringValue(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetTextValue(IntPtr _this);
public  string GetTextValue()
{
	CheckIsValid();
	string ___ret = GetTextValue(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
