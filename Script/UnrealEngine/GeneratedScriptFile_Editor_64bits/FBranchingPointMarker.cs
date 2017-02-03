#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// AnimNotifies marked as BranchingPoints will create these markers on their Begin/End times.
	///       They create stopping points when the Montage is being ticked to dispatch events.
	/// </summary>
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
