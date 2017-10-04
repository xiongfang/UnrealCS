using System;
namespace UnrealEngine
{
	/// <summary>
	/// Section data for each track. Reference of data will be stored in the child class for the way they want
	/// AnimComposite vs AnimMontage have different requirement for the actual data reference
	/// This only contains composite section information. (vertical sequences)
	/// </summary>
	public partial struct FCompositeSection
	{
		/// <summary>Section Name</summary>
		public FName SectionName;
		/// <summary>Start Time *</summary>
		public float StartTime;
		/// <summary>Should this animation loop.</summary>
		public FName NextSectionName;
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
