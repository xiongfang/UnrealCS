#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FRawDistributionVector
	{
		[FieldOffset(28)]
		public float MinValue;
		[FieldOffset(32)]
		public float MaxValue;
		[FieldOffset(36)]
		public FVector MinValueVec;
		[FieldOffset(48)]
		public FVector MaxValueVec;
		[FieldOffset(0)]
		public FDistributionLookupTable Table;
		
	}
	
}
#endif
#endif
