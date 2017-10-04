using System;
namespace UnrealEngine
{
	public partial struct FCachedMovieSceneEvaluationTemplate
	{
		public FMovieSceneTrackCompilationParams CachedCompilationParams;
		/// <summary>Evaluation field for efficient runtime evaluation</summary>
		public FMovieSceneEvaluationField EvaluationField;
		/// <summary>Map of all sequences found in this template (recursively)</summary>
		public FMovieSceneSequenceHierarchy Hierarchy;
		public FMovieSceneGenerationLedger Ledger;
		/// <summary>When set, this template contains legacy track instances that require the initialization of a legacy sequence instance</summary>
		public bool bHasLegacyTrackInstances;
		/// <summary>Primarily used in editor to keep stale tracks around during template regeneration to ensure we can call OnEndEvaluation on them.</summary>
		public bool bKeepStaleTracks;
		
	}
	
}
