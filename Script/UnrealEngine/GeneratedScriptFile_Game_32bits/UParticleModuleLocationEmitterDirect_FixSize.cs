#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationEmitterDirect
	{
		static readonly int EmitterName__Offset;
		public FName EmitterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+EmitterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterName__Offset, false);}
			
		}
		
		static UParticleModuleLocationEmitterDirect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocationEmitterDirect");
			EmitterName__Offset=GetPropertyOffset(NativeClassPtr,"EmitterName");
			
		}
		
	}
	
}
#endif
#endif
