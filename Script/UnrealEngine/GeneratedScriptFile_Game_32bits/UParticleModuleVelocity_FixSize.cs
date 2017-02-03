#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocity
	{
		static readonly int StartVelocity__Offset;
		public FRawDistributionVector StartVelocity
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartVelocity__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartVelocity__Offset, false);}
			
		}
		
		static readonly int StartVelocityRadial__Offset;
		public FRawDistributionFloat StartVelocityRadial
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartVelocityRadial__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartVelocityRadial__Offset, false);}
			
		}
		
		static UParticleModuleVelocity()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVelocity");
			StartVelocity__Offset=GetPropertyOffset(NativeClassPtr,"StartVelocity");
			StartVelocityRadial__Offset=GetPropertyOffset(NativeClassPtr,"StartVelocityRadial");
			
		}
		
	}
	
}
#endif
#endif
