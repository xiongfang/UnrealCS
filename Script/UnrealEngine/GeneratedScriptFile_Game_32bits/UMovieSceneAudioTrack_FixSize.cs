#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneAudioTrack
	{
		static readonly int AudioSections__Offset;
		public TObjectArray<UMovieSceneSection>  AudioSections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AudioSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AudioSections__Offset, false);}
			
		}
		
		static UMovieSceneAudioTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneAudioTrack");
			AudioSections__Offset=GetPropertyOffset(NativeClassPtr,"AudioSections");
			
		}
		
	}
	
}
#endif
#endif
