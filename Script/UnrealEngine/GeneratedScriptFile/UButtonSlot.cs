using System;
namespace UnrealEngine
{
	public partial class UButtonSlot:UPanelSlot
	{
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding;
		
		/// <summary>The alignment of the object horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>The alignment of the object vertically.</summary>
		public EVerticalAlignment VerticalAlignment;
		
		
	}
	
}
