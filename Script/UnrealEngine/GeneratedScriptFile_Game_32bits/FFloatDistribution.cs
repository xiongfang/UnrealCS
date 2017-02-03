#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FFloatDistribution
	{
		[FieldOffset(0)]
		public FDistributionLookupTable Table;
		
	}
	
}
#endif
#endif
