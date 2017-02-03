#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FRawDistributionVector
	{
		[FieldOffset(40)]
		public float MinValue;
		[FieldOffset(44)]
		public float MaxValue;
		[FieldOffset(48)]
		public FVector MinValueVec;
		[FieldOffset(60)]
		public FVector MaxValueVec;
		[FieldOffset(0)]
		public FDistributionLookupTable Table;
		
	}
	
}
#endif
#endif
