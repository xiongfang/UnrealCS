#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for a track in a Movie Scene</summary>
	public partial class UMovieSceneTrack
	{
		static readonly int EvalOptions__Offset;
		/// <summary>General evaluation options for a given track</summary>
		public FMovieSceneTrackEvalOptions EvalOptions
		{
			get{ CheckIsValid();return (FMovieSceneTrackEvalOptions)Marshal.PtrToStructure(_this.Get()+EvalOptions__Offset, typeof(FMovieSceneTrackEvalOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EvalOptions__Offset, false);}
			
		}
		
		static readonly int TrackTint__Offset;
		/// <summary>This track's tint color</summary>
		public FColor TrackTint
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+TrackTint__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TrackTint__Offset, false);}
			
		}
		
		static UMovieSceneTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneTrack");
			EvalOptions__Offset=GetPropertyOffset(NativeClassPtr,"EvalOptions");
			TrackTint__Offset=GetPropertyOffset(NativeClassPtr,"TrackTint");
			
		}
		
	}
	
}
#endif
#endif
