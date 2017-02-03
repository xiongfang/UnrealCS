#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FGuid
	{
		[FieldOffset(0)]
		public int A;
		[FieldOffset(4)]
		public int B;
		[FieldOffset(8)]
		public int C;
		[FieldOffset(12)]
		public int D;
		
	}
	
}
#endif
#endif
