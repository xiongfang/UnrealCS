#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSequence
	{
		static readonly int EvaluationTemplate__Offset;
		public FCachedMovieSceneEvaluationTemplate EvaluationTemplate
		{
			get{ CheckIsValid();return (FCachedMovieSceneEvaluationTemplate)Marshal.PtrToStructure(_this.Get()+EvaluationTemplate__Offset, typeof(FCachedMovieSceneEvaluationTemplate));}
			
		}
		
		static readonly int TemplateParameters__Offset;
		public FMovieSceneTrackCompilationParams TemplateParameters
		{
			get{ CheckIsValid();return (FMovieSceneTrackCompilationParams)Marshal.PtrToStructure(_this.Get()+TemplateParameters__Offset, typeof(FMovieSceneTrackCompilationParams));}
			
		}
		
		static readonly int bParentContextsAreSignificant__Offset;
		public bool bParentContextsAreSignificant
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bParentContextsAreSignificant__Offset, 1, 0, 1, 255);}
			
		}
		
		static UMovieSceneSequence()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSequence");
			EvaluationTemplate__Offset=GetPropertyOffset(NativeClassPtr,"EvaluationTemplate");
			TemplateParameters__Offset=GetPropertyOffset(NativeClassPtr,"TemplateParameters");
			bParentContextsAreSignificant__Offset=GetPropertyOffset(NativeClassPtr,"bParentContextsAreSignificant");
			
		}
		
	}
	
}
#endif
#endif
