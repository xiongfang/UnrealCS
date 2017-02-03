#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraShakeTrack
	{
		static readonly int CameraShakeSections__Offset;
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
