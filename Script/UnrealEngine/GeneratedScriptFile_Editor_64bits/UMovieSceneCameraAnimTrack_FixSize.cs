#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneCameraAnimTrack
	{
		static readonly int CameraAnimSections__Offset;
		/// <summary>List of all sections</summary>
		public TObjectArray<UMovieSceneSection>  CameraAnimSections
		{
					get{ CheckIsValid();return new TObjectArray<UMovieSceneSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CameraAnimSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CameraAnimSections__Offset, false);}
			
		}
		
		static UMovieSceneCameraAnimTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneCameraAnimTrack");
			CameraAnimSections__Offset=GetPropertyOffset(NativeClassPtr,"CameraAnimSections");
			
		}
		
	}
	
}
#endif
#endif
