#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAcceleration
	{
		static readonly int Acceleration__Offset;
		public FRawDistributionVector Acceleration
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Acceleration__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Acceleration__Offset, false);}
			
		}
		
		static readonly int bApplyOwnerScale__Offset;
		public bool bApplyOwnerScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyOwnerScale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyOwnerScale__Offset, 1,0,1,1);}
			
		}
		
		static UParticleModuleAcceleration()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAcceleration");
			Acceleration__Offset=GetPropertyOffset(NativeClassPtr,"Acceleration");
			bApplyOwnerScale__Offset=GetPropertyOffset(NativeClassPtr,"bApplyOwnerScale");
			
		}
		
	}
	
}
#endif
#endif
