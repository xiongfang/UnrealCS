#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityInheritParent
	{
		static readonly int Scale__Offset;
		public FRawDistributionVector Scale
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Scale__Offset, false);}
			
		}
		
		static UParticleModuleVelocityInheritParent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVelocityInheritParent");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			
		}
		
	}
	
}
#endif
#endif
