#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles triggering of particle emitters</summary>
	public partial class UMovieSceneParticleTrack
	{
		static readonly int ParticleSections__Offset;
		/// <summary>List of all particle sections.</summary>
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
