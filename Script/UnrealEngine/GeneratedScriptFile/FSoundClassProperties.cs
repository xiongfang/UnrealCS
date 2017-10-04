using System;
namespace UnrealEngine
{
	/// <summary>Structure containing configurable properties of a sound class.</summary>
	public partial struct FSoundClassProperties
	{
		/// <summary>Volume multiplier.</summary>
		public float Volume;
		/// <summary>Pitch multiplier.</summary>
		public float Pitch;
		/// <summary>The amount of stereo sounds to bleed to the rear speakers</summary>
		public float StereoBleed;
		/// <summary>The amount of a sound to bleed to the LFE channel</summary>
		public float LFEBleed;
		/// <summary>Voice center channel volume - Not a multiplier (no propagation)</summary>
		public float VoiceCenterChannelVolume;
		/// <summary>Volume of the radio filter effect</summary>
		public float RadioFilterVolume;
		/// <summary>Volume at which the radio filter kicks in</summary>
		public float RadioFilterVolumeThreshold;
		/// <summary>Sound mix voice - whether to apply audio effects</summary>
		public bool bApplyEffects;
		/// <summary>Whether to artificially prioritise the component to play</summary>
		public bool bAlwaysPlay;
		/// <summary>Whether or not this sound plays when the game is paused in the UI</summary>
		public bool bIsUISound;
		/// <summary>Whether or not this is music (propagates only if parent is true)</summary>
		public bool bIsMusic;
		/// <summary>Whether or not this sound class has reverb applied</summary>
		public bool bReverb;
		/// <summary>Amount of audio to send to master reverb effect for 2D sounds played with this sound class.</summary>
		public float Default2DReverbSendAmount;
		/// <summary>Whether or not this sound class forces sounds to the center channel</summary>
		public bool bCenterChannelOnly;
		/// <summary>Whether the Interior/Exterior volume and LPF modifiers should be applied</summary>
		public bool bApplyAmbientVolumes;
		/// <summary>Which output target the sound should be played through</summary>
		public EAudioOutputTarget OutputTarget;
		
	}
	
}
