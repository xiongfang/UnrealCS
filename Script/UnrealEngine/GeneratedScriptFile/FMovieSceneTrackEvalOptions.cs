using System;
namespace UnrealEngine
{
	/// <summary>Generic evaluation options for any track</summary>
	public partial struct FMovieSceneTrackEvalOptions
	{
		/// <summary>true when the value of bEvaluateNearestSection is to be considered for the track</summary>
		public bool bCanEvaluateNearestSection;
		/// <summary>When evaluating empty space on a track, will evaluate the last position of the previous section (if possible), or the first position of the next section, in that order of preference.</summary>
		public bool bEvaluateNearestSection;
		/// <summary>Evaluate this track as part of its parent sub-section's pre-roll, if applicable</summary>
		public bool bEvaluateInPreroll;
		/// <summary>Evaluate this track as part of its parent sub-section's post-roll, if applicable</summary>
		public bool bEvaluateInPostroll;
		
	}
	
}
