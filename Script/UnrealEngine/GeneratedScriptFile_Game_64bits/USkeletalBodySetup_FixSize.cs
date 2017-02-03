#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USkeletalBodySetup
	{
		static readonly int PhysicalAnimationData__Offset;
		public TStructArray<FPhysicalAnimationProfile> PhysicalAnimationData
		{
			get{ CheckIsValid();return new TStructArray<FPhysicalAnimationProfile>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PhysicalAnimationData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PhysicalAnimationData__Offset, false);}
			
		}
		
		static USkeletalBodySetup()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SkeletalBodySetup");
			PhysicalAnimationData__Offset=GetPropertyOffset(NativeClassPtr,"PhysicalAnimationData");
			
		}
		
	}
	
}
#endif
#endif
