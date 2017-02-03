using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UVehicleAnimInstance:UAnimInstance 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetVehicle(IntPtr _this);
/// <summary>Makes a montage jump to the end of a named section.</summary>
public  AWheeledVehicle GetVehicle()
{
	CheckIsValid();
	IntPtr ___ret = GetVehicle(_this.Get());
	if(___ret==IntPtr.Zero) return null; AWheeledVehicle ___ret2= new AWheeledVehicle(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
