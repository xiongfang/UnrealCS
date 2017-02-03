#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for an 'event' during the timeline</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FTimelineEventEntry
	{
		/// <summary>Time at which event should fire</summary>
		[FieldOffset(0)]
		public float Time;
		
	}
	
}
#endif
#endif
