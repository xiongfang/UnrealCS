#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FBranchingPointMarker
	{
		[FieldOffset(0)]
		public int NotifyIndex;
		[FieldOffset(4)]
		public float TriggerTime;
		[FieldOffset(8)]
		public EAnimNotifyEventType NotifyEventType;
		
	}
	
}
#endif
#endif
