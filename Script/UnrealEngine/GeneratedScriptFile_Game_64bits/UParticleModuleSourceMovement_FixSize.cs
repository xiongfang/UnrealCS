#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSourceMovement
	{
		static readonly int SourceMovementScale__Offset;
		public FRawDistributionVector SourceMovementScale
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+SourceMovementScale__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceMovementScale__Offset, false);}
			
		}
		
		static UParticleModuleSourceMovement()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSourceMovement");
			SourceMovementScale__Offset=GetPropertyOffset(NativeClassPtr,"SourceMovementScale");
			
		}
		
	}
	
}
#endif
#endif
