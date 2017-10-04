using System;
namespace UnrealEngine
{
	public partial struct FDistanceDatum
	{
		/// <summary>
		/// The FadeInDistance at which to start hearing this sound.
		///        * If you want to hear the sound up close then setting this to 0 might be a good option.
		/// </summary>
		public float FadeInDistanceStart;
		/// <summary>The distance at which this sound has faded in completely.</summary>
		public float FadeInDistanceEnd;
		/// <summary>The distance at which this sound starts fading out.</summary>
		public float FadeOutDistanceStart;
		/// <summary>The distance at which this sound is no longer audible.</summary>
		public float FadeOutDistanceEnd;
		/// <summary>The volume for which this Input should be played.</summary>
		public float Volume;
		
	}
	
}
