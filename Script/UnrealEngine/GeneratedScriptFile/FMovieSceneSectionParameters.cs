using System;
namespace UnrealEngine
{
	public partial struct FMovieSceneSectionParameters
	{
		/// <summary>Number of seconds to skip at the beginning of the sub-sequence.</summary>
		public float StartOffset;
		/// <summary>Playback time scaling factor.</summary>
		public float TimeScale;
		/// <summary>Amount of time to evaluate the section before its actual physical start time.</summary>
		public float PrerollTime;
		/// <summary>Amount of time to evaluate the section after its actual physical end time.</summary>
		public float PostrollTime;
		
	}
	
}
