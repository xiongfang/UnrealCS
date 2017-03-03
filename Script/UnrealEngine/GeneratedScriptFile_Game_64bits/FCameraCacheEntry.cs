#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1312)]
	public partial struct FCameraCacheEntry
	{
		[FieldOffset(0)]
		public float Timestamp;
		[FieldOffset(16)]
		public FMinimalViewInfo POV;
		
	}
	
}
#endif
#endif
