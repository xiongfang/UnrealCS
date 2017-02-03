using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPointLightComponent:ULightComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSourceLength(IntPtr _this,float NewValue);
public  void SetSourceLength(float NewValue)
{
	CheckIsValid();
	SetSourceLength(_this.Get(),NewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSourceRadius(IntPtr _this,float bNewValue);
public  void SetSourceRadius(float bNewValue)
{
	CheckIsValid();
	SetSourceRadius(_this.Get(),bNewValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLightFalloffExponent(IntPtr _this,float NewLightFalloffExponent);
public  void SetLightFalloffExponent(float NewLightFalloffExponent)
{
	CheckIsValid();
	SetLightFalloffExponent(_this.Get(),NewLightFalloffExponent);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAttenuationRadius(IntPtr _this,float NewRadius);
public  void SetAttenuationRadius(float NewRadius)
{
	CheckIsValid();
	SetAttenuationRadius(_this.Get(),NewRadius);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
