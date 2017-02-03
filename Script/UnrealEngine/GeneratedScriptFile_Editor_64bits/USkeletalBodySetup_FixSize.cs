#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeletalBodySetup
	{
		static readonly int CurrentPhysicalAnimationProfile__Offset;
		/// <summary>dummy place for customization inside phat. Profiles are ordered dynamically and we need a static place for detail customization</summary>
		public FPhysicalAnimationProfile CurrentPhysicalAnimationProfile
		{
			get{ CheckIsValid();return (FPhysicalAnimationProfile)Marshal.PtrToStructure(_this.Get()+CurrentPhysicalAnimationProfile__Offset, typeof(FPhysicalAnimationProfile));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CurrentPhysicalAnimationProfile__Offset, false);}
			
		}
		
		static readonly int PhysicalAnimationData__Offset;
		public TStructArray<FPhysicalAnimationProfile> PhysicalAnimationData
		{
			get{ CheckIsValid();return new TStructArray<FPhysicalAnimationProfile>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PhysicalAnimationData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PhysicalAnimationData__Offset, false);}
			
		}
		
		static USkeletalBodySetup()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalBodySetup");
			CurrentPhysicalAnimationProfile__Offset=GetPropertyOffset(NativeClassPtr,"CurrentPhysicalAnimationProfile");
			PhysicalAnimationData__Offset=GetPropertyOffset(NativeClassPtr,"PhysicalAnimationData");
			
		}
		
	}
	
}
#endif
#endif
