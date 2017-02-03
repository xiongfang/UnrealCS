#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FInt32Range
	{
		[FieldOffset(0)]
		public FInt32RangeBound LowerBound;
		[FieldOffset(8)]
		public FInt32RangeBound UpperBound;
		
	}
	
}
#endif
#endif
