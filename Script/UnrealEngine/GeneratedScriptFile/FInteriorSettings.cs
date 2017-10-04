using System;
namespace UnrealEngine
{
	/// <summary>Struct encapsulating settings for interior areas.</summary>
	public partial struct FInteriorSettings
	{
		/// <summary>Whether these interior settings are the default values for the world</summary>
		public bool bIsWorldSettings;
		/// <summary>The desired volume of sounds outside the volume when the player is inside the volume</summary>
		public float ExteriorVolume;
		/// <summary>The time over which to interpolate from the current volume to the desired volume of sounds outside the volume when the player enters the volume</summary>
		public float ExteriorTime;
		/// <summary>The desired LPF frequency cutoff in hertz of sounds outside the volume when the player is inside the volume</summary>
		public float ExteriorLPF;
		/// <summary>The time over which to interpolate from the current LPF to the desired LPF of sounds outside the volume when the player enters the volume</summary>
		public float ExteriorLPFTime;
		/// <summary>The desired volume of sounds inside the volume when the player is outside the volume</summary>
		public float InteriorVolume;
		/// <summary>The time over which to interpolate from the current volume to the desired volume of sounds inside the volume when the player enters the volume</summary>
		public float InteriorTime;
		/// <summary>The desired LPF frequency cutoff in hertz of sounds inside  the volume when the player is outside the volume</summary>
		public float InteriorLPF;
		/// <summary>The time over which to interpolate from the current LPF to the desired LPF of sounds inside the volume when the player enters the volume</summary>
		public float InteriorLPFTime;
		
	}
	
}
