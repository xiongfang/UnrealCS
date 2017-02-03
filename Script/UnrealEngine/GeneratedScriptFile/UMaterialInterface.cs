using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UMaterialInterface:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetPhysicalMaterial(IntPtr _this);
/// <summary>
/// Return a pointer to the physical material used by this material instance.
/// @return The physical material.
/// </summary>
public  UPhysicalMaterial GetPhysicalMaterial()
{
	CheckIsValid();
	IntPtr ___ret = GetPhysicalMaterial(_this.Get());
	if(___ret==IntPtr.Zero) return null; UPhysicalMaterial ___ret2= new UPhysicalMaterial(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetBaseMaterial(IntPtr _this);
/// <summary>Walks up parent chain and finds the base Material that this is an instance of. Just calls the virtual GetMaterial()</summary>
public  UMaterial GetBaseMaterial()
{
	CheckIsValid();
	IntPtr ___ret = GetBaseMaterial(_this.Get());
	if(___ret==IntPtr.Zero) return null; UMaterial ___ret2= new UMaterial(){ _this = ___ret }; return ___ret2;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
