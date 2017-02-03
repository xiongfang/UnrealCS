#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleEventGenerator
	{
		static readonly int Events__Offset;
		public TStructArray<FParticleEvent_GenerateInfo> Events
		{
			get{ CheckIsValid();return new TStructArray<FParticleEvent_GenerateInfo>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Events__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Events__Offset, false);}
			
		}
		
		static UParticleModuleEventGenerator()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleEventGenerator");
			Events__Offset=GetPropertyOffset(NativeClassPtr,"Events");
			
		}
		
	}
	
}
#endif
#endif
