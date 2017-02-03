#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FFloatDistribution
	{
		[FieldOffset(0)]
		public FDistributionLookupTable Table;
		
	}
	
}
#endif
#endif
