using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPlatformInterfaceWebResponse:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static string GetHeaderValue(IntPtr _this,string HeaderName);
/// <summary>@return the value for the given header (or "" if no matching header)</summary>
public  string GetHeaderValue(string HeaderName)
{
	CheckIsValid();
	string ___ret = GetHeaderValue(_this.Get(),HeaderName);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetHeader(IntPtr _this,int HeaderIndex,out string Header,out string Value);
/// <summary>Retrieve the header and value for the given index of header/value pair</summary>
public  void GetHeader(int HeaderIndex,out string Header,out string Value)
{
	CheckIsValid();
	GetHeader(_this.Get(),HeaderIndex,out Header,out Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetNumHeaders(IntPtr _this);
/// <summary>@return the number of header/value pairs</summary>
public  int GetNumHeaders()
{
	CheckIsValid();
	int ___ret = GetNumHeaders(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
