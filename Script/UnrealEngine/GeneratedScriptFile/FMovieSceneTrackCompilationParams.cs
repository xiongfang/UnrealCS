using System;
namespace UnrealEngine
{
	/// <summary>Movie scene compilation parameters. Serialized items contribute to a compiled template's cached hash</summary>
	public partial struct FMovieSceneTrackCompilationParams
	{
		/// <summary>Whether we're generating for an editor preview, or for efficient runtime evaluation</summary>
		public bool bForEditorPreview;
		
	}
	
}
