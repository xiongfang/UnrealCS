#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraShakeTrack
	{
		static readonly int CameraShakeSections__Offset;
		/// <summary>List of all sections</summary>
		public TObjectArray<UMovieSceneSection>  CameraShakeSections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CameraShakeSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CameraShakeSections__Offset, false);}
			
		}
		
		static UMovieSceneCameraShakeTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraShakeTrack");
			CameraShakeSections__Offset=GetPropertyOffset(NativeClassPtr,"CameraShakeSections");
			
		}
		
	}
	
}
#endif
#endif
