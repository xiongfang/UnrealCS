using System;
namespace UnrealEngine
{
	public partial class UMovieScenePropertyTrack:UMovieSceneNameableTrack
	{
		/// <summary>Name of the property being changed</summary>
		public FName PropertyName;
		
		/// <summary>Path to the property from the source object being changed</summary>
		public FString PropertyPath;
		
		
	}
	
}
