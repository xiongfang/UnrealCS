using System;
namespace UnrealEngine
{
	/// <summary>
	/// Triggers an animation notify.  Each AnimNotifyEvent contains an AnimNotify object
	/// which has its Notify method called and passed to the animation.
	/// </summary>
	public partial struct FAnimNotifyEvent
	{
		/// <summary>The user requested time for this notify</summary>
		public float DisplayTime;
		/// <summary>An offset from the DisplayTime to the actual time we will trigger the notify, as we cannot always trigger it exactly at the time the user wants</summary>
		public float TriggerTimeOffset;
		/// <summary>An offset similar to TriggerTimeOffset but used for the end scrub handle of a notify state's duration</summary>
		public float EndTriggerTimeOffset;
		public float TriggerWeightThreshold;
		public FName NotifyName;
		public UAnimNotify Notify;
		public UAnimNotifyState NotifyStateClass;
		public float Duration;
		/// <summary>Linkable element to use for the end handle representing a notify state duration</summary>
		public FAnimLinkableElement EndLink;
		/// <summary>If TRUE, this notify has been converted from an old BranchingPoint.</summary>
		public bool bConvertedFromBranchingPoint;
		public EMontageNotifyTickType MontageTickType;
		/// <summary>Defines the chance of of this notify triggering, 0 = No Chance, 1 = Always triggers</summary>
		public float NotifyTriggerChance;
		/// <summary>Defines a method for filtering notifies (stopping them triggering) e.g. by looking at the meshes current LOD</summary>
		public ENotifyFilterType NotifyFilterType;
		/// <summary>LOD to start filtering this notify from.</summary>
		public int NotifyFilterLOD;
		/// <summary>If disabled this notify will be skipped on dedicated servers</summary>
		public bool bTriggerOnDedicatedServer;
		/// <summary>Color of Notify in editor</summary>
		public FColor NotifyColor;
		/// <summary>'Track' that the notify exists on, used for visual placement in editor and sorting priority in runtime</summary>
		public int TrackIndex;
		/// <summary>The montage that this element is currently linked to</summary>
		public UAnimMontage LinkedMontage;
		/// <summary>The slot index we are currently using within LinkedMontage</summary>
		public int SlotIndex;
		/// <summary>The index of the segment we are linked to within the slot we are using</summary>
		public int SegmentIndex;
		/// <summary>The method we are using to calculate our times</summary>
		public EAnimLinkMethod LinkMethod;
		/// <summary>Cached link method used to transform the time when LinkMethod changes, always relates to the currently stored time</summary>
		public EAnimLinkMethod CachedLinkMethod;
		/// <summary>The absolute time in the montage that our currently linked segment begins</summary>
		public float SegmentBeginTime;
		/// <summary>The absolute length of our currently linked segment</summary>
		public float SegmentLength;
		/// <summary>The time of this montage. This will differ depending upon the method we are using to link the time for this element</summary>
		public float LinkValue;
		/// <summary>
		/// The Animation Sequence that this montage element will link to, when the sequence changes
		/// in either length or rate; the element will correctly place itself in relation to the sequence
		/// </summary>
		public UAnimSequenceBase LinkedSequence;
		
	}
	
}
