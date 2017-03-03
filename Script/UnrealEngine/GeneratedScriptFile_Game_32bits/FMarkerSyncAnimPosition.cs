#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FMarkerSyncAnimPosition
	{
		[FieldOffset(0)]
		public FName PreviousMarkerName;
		[FieldOffset(8)]
		public FName NextMarkerName;
		[FieldOffset(16)]
		public float PositionBetweenMarkers;
		
	}
	
}
#endif
#endif
