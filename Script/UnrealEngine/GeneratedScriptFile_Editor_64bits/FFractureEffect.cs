#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct used to hold effects for destructible damage events</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FFractureEffect
	{
		/// <summary>Particle system effect to play at fracture location.</summary>
		/// <summary>Sound cue to play at fracture location.</summary>
		
	}
	
}
#endif
#endif
