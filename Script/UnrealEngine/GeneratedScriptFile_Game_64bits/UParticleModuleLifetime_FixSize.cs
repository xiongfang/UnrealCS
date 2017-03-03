#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLifetime
	{
		static readonly int LifeTime__Offset;
		public FRawDistributionFloat LifeTime
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+LifeTime__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LifeTime__Offset, false);}
			
		}
		
		static UParticleModuleLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLifetime");
			LifeTime__Offset=GetPropertyOffset(NativeClassPtr,"LifeTime");
			
		}
		
	}
	
}
#endif
#endif
