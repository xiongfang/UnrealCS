#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneParticleTrack
	{
		static readonly int ParticleSections__Offset;
		public TObjectArray<UMovieSceneSection>  ParticleSections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ParticleSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ParticleSections__Offset, false);}
			
		}
		
		static UMovieSceneParticleTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneParticleTrack");
			ParticleSections__Offset=GetPropertyOffset(NativeClassPtr,"ParticleSections");
			
		}
		
	}
	
}
#endif
#endif
