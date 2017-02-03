#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Properties that may be set for all chunks at a particular depth in the fracture hierarchy.</summary>
	[StructLayout(LayoutKind.Explicit,Size=1)]
	public partial struct FDestructibleDepthParameters
	{
		/// <summary>Chunks up to the depth DefaultImpactDamageDepth will take impact damage, unless one of the override options (see EImpactDamageOverride) is chosen.</summary>
		[FieldOffset(0)]
		public EImpactDamageOverride ImpactDamageOverride;
		
	}
	
}
#endif
#endif
