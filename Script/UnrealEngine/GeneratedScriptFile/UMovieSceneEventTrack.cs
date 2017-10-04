using System;
namespace UnrealEngine
{
	public partial class UMovieSceneEventTrack:UMovieSceneNameableTrack
	{
		/// <summary>If events should be fired when passed playing the sequence forwards.</summary>
		public bool bFireEventsWhenForwards;
		
		/// <summary>If events should be fired when passed playing the sequence backwards.</summary>
		public bool bFireEventsWhenBackwards;
		
		
	}
	
}
