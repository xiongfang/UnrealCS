using System;
namespace UnrealEngine
{
	public partial class UWrapBoxSlot:UPanelSlot
	{
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		public extern void SetFillSpanWhenLessThan(float InFillSpanWhenLessThan);
		public extern void SetFillEmptySpace(bool InbFillEmptySpace);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding;
		
		/// <summary>Should this slot fill the remaining space on the line?</summary>
		public bool bFillEmptySpace;
		
		/// <summary>
		/// If the total available space in the wrap panel drops below this threshold, this slot will attempt to fill an entire line.
		/// NOTE: A value of 0, denotes no filling will occur.
		/// </summary>
		public float FillSpanWhenLessThan;
		
		/// <summary>The alignment of the object horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>The alignment of the object vertically.</summary>
		public EVerticalAlignment VerticalAlignment;
		
		
	}
	
}
