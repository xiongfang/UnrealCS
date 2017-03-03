#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FTimelineFloatTrack
	{
		[FieldOffset(24)]
		public FName TrackName;
		[FieldOffset(32)]
		public FName FloatPropertyName;
		
	}
	
}
#endif
#endif
