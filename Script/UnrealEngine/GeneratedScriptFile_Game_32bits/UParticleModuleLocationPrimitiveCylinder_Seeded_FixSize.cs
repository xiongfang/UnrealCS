#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveCylinder_Seeded
	{
		static readonly int RandomSeedInfo__Offset;
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get{ CheckIsValid();return (FParticleRandomSeedInfo)Marshal.PtrToStructure(_this.Get()+RandomSeedInfo__Offset, typeof(FParticleRandomSeedInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomSeedInfo__Offset, false);}
			
		}
		
		static UParticleModuleLocationPrimitiveCylinder_Seeded()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationPrimitiveCylinder_Seeded");
			RandomSeedInfo__Offset=GetPropertyOffset(NativeClassPtr,"RandomSeedInfo");
			
		}
		
	}
	
}
#endif
#endif
