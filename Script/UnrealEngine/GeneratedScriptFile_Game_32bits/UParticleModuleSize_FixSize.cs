#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSize
	{
		static readonly int StartSize__Offset;
		public FRawDistributionVector StartSize
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartSize__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartSize__Offset, false);}
			
		}
		
		static UParticleModuleSize()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSize");
			StartSize__Offset=GetPropertyOffset(NativeClassPtr,"StartSize");
			
		}
		
	}
	
}
#endif
#endif
