#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FPassiveSoundMixModifier
	{
		[FieldOffset(8)]
		public float MinVolumeThreshold;
		[FieldOffset(12)]
		public float MaxVolumeThreshold;
		
	}
	
}
#endif
#endif
