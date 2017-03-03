#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FCameraCutInfo
	{
		[FieldOffset(0)]
		public FVector Location;
		[FieldOffset(12)]
		public float Timestamp;
		
	}
	
}
#endif
#endif
