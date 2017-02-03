#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles manipulation of audio.</summary>
	public partial class UMovieSceneAudioTrack
	{
		static readonly int AudioSections__Offset;
		/// <summary>List of all master audio sections</summary>
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
