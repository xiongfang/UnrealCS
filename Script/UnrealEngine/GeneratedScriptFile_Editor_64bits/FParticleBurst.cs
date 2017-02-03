#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FParticleBurst
	{
		/// <summary>The number of particles to burst</summary>
		[FieldOffset(0)]
		public int Count;
		/// <summary>If >= 0, use as a range [CountLow..Count]</summary>
		[FieldOffset(4)]
		public int CountLow;
		/// <summary>The time at which to burst them (0..1: emitter lifetime)</summary>
		[FieldOffset(8)]
		public float Time;
		
	}
	
}
#endif
#endif
