#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveSphere
	{
		static readonly int StartRadius__Offset;
		public FRawDistributionFloat StartRadius
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartRadius__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartRadius__Offset, false);}
			
		}
		
		static UParticleModuleLocationPrimitiveSphere()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationPrimitiveSphere");
			StartRadius__Offset=GetPropertyOffset(NativeClassPtr,"StartRadius");
			
		}
		
	}
	
}
#endif
#endif
