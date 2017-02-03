#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationRate
	{
		static readonly int StartRotationRate__Offset;
		public FRawDistributionFloat StartRotationRate
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartRotationRate__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartRotationRate__Offset, false);}
			
		}
		
		static UParticleModuleRotationRate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleRotationRate");
			StartRotationRate__Offset=GetPropertyOffset(NativeClassPtr,"StartRotationRate");
			
		}
		
	}
	
}
#endif
#endif
