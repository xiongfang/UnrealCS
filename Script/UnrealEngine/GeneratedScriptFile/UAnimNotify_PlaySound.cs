using System;
namespace UnrealEngine
{
	public partial class UAnimNotify_PlaySound:UAnimNotify
	{
		/// <summary>Sound to Play</summary>
		public USoundBase Sound;
		
		/// <summary>Volume Multiplier</summary>
		public float VolumeMultiplier;
		
		/// <summary>Pitch Multiplier</summary>
		public float PitchMultiplier;
		
		/// <summary>If this sound should follow its owner</summary>
		public bool bFollow;
		
		/// <summary>Socket or bone name to attach sound to</summary>
		public FName AttachName;
		
		
	}
	
}
