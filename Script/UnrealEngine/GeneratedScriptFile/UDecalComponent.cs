using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UDecalComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr CreateDynamicMaterialInstance(IntPtr _this);
/// <summary>Utility to allocate a new Dynamic Material Instance, set its parent to the currently applied material, and assign it</summary>
public  UMaterialInstanceDynamic CreateDynamicMaterialInstance()
{
	CheckIsValid();
	IntPtr ___ret = CreateDynamicMaterialInstance(_this.Get());
	if(___ret==IntPtr.Zero) return null; UMaterialInstanceDynamic ___ret2= new UMaterialInstanceDynamic(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetDecalMaterial(IntPtr _this);
/// <summary>Accessor for decal material</summary>
public  UMaterialInterface GetDecalMaterial()
{
	CheckIsValid();
	IntPtr ___ret = GetDecalMaterial(_this.Get());
	if(___ret==IntPtr.Zero) return null; UMaterialInterface ___ret2= new UMaterialInterface(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetDecalMaterial(IntPtr _this,IntPtr NewDecalMaterial);
/// <summary>setting decal material on decal component. This will force the decal to reattach</summary>
public  void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
{
	CheckIsValid();
	SetDecalMaterial(_this.Get(),NewDecalMaterial);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSortOrder(IntPtr _this,int Value);
/// <summary>Sets the sort order for the decal component. Higher values draw later (on top). This will force the decal to reattach</summary>
public  void SetSortOrder(int Value)
{
	CheckIsValid();
	SetSortOrder(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFadeOut(IntPtr _this,float StartDelay,float Duration,int DestroyOwnerAfterFade);
/// <summary>
/// Sets the decal's fade start time, duration and if the owning actor should be destroyed after the decal is fully faded out.
/// The default value of 0 for FadeStartDelay and FadeDuration makes the decal persistent. See DecalLifetimeOpacity material
/// node to control the look of "fading out."
/// @param StartDelay - Time in seconds to wait before beginning to fade out the decal.
/// @param Duration - Time in second for the decal to fade out.
/// @param DestroyOwnerAfterFade - Should the owning actor automatically be destroyed after it is completely faded out.
/// </summary>
public  void SetFadeOut(float StartDelay,float Duration,bool DestroyOwnerAfterFade=true)
{
	CheckIsValid();
	SetFadeOut(_this.Get(),StartDelay,Duration,DestroyOwnerAfterFade?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetFadeDuration(IntPtr _this);
public  float GetFadeDuration()
{
	CheckIsValid();
	float ___ret = GetFadeDuration(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetFadeStartDelay(IntPtr _this);
public  float GetFadeStartDelay()
{
	CheckIsValid();
	float ___ret = GetFadeStartDelay(_this.Get());
	return ___ret;
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
