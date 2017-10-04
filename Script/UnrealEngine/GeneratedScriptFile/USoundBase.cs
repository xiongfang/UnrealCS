using System;
namespace UnrealEngine
{
	public partial class USoundBase:UObject
	{
		/// <summary>Sound class this sound belongs to</summary>
		public USoundClass SoundClassObject;
		
		/// <summary>Sound submix this sound belongs to</summary>
		public USoundSubmix SoundSubmixObject;
		
		/// <summary>When "stat sounds -debug" has been specified, draw this sound's attenuation shape when the sound is audible. For debugging purpose only.</summary>
		public bool bDebug;
		
		/// <summary>Whether or not to override the sound concurrency object with local concurrency settings.</summary>
		public bool bOverrideConcurrency;
		
		/// <summary>Whether or not to ignore focus on this sound.</summary>
		public bool bIgnoreFocus;
		
		/// <summary>If bOverridePlayback is false, the sound concurrency settings to use for this sound.</summary>
		public USoundConcurrency SoundConcurrencySettings;
		
		/// <summary>If bOverridePlayback is true, concurrency settings to use.</summary>
		public FSoundConcurrencySettings ConcurrencyOverrides;
		
		public EMaxConcurrentResolutionRule MaxConcurrentResolutionRule;
		
		/// <summary>Maximum number of times this sound can be played concurrently.</summary>
		public int MaxConcurrentPlayCount;
		
		/// <summary>Duration of sound in seconds.</summary>
		public float Duration;
		
		/// <summary>Attenuation settings package for the sound</summary>
		public USoundAttenuation AttenuationSettings;
		
		/// <summary>Sound priority (higher value is higher priority) used for concurrency resolution. This priority value is weighted against the final volume of the sound.</summary>
		public float Priority;
		
		/// <summary>The default amount of audio to send to the master reverb effect for this sound if reverb is enabled for the sound. This can be overridden by sound attenuation settings for 3d sounds.</summary>
		public float DefaultMasterReverbSendAmount;
		
		
	}
	
}
