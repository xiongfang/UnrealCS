#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FPassiveSoundMixModifier
	{
		[FieldOffset(4)]
		public float MinVolumeThreshold;
		[FieldOffset(8)]
		public float MaxVolumeThreshold;
		
	}
	
}
#endif
#endif
