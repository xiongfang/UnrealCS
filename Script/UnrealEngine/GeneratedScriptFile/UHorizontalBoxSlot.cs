using System;
namespace UnrealEngine
{
	public partial class UHorizontalBoxSlot:UPanelSlot
	{
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		public extern void SetSize(FSlateChildSize InSize);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>The amount of padding between the slots parent and the content.</summary>
		public FMargin Padding;
		
		/// <summary>How much space this slot should occupy in the direction of the panel.</summary>
		public FSlateChildSize Size;
		
		public EHorizontalAlignment HorizontalAlignment;
		
		public EVerticalAlignment VerticalAlignment;
		
		
	}
	
}
