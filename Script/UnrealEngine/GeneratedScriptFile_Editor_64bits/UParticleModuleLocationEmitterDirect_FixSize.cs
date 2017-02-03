#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationEmitterDirect
	{
		static readonly int EmitterName__Offset;
		/// <summary>The name of the emitter to use as a source for the location of the particles.</summary>
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
