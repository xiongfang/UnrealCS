using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UCameraModifier:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void EnableModifier(IntPtr _this);
/// <summary>Enables this modifier.</summary>
public  void EnableModifier()
{
	CheckIsValid();
	EnableModifier(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void DisableModifier(IntPtr _this,int bImmediate);
/// <summary>
/// Disables this modifier.
/// @param  bImmediate  - true to disable with no blend out, false (default) to allow blend out
/// </summary>
public  void DisableModifier(bool bImmediate=false)
{
	CheckIsValid();
	DisableModifier(_this.Get(),bImmediate?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetViewTarget(IntPtr _this);
/// <summary>@return Returns the actor the camera is currently viewing.</summary>
public  AActor GetViewTarget()
{
	CheckIsValid();
	IntPtr ___ret = GetViewTarget(_this.Get());
	if(___ret==IntPtr.Zero) return null; AActor ___ret2= new AActor(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsDisabled(IntPtr _this);
/// <summary>@return Returns true if modifier is disabled, false otherwise.</summary>
public  bool IsDisabled()
{
	CheckIsValid();
	int ___ret = IsDisabled(_this.Get());
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
