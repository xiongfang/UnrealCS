using System;
namespace UnrealEngine
{
	/// <summary>Structure containing information on a SoundMix to activate passively.</summary>
	public partial struct FPassiveSoundMixModifier
	{
		/// <summary>The SoundMix to activate</summary>
		public USoundMix SoundMix;
		/// <summary>Minimum volume level required to activate SoundMix. Below this value the SoundMix will not be active.</summary>
		public float MinVolumeThreshold;
		/// <summary>Maximum volume level required to activate SoundMix. Above this value the SoundMix will not be active.</summary>
		public float MaxVolumeThreshold;
		
	}
	
}
