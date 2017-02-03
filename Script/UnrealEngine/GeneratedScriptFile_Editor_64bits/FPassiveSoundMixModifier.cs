#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure containing information on a SoundMix to activate passively.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FPassiveSoundMixModifier
	{
		/// <summary>The SoundMix to activate</summary>
		/// <summary>Minimum volume level required to activate SoundMix. Below this value the SoundMix will not be active.</summary>
		[FieldOffset(8)]
		public float MinVolumeThreshold;
		/// <summary>Maximum volume level required to activate SoundMix. Above this value the SoundMix will not be active.</summary>
		[FieldOffset(12)]
		public float MaxVolumeThreshold;
		
	}
	
}
#endif
#endif
