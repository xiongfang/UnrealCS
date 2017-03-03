#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneTrack
	{
		static readonly int EvalOptions__Offset;
		public FMovieSceneTrackEvalOptions EvalOptions
		{
			get{ CheckIsValid();return (FMovieSceneTrackEvalOptions)Marshal.PtrToStructure(_this.Get()+EvalOptions__Offset, typeof(FMovieSceneTrackEvalOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EvalOptions__Offset, false);}
			
		}
		
		static UMovieSceneTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneTrack");
			EvalOptions__Offset=GetPropertyOffset(NativeClassPtr,"EvalOptions");
			
		}
		
	}
	
}
#endif
#endif
