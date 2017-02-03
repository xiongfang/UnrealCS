#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FParticleBurst
	{
		[FieldOffset(0)]
		public int Count;
		[FieldOffset(4)]
		public int CountLow;
		[FieldOffset(8)]
		public float Time;
		
	}
	
}
#endif
#endif
