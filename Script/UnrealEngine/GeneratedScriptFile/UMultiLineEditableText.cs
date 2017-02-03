using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMultiLineEditableText:UTextLayoutWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetText(IntPtr _this,string InText);
public  void SetText(string InText)
{
	CheckIsValid();
	SetText(_this.Get(),InText);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetText(IntPtr _this);
public  string GetText()
{
	CheckIsValid();
	string ___ret = GetText(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
