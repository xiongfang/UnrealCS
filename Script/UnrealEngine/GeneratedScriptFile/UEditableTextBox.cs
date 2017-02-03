using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UEditableTextBox:UWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int HasError(IntPtr _this);
public  bool HasError()
{
	CheckIsValid();
	int ___ret = HasError(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ClearError(IntPtr _this);
public  void ClearError()
{
	CheckIsValid();
	ClearError(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetError(IntPtr _this,string InError);
public  void SetError(string InError)
{
	CheckIsValid();
	SetError(_this.Get(),InError);
	
}
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
