#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FWeightedBlendable
	{
		[FieldOffset(0)]
		public float Weight;
		
	}
	
}
#endif
#endif
