using System;
namespace UnrealEngine
{
	/// <summary>Elements of data for sound group volume control</summary>
	public partial struct FSoundClassAdjuster
	{
		/// <summary>The sound class this adjuster affects.</summary>
		public USoundClass SoundClassObject;
		/// <summary>A multiplier applied to the volume.</summary>
		public float VolumeAdjuster;
		/// <summary>A multiplier applied to the pitch.</summary>
		public float PitchAdjuster;
		/// <summary>Set to true to apply this adjuster to all children of the sound class.</summary>
		public bool bApplyToChildren;
		/// <summary>A multiplier applied to VoiceCenterChannelVolume.</summary>
		public float VoiceCenterChannelVolumeAdjuster;
		
	}
	
}
