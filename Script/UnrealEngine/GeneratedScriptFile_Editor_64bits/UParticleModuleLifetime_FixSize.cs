#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLifetime
	{
		static readonly int Lifetime__Offset;
		/// <summary>The lifetime of the particle, in seconds. Retrieved using the EmitterTime at the spawn of the particle.</summary>
		public FRawDistributionFloat Lifetime
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Lifetime__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Lifetime__Offset, false);}
			
		}
		
		static UParticleModuleLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLifetime");
			Lifetime__Offset=GetPropertyOffset(NativeClassPtr,"Lifetime");
			
		}
		
	}
	
}
#endif
#endif
