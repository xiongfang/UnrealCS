#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FAnimNotifyTrack
	{
		[FieldOffset(0)]
		public FName TrackName;
		[FieldOffset(8)]
		public FLinearColor TrackColor;
		
	}
	
}
#endif
#endif
