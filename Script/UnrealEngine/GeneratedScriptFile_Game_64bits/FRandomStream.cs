#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FRandomStream
	{
		[FieldOffset(0)]
		public int InitialSeed;
		[FieldOffset(4)]
		public int Seed;
		
	}
	
}
#endif
#endif
