#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Remove FBranchingPoint when VER_UE4_MONTAGE_BRANCHING_POINT_REMOVAL is removed.</summary>
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FBranchingPoint
	{
		[FieldOffset(48)]
		public FName EventName;
		[FieldOffset(60)]
		public float DisplayTime;
		/// <summary>An offset from the DisplayTime to the actual time we will trigger the notify, as we cannot always trigger it exactly at the time the user wants</summary>
		[FieldOffset(64)]
		public float TriggerTimeOffset;
		/// <summary>The montage that this element is currently linked to</summary>
		/// <summary>The slot index we are currently using within LinkedMontage</summary>
		[FieldOffset(16)]
		public int SlotIndex;
		/// <summary>The index of the segment we are linked to within the slot we are using</summary>
		[FieldOffset(20)]
		public int SegmentIndex;
		/// <summary>The method we are using to calculate our times</summary>
		[FieldOffset(24)]
		public EAnimLinkMethod LinkMethod;
		/// <summary>Cached link method used to transform the time when LinkMethod changes, always relates to the currently stored time</summary>
		[FieldOffset(25)]
		public EAnimLinkMethod CachedLinkMethod;
		/// <summary>The absolute time in the montage that our currently linked segment begins</summary>
		[FieldOffset(28)]
		public float SegmentBeginTime;
		/// <summary>The absolute length of our currently linked segment</summary>
		[FieldOffset(32)]
		public float SegmentLength;
		/// <summary>The time of this montage. This will differ depending upon the method we are using to link the time for this element</summary>
		[FieldOffset(36)]
		public float LinkValue;
		/// <summary>
		/// The Animation Sequence that this montage element will link to, when the sequence changes
		/// in either length or rate; the element will correctly place itself in relation to the sequence
		/// </summary>
		
	}
	
}
#endif
#endif
