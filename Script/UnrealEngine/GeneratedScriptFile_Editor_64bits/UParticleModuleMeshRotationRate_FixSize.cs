#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleMeshRotationRate
	{
		static readonly int StartRotationRate__Offset;
		/// <summary>
		/// Initial rotation rate, in rotations per second.
		/// The value is retrieved using the EmitterTime.
		/// </summary>
		public FRawDistributionVector StartRotationRate
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartRotationRate__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartRotationRate__Offset, false);}
			
		}
		
		static UParticleModuleMeshRotationRate()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleMeshRotationRate");
			StartRotationRate__Offset=GetPropertyOffset(NativeClassPtr,"StartRotationRate");
			
		}
		
	}
	
}
#endif
#endif
