using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USubDSurfaceComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int SetMesh(IntPtr _this,IntPtr NewMesh);
/// <summary>Change the SubDSurface used by this instance.</summary>
public  bool SetMesh(USubDSurface NewMesh)
{
	CheckIsValid();
	int ___ret = SetMesh(_this.Get(),NewMesh);
	return ___ret!=0;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
