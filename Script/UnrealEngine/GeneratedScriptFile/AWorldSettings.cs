using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class AWorldSettings:AInfo 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void OnRep_WorldGravityZ(IntPtr _this);
public  void OnRep_WorldGravityZ()
{
	CheckIsValid();
	OnRep_WorldGravityZ(_this.Get());
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
