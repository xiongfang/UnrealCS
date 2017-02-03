#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FTwoVectors
	{
		[FieldOffset(0)]
		public FVector v1;
		[FieldOffset(12)]
		public FVector v2;
		
	}
	
}
#endif
#endif
