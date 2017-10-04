using System;
namespace UnrealEngine
{
	public partial class USoundCue:USoundBase
	{
		/// <summary>Indicates whether attenuation should use the Attenuation Overrides or the Attenuation Settings asset</summary>
		public bool bOverrideAttenuation;
		
		public USoundNode FirstNode;
		
		/// <summary>Volume multiplier for the Sound Cue</summary>
		public float VolumeMultiplier;
		
		/// <summary>Pitch multiplier for the Sound Cue</summary>
		public float PitchMultiplier;
		
		/// <summary>Attenuation settings to use if Override Attenuation is set to true</summary>
		public FSoundAttenuationSettings AttenuationOverrides;
		
		public UEdGraph SoundCueGraph;
		
		
	}
	
}
