using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UAsyncTaskDownloadImage:UBlueprintAsyncActionBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr DownloadImage(IntPtr _this,string URL);
public static UAsyncTaskDownloadImage DownloadImage(string URL)
{
	IntPtr ___ret = DownloadImage(IntPtr.Zero,URL);
	if(___ret==IntPtr.Zero) return null; UAsyncTaskDownloadImage ___ret2= new UAsyncTaskDownloadImage(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
