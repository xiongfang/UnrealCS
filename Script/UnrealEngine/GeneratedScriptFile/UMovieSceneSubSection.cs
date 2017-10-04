using System;
namespace UnrealEngine
{
	public partial class UMovieSceneSubSection:UMovieSceneSection
	{
		public FMovieSceneSectionParameters Parameters;
		
		public float StartOffset;
		
		public float TimeScale;
		
		public float PrerollTime;
		
		/// <summary>
		/// Movie scene being played by this section.
		/// @todo Sequencer: Should this be lazy loaded?
		/// </summary>
		public UMovieSceneSequence SubSequence;
		
		/// <summary>Target name of sequence to try to record to (will record automatically to another if this already exists)</summary>
		public FString TargetSequenceName;
		
		/// <summary>Target path of sequence to record to</summary>
		public FDirectoryPath TargetPathToRecordTo;
		
		
	}
	
}
