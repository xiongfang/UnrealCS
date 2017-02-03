#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FPaintedVertex
	{
		[FieldOffset(0)]
		public FVector Position;
		[FieldOffset(12)]
		public FPackedNormal Normal;
		[FieldOffset(16)]
		public FColor Color;
		
	}
	
}
#endif
#endif
