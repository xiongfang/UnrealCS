using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class USkyLightComponent:ULightComponentBase 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RecaptureSky(IntPtr _this);
/// <summary>
/// Recaptures the scene for the skylight.
/// This is useful for making sure the sky light is up to date after changing something in the world that it would capture.
/// Warning: this is very costly and will definitely cause a hitch.
/// </summary>
public  void RecaptureSky()
{
	CheckIsValid();
	RecaptureSky(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetMinOcclusion(IntPtr _this,float InMinOcclusion);
public  void SetMinOcclusion(float InMinOcclusion)
{
	CheckIsValid();
	SetMinOcclusion(_this.Get(),InMinOcclusion);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOcclusionTint(IntPtr _this,ref FColor InTint);
public  void SetOcclusionTint(FColor InTint)
{
	CheckIsValid();
	SetOcclusionTint(_this.Get(),ref InTint);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCubemapBlend(IntPtr _this,IntPtr SourceCubemap,IntPtr DestinationCubemap,float InBlendFraction);
/// <summary>
/// Creates sky lighting from a blend between two cubemaps, which is only valid when SourceType is set to SpecifiedCubemap.
/// This can be used to seamlessly transition sky lighting between different times of day.
/// The caller should continue to update the blend until BlendFraction is 0 or 1 to reduce rendering cost.
/// The caller is responsible for avoiding pops due to changing the source or destination.
/// </summary>
public  void SetCubemapBlend(UTextureCube SourceCubemap,UTextureCube DestinationCubemap,float InBlendFraction)
{
	CheckIsValid();
	SetCubemapBlend(_this.Get(),SourceCubemap,DestinationCubemap,InBlendFraction);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetCubemap(IntPtr _this,IntPtr NewCubemap);
/// <summary>Sets the cubemap used when SourceType is set to SpecifiedCubemap, and causes a skylight update on the next tick.</summary>
public  void SetCubemap(UTextureCube NewCubemap)
{
	CheckIsValid();
	SetCubemap(_this.Get(),NewCubemap);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetLightColor(IntPtr _this,ref FLinearColor NewLightColor);
/// <summary>Set color of the light</summary>
public  void SetLightColor(FLinearColor NewLightColor)
{
	CheckIsValid();
	SetLightColor(_this.Get(),ref NewLightColor);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIndirectLightingIntensity(IntPtr _this,float NewIntensity);
public  void SetIndirectLightingIntensity(float NewIntensity)
{
	CheckIsValid();
	SetIndirectLightingIntensity(_this.Get(),NewIntensity);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntensity(IntPtr _this,float NewIntensity);
public  void SetIntensity(float NewIntensity)
{
	CheckIsValid();
	SetIntensity(_this.Get(),NewIntensity);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
