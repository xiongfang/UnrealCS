#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Triggers an animation notify.  Each AnimNotifyEvent contains an AnimNotify object
	/// which has its Notify method called and passed to the animation.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=184)]
	public partial struct FAnimNotifyEvent
	{
		/// <summary>The user requested time for this notify</summary>
		[FieldOffset(48)]
		public float DisplayTime;
		/// <summary>An offset from the DisplayTime to the actual time we will trigger the notify, as we cannot always trigger it exactly at the time the user wants</summary>
		[FieldOffset(52)]
		public float TriggerTimeOffset;
		/// <summary>An offset similar to TriggerTimeOffset but used for the end scrub handle of a notify state's duration</summary>
		[FieldOffset(56)]
		public float EndTriggerTimeOffset;
		[FieldOffset(60)]
		public float TriggerWeightThreshold;
		[FieldOffset(64)]
		public FName NotifyName;
		[FieldOffset(96)]
		public float Duration;
		/// <summary>Linkable element to use for the end handle representing a notify state duration</summary>
		[FieldOffset(104)]
		public FAnimLinkableElement EndLink;
		/// <summary>If TRUE, this notify has been converted from an old BranchingPoint.</summary>
		public bool bConvertedFromBranchingPoint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 152, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 152, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(153)]
		public EMontageNotifyTickType MontageTickType;
		/// <summary>Defines the chance of of this notify triggering, 0 = No Chance, 1 = Always triggers</summary>
		[FieldOffset(156)]
		public float NotifyTriggerChance;
		/// <summary>Defines a method for filtering notifies (stopping them triggering) e.g. by looking at the meshes current LOD</summary>
		[FieldOffset(160)]
		public ENotifyFilterType NotifyFilterType;
		/// <summary>LOD to start filtering this notify from.</summary>
		[FieldOffset(164)]
		public int NotifyFilterLOD;
		/// <summary>If disabled this notify will be skipped on dedicated servers</summary>
		public bool bTriggerOnDedicatedServer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Color of Notify in editor</summary>
		[FieldOffset(172)]
		public FColor NotifyColor;
		/// <summary>'Track' that the notify exists on, used for visual placement in editor and sorting priority in runtime</summary>
		[FieldOffset(176)]
		public int TrackIndex;
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
