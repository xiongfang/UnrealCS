using System;
namespace UnrealEngine
{
	public partial class UMovieSceneSection:UMovieSceneSignedObject
	{
		public FMovieSceneSectionEvalOptions EvalOptions;
		
		/// <summary>The start time of the section</summary>
		public float StartTime;
		
		/// <summary>The end time of the section</summary>
		public float EndTime;
		
		/// <summary>The row index that this section sits on</summary>
		public int RowIndex;
		
		/// <summary>This section's priority over overlapping sections</summary>
		public int OverlapPriority;
		
		/// <summary>Toggle whether this section is active/inactive</summary>
		public bool bIsActive;
		
		/// <summary>Toggle whether this section is locked/unlocked</summary>
		public bool bIsLocked;
		
		/// <summary>Toggle to set this section to be infinite</summary>
		public bool bIsInfinite;
		
		
	}
	
}
