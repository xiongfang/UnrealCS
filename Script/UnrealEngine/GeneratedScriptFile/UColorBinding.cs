using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UColorBinding:UPropertyBinding 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FLinearColor GetLinearValue(IntPtr _this);
public  FLinearColor GetLinearValue()
{
	CheckIsValid();
	FLinearColor ___ret = GetLinearValue(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FSlateColor GetSlateValue(IntPtr _this);
public  FSlateColor GetSlateValue()
{
	CheckIsValid();
	FSlateColor ___ret = GetSlateValue(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
