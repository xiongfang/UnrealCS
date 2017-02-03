#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveSphere
	{
		static readonly int StartRadius__Offset;
		/// <summary>The radius of the sphere. Retrieved using EmitterTime.</summary>
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
