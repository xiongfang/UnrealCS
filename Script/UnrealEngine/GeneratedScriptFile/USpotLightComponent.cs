using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USpotLightComponent:UPointLightComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOuterConeAngle(IntPtr _this,float NewOuterConeAngle);
public  void SetOuterConeAngle(float NewOuterConeAngle)
{
	CheckIsValid();
	SetOuterConeAngle(_this.Get(),NewOuterConeAngle);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetInnerConeAngle(IntPtr _this,float NewInnerConeAngle);
public  void SetInnerConeAngle(float NewInnerConeAngle)
{
	CheckIsValid();
	SetInnerConeAngle(_this.Get(),NewInnerConeAngle);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
