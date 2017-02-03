#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FRawDistributionFloat
	{
		[FieldOffset(28)]
		public float MinValue;
		[FieldOffset(32)]
		public float MaxValue;
		[FieldOffset(0)]
		public FDistributionLookupTable Table;
		
	}
	
}
#endif
#endif
