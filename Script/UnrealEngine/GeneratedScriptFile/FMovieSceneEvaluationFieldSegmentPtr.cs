using System;
namespace UnrealEngine
{
	/// <summary>A pointer to a particular segment of a track held within an evaluation template</summary>
	public partial struct FMovieSceneEvaluationFieldSegmentPtr
	{
		/// <summary>The index of the segment within the track (see FMovieSceneEvaluationTrack::Segments)</summary>
		public int SegmentIndex;
		/// <summary>The sequence ID that identifies to which sequence the track belongs</summary>
		public FMovieSceneSequenceID SequenceID;
		/// <summary>The Identifier of the track inside the track map (see FMovieSceneEvaluationTemplate::Tracks)</summary>
		public FMovieSceneTrackIdentifier TrackIdentifier;
		
	}
	
}
