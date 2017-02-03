using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UInvalidationBox:UContentWidget 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCanCache(IntPtr _this,int CanCache);
public  void SetCanCache(bool CanCache)
{
	CheckIsValid();
	SetCanCache(_this.Get(),CanCache?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetCanCache(IntPtr _this);
public  bool GetCanCache()
{
	CheckIsValid();
	int ___ret = GetCanCache(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void InvalidateCache(IntPtr _this);
public  void InvalidateCache()
{
	CheckIsValid();
	InvalidateCache(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
