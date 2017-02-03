#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FTimelineLinearColorTrack
	{
		[FieldOffset(20)]
		public FName TrackName;
		[FieldOffset(28)]
		public FName LinearColorPropertyName;
		
	}
	
}
#endif
#endif
