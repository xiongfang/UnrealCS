using System;
namespace UnrealEngine
{
	public partial class UWidgetAnimation:UMovieSceneSequence
	{
		/// <summary>
		/// Get the end time of this animation.
		/// @return End time in seconds.
		/// @see GetStartTime
		/// </summary>
		public extern float GetEndTime();
		/// <summary>
		/// Get the start time of this animation.
		/// @return Start time in seconds.
		/// @see GetEndTime
		/// </summary>
		public extern float GetStartTime();
		/// <summary>Pointer to the movie scene that controls this animation.</summary>
		public UMovieScene MovieScene;
		
		
	}
	
}
