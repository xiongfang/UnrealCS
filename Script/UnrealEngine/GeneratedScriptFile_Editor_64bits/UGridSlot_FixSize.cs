#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A slot for UGridPanel, these slots all share the same size as the largest slot
	/// in the grid.
	/// </summary>
	public partial class UGridSlot
	{
		static readonly int Padding__Offset;
		/// <summary>The padding area between the slot and the content it contains.</summary>
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		/// <summary>The alignment of the object horizontally.</summary>
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		/// <summary>The alignment of the object vertically.</summary>
		public EVerticalAlignment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalAlignment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static readonly int Row__Offset;
		/// <summary>The row index of the cell this slot is in</summary>
		public int Row
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Row__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Row__Offset, false);}
			
		}
		
		static readonly int RowSpan__Offset;
		public int RowSpan
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RowSpan__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RowSpan__Offset, false);}
			
		}
		
		static readonly int Column__Offset;
		/// <summary>The column index of the cell this slot is in</summary>
		public int Column
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Column__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Column__Offset, false);}
			
		}
		
		static readonly int ColumnSpan__Offset;
		public int ColumnSpan
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ColumnSpan__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ColumnSpan__Offset, false);}
			
		}
		
		static readonly int Layer__Offset;
		/// <summary>Positive values offset this cell to be hit-tested and drawn on top of others. Default is 0; i.e. no offset.</summary>
		public int Layer
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Layer__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Layer__Offset, false);}
			
		}
		
		static readonly int Nudge__Offset;
		/// <summary>Offset this slot's content by some amount; positive values offset to lower right</summary>
		public FVector2D Nudge
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+Nudge__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Nudge__Offset, false);}
			
		}
		
		static UGridSlot()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GridSlot");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			Row__Offset=GetPropertyOffset(NativeClassPtr,"Row");
			RowSpan__Offset=GetPropertyOffset(NativeClassPtr,"RowSpan");
			Column__Offset=GetPropertyOffset(NativeClassPtr,"Column");
			ColumnSpan__Offset=GetPropertyOffset(NativeClassPtr,"ColumnSpan");
			Layer__Offset=GetPropertyOffset(NativeClassPtr,"Layer");
			Nudge__Offset=GetPropertyOffset(NativeClassPtr,"Nudge");
			
		}
		
	}
	
}
#endif
#endif
