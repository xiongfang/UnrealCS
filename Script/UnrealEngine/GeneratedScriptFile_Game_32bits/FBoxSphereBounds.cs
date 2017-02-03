#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FBoxSphereBounds
	{
		[FieldOffset(0)]
		public FVector Origin;
		[FieldOffset(12)]
		public FVector BoxExtent;
		[FieldOffset(24)]
		public float SphereRadius;
		
	}
	
}
#endif
#endif
