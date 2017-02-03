#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Each slot data referenced by Animation Slot
	/// contains slot name, and animation data
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSlotAnimationTrack
	{
		[FieldOffset(0)]
		public FName SlotName;
		[FieldOffset(16)]
		public FAnimTrack AnimTrack;
		
	}
	
}
#endif
#endif
