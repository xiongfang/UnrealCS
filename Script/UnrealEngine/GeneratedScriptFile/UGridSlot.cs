using System;
namespace UnrealEngine
{
	public partial class UGridSlot:UPanelSlot
	{
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		/// <summary>Sets positive values offset this cell to be hit-tested and drawn on top of others.</summary>
		public extern void SetLayer(int InLayer);
		/// <summary>How many columns this slot spans over</summary>
		public extern void SetColumnSpan(int InColumnSpan);
		/// <summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
		public extern void SetColumn(int InColumn);
		/// <summary>How many rows this this slot spans over</summary>
		public extern void SetRowSpan(int InRowSpan);
		/// <summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
		public extern void SetRow(int InRow);
		public extern void SetPadding(FMargin InPadding);
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding;
		
		/// <summary>The alignment of the object horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>The alignment of the object vertically.</summary>
		public EVerticalAlignment VerticalAlignment;
		
		/// <summary>The row index of the cell this slot is in</summary>
		public int Row;
		
		public int RowSpan;
		
		/// <summary>The column index of the cell this slot is in</summary>
		public int Column;
		
		public int ColumnSpan;
		
		/// <summary>Positive values offset this cell to be hit-tested and drawn on top of others. Default is 0; i.e. no offset.</summary>
		public int Layer;
		
		/// <summary>Offset this slot's content by some amount; positive values offset to lower right</summary>
		public FVector2D Nudge;
		
		
	}
	
}
