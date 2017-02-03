#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Section data for each track. Reference of data will be stored in the child class for the way they want
	/// AnimComposite vs AnimMontage have different requirement for the actual data reference
	/// This only contains composite section information. (vertical sequences)
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FCompositeSection
	{
		/// <summary>Section Name</summary>
		[FieldOffset(48)]
		public FName SectionName;
		/// <summary>Start Time *</summary>
		[FieldOffset(60)]
		public float StartTime;
		/// <summary>Should this animation loop.</summary>
		[FieldOffset(64)]
		public FName NextSectionName;
		/// <summary>
		/// Meta data that can be saved with the asset
		/// You can query by GetMetaData function
		/// </summary>
		public TObjectArray<UAnimMetaData> MetaData
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UAnimMetaData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+80, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+80, false);}}}
			
		}
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
