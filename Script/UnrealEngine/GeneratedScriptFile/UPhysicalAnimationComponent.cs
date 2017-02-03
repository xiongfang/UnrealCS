using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UPhysicalAnimationComponent:UActorComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyPhysicalAnimationProfileBelow(IntPtr _this,string BodyName,string ProfileName,int bIncludeSelf,int bClearNotFound);
/// <summary>
/// Applies the physical animation profile to the body given and all bodies below.
/// @param  BodyName                     The body from which we'd like to start applying the physical animation profile. Finds all bodies below in the skeleton hierarchy. None implies all bodies
/// @param  ProfileName          The physical animation profile we'd like to apply. For each body in the physics asset we search for physical animation settings with this name.
/// @param  bIncludeSelf         Whether to include the provided body name in the list of bodies we act on (useful to ignore for cases where a root has multiple children)
/// @param  bClearNotFound       If true, bodies without the given profile name will have any existing physical animation settings cleared. If false, bodies without the given profile name are left untouched.
/// </summary>
public  void ApplyPhysicalAnimationProfileBelow(string BodyName,string ProfileName,bool bIncludeSelf=true,bool bClearNotFound=false)
{
	CheckIsValid();
	ApplyPhysicalAnimationProfileBelow(_this.Get(),BodyName,ProfileName,bIncludeSelf?1:0,bClearNotFound?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetStrengthMultiplyer(IntPtr _this,float InStrengthMultiplyer);
/// <summary>Updates strength multiplyer and any active motors</summary>
public  void SetStrengthMultiplyer(float InStrengthMultiplyer)
{
	CheckIsValid();
	SetStrengthMultiplyer(_this.Get(),InStrengthMultiplyer);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyPhysicalAnimationSettingsBelow(IntPtr _this,string BodyName,ref FPhysicalAnimationData PhysicalAnimationData,int bIncludeSelf);
/// <summary>Applies the physical animation settings to the body given and all bodies below.</summary>
public  void ApplyPhysicalAnimationSettingsBelow(string BodyName,FPhysicalAnimationData PhysicalAnimationData,bool bIncludeSelf=true)
{
	CheckIsValid();
	ApplyPhysicalAnimationSettingsBelow(_this.Get(),BodyName,ref PhysicalAnimationData,bIncludeSelf?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyPhysicalAnimationSettings(IntPtr _this,string BodyName,ref FPhysicalAnimationData PhysicalAnimationData);
/// <summary>Applies the physical animation settings to the body given.</summary>
public  void ApplyPhysicalAnimationSettings(string BodyName,FPhysicalAnimationData PhysicalAnimationData)
{
	CheckIsValid();
	ApplyPhysicalAnimationSettings(_this.Get(),BodyName,ref PhysicalAnimationData);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetSkeletalMeshComponent(IntPtr _this,IntPtr InSkeletalMeshComponent);
/// <summary>Sets the skeletal mesh we are driving through physical animation. Will erase any existing physical animation data.</summary>
public  void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent)
{
	CheckIsValid();
	SetSkeletalMeshComponent(_this.Get(),InSkeletalMeshComponent);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
