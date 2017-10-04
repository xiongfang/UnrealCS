using System;
namespace UnrealEngine
{
	/// <summary>
	/// Used to describe an element that can be linked to a segment in a montage or sequence.
	///    Usage:
	///            Inherit from FAnimLinkableElement and make sure to call LinkMontage or LinkSequence
	///            both on creation and on loading the element. From there SetTime and GetTime should be
	///            used to control where this element is in the montage or sequence.
	///            For more advanced usage, see this implementation used in FAnimNotifyEvent where
	///            we have a secondary link to handle a duration
	///            @see FAnimNotifyEvent
	/// </summary>
	public partial struct FAnimLinkableElement
	{
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
