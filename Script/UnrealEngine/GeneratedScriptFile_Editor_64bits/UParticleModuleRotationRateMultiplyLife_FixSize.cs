#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationRateMultiplyLife
	{
		static readonly int LifeMultiplier__Offset;
		/// <summary>
		/// The scale factor that should be applied to the rotation rate.
		/// The value is retrieved using the RelativeTime of the particle.
		/// </summary>
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
