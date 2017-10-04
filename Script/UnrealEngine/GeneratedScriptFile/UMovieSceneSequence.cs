using System;
namespace UnrealEngine
{
	public partial class UMovieSceneSequence:UMovieSceneSignedObject
	{
		public FCachedMovieSceneEvaluationTemplate EvaluationTemplate;
		
		public FMovieSceneTrackCompilationParams TemplateParameters;
		
		/// <summary>
		/// true if the result of GetParentObject is significant in object resolution for LocateBoundObjects.
		/// When true, if GetParentObject returns nullptr, the PlaybackContext will be used for LocateBoundObjects, other wise the object's parent will be used
		/// When false, the PlaybackContext will always be used for LocateBoundObjects
		/// </summary>
		public bool bParentContextsAreSignificant;
		
		
	}
	
}
