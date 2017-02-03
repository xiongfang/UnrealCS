#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationRateMultiplyLife
	{
		static readonly int LifeMultiplier__Offset;
		public FRawDistributionFloat LifeMultiplier
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+LifeMultiplier__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LifeMultiplier__Offset, false);}
			
		}
		
		static UParticleModuleRotationRateMultiplyLife()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleRotationRateMultiplyLife");
			LifeMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"LifeMultiplier");
			
		}
		
	}
	
}
#endif
#endif
