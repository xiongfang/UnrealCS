using System;
namespace UnrealEngine
{
	public partial class UPhysicalAnimationComponent:UActorComponent
	{
		/// <summary>
		/// Applies the physical animation profile to the body given and all bodies below.
		/// @param  BodyName                     The body from which we'd like to start applying the physical animation profile. Finds all bodies below in the skeleton hierarchy. None implies all bodies
		/// @param  ProfileName          The physical animation profile we'd like to apply. For each body in the physics asset we search for physical animation settings with this name.
		/// @param  bIncludeSelf         Whether to include the provided body name in the list of bodies we act on (useful to ignore for cases where a root has multiple children)
		/// @param  bClearNotFound       If true, bodies without the given profile name will have any existing physical animation settings cleared. If false, bodies without the given profile name are left untouched.
		/// </summary>
		public extern void ApplyPhysicalAnimationProfileBelow(FName BodyName,FName ProfileName,bool bIncludeSelf=true,bool bClearNotFound=false);
		/// <summary>Updates strength multiplyer and any active motors</summary>
		public extern void SetStrengthMultiplyer(float InStrengthMultiplyer);
		/// <summary>Applies the physical animation settings to the body given and all bodies below.</summary>
		public extern void ApplyPhysicalAnimationSettingsBelow(FName BodyName,FPhysicalAnimationData PhysicalAnimationData,bool bIncludeSelf=true);
		/// <summary>Applies the physical animation settings to the body given.</summary>
		public extern void ApplyPhysicalAnimationSettings(FName BodyName,FPhysicalAnimationData PhysicalAnimationData);
		/// <summary>Sets the skeletal mesh we are driving through physical animation. Will erase any existing physical animation data.</summary>
		public extern void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent);
		/// <summary>Muliplies the strength of any active motors. (can blend from 0-1 for example)</summary>
		public float StrengthMultiplyer;
		
		public USkeletalMeshComponent SkeletalMeshComponent;
		
		
	}
	
}
