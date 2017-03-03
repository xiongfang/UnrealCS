#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1280)]
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
