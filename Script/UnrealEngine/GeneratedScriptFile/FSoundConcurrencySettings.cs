using System;
namespace UnrealEngine
{
	public partial struct FSoundConcurrencySettings
	{
		/// <summary>The max number of allowable concurrent active voices for voices playing in this concurrency group.</summary>
		public int MaxCount;
		/// <summary>Whether or not to limit the concurrency to per sound owner (i.e. the actor that plays the sound). If the sound doesn't have an owner, it falls back to global concurrency.</summary>
		public bool bLimitToOwner;
		/// <summary>Which concurrency resolution policy to use if max voice count is reached.</summary>
		public EMaxConcurrentResolutionRule ResolutionRule;
		/// <summary>
		/// The amount of attenuation to apply to older voice instances in this concurrency group. This reduces volume of older voices in a concurrency group as new voices play.
		/// AppliedVolumeScale = Math.Pow(DuckingScale, VoiceGeneration)
		/// </summary>
		public float VolumeScale;
		
	}
	
}
