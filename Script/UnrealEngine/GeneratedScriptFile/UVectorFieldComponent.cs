using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UVectorFieldComponent:UPrimitiveComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntensity(IntPtr _this,float NewIntensity);
/// <summary>
/// Set the intensity of the vector field.
/// @param NewIntensity - The new intensity of the vector field.
/// </summary>
public  void SetIntensity(float NewIntensity)
{
	CheckIsValid();
	SetIntensity(_this.Get(),NewIntensity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
