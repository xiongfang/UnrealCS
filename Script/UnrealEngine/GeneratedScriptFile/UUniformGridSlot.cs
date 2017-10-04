using System;
namespace UnrealEngine
{
	public partial class UUniformGridSlot:UPanelSlot
	{
		public extern void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment);
		public extern void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment);
		/// <summary>Sets the column index of the slot, this determines what cell the slot is in the panel</summary>
		public extern void SetColumn(int InColumn);
		/// <summary>Sets the row index of the slot, this determines what cell the slot is in the panel</summary>
		public extern void SetRow(int InRow);
		/// <summary>The alignment of the object horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment;
		
		/// <summary>The alignment of the object vertically.</summary>
		public EVerticalAlignment VerticalAlignment;
		
		/// <summary>The row index of the cell this slot is in</summary>
		public int Row;
		
		/// <summary>The column index of the cell this slot is in</summary>
		public int Column;
		
		
	}
	
}
