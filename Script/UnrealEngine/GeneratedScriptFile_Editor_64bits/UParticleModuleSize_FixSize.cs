#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSize
	{
		static readonly int StartSize__Offset;
		/// <summary>
		/// The initial size that should be used for a particle.
		/// The value is retrieved using the EmitterTime during the spawn of a particle.
		/// It is added to the Size and BaseSize fields of the spawning particle.
		/// </summary>
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
