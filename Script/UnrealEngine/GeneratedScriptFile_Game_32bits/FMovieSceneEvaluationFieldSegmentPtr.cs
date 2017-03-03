#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FMovieSceneEvaluationFieldSegmentPtr
	{
		[FieldOffset(8)]
		public int SegmentIndex;
		[FieldOffset(0)]
		public FMovieSceneSequenceID SequenceID;
		[FieldOffset(4)]
		public FMovieSceneTrackIdentifier TrackIdentifier;
		
	}
	
}
#endif
#endif
