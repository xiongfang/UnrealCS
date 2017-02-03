#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRotation
	{
		static readonly int StartRotation__Offset;
		/// <summary>
		/// Initial rotation of the particle (1 = 360 degrees).
		/// The value is retrieved using the EmitterTime.
		/// </summary>
		public FRawDistributionFloat StartRotation
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartRotation__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartRotation__Offset, false);}
			
		}
		
		static UParticleModuleRotation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleRotation");
			StartRotation__Offset=GetPropertyOffset(NativeClassPtr,"StartRotation");
			
		}
		
	}
	
}
#endif
#endif
