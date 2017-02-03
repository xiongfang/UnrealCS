#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRotationRate
	{
		static readonly int StartRotationRate__Offset;
		/// <summary>
		/// Initial rotation rate, in rotations per second.
		/// The value is retrieved using the EmitterTime.
		/// </summary>
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
