#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationOverLifetime
	{
		static readonly int AccelOverLife__Offset;
		public FRawDistributionVector AccelOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+AccelOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AccelOverLife__Offset, false);}
			
		}
		
		static UParticleModuleAccelerationOverLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAccelerationOverLifetime");
			AccelOverLife__Offset=GetPropertyOffset(NativeClassPtr,"AccelOverLife");
			
		}
		
	}
	
}
#endif
#endif
