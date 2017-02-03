#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=944)]
	public partial struct FCameraCacheEntry
	{
		[FieldOffset(0)]
		public float TimeStamp;
		[FieldOffset(4)]
		public FMinimalViewInfo POV;
		
	}
	
}
#endif
#endif
