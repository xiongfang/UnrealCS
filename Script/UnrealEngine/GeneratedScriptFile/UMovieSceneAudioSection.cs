using System;
namespace UnrealEngine
{
	public partial class UMovieSceneAudioSection:UMovieSceneSection
	{
		/// <summary>The sound cue or wave that this section plays</summary>
		public USoundBase Sound;
		
		/// <summary>The offset into the beginning of the audio clip</summary>
		public float StartOffset;
		
		/// <summary>The absolute time that the sound starts playing at</summary>
		public float AudioStartTime;
		
		/// <summary>The amount which this audio is time dilated by</summary>
		public float AudioDilationFactor;
		
		/// <summary>The volume the sound will be played with.</summary>
		public float AudioVolume;
		
		/// <summary>The volume the sound will be played with.</summary>
		public FRichCurve SoundVolume;
		
		/// <summary>The pitch multiplier the sound will be played with.</summary>
		public FRichCurve PitchMultiplier;
		
		/// <summary>Whether to show the actual intensity of the wave on the thumbnail, as well as the smoothed RMS</summary>
		public bool bShowIntensity;
		
		public bool bSuppressSubtitles;
		
		
	}
	
}
