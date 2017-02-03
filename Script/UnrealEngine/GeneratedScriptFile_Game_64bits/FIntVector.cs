#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FIntVector
	{
		[FieldOffset(0)]
		public int X;
		[FieldOffset(4)]
		public int Y;
		[FieldOffset(8)]
		public int Z;
		
	}
	
}
#endif
#endif
