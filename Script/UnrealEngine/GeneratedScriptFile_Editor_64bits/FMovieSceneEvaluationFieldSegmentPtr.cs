#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A pointer to a particular segment of a track held within an evaluation template</summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FMovieSceneEvaluationFieldSegmentPtr
	{
		/// <summary>The index of the segment within the track (see FMovieSceneEvaluationTrack::Segments)</summary>
		[FieldOffset(8)]
		public int SegmentIndex;
		/// <summary>The sequence ID that identifies to which sequence the track belongs</summary>
		[FieldOffset(0)]
		public FMovieSceneSequenceID SequenceID;
		/// <summary>The Identifier of the track inside the track map (see FMovieSceneEvaluationTemplate::Tracks)</summary>
		[FieldOffset(4)]
		public FMovieSceneTrackIdentifier TrackIdentifier;
		
	}
	
}
#endif
#endif
