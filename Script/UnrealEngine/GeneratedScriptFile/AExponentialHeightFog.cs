using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AExponentialHeightFog:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_bEnabled(IntPtr _this);
/// <summary>Replication Notification Callbacks</summary>
public  void OnRep_bEnabled()
{
	CheckIsValid();
	OnRep_bEnabled(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
