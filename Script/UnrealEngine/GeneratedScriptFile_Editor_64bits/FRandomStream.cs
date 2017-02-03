#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Thread-safe RNG.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\RandomStream.h
	/// </summary>
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
