using System;
namespace UnrealEngine
{
	/// <summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
	public partial struct FMovieSceneEditorData
	{
		/// <summary>User-defined working range in which the entire sequence should reside.</summary>
		public FFloatRange WorkingRange;
		/// <summary>The last view-range that the user was observing</summary>
		public FFloatRange ViewRange;
		
	}
	
}
