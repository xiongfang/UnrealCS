#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FRawDistributionFloat
	{
		[FieldOffset(40)]
		public float MinValue;
		[FieldOffset(44)]
		public float MaxValue;
		[FieldOffset(0)]
		public FDistributionLookupTable Table;
		
	}
	
}
#endif
#endif
