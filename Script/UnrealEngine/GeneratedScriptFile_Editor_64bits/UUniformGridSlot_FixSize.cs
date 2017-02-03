#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A slot for UUniformGridPanel, these slots all share the same size as the largest slot
	/// in the grid.
	/// </summary>
	public partial class UUniformGridSlot
	{
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
		
		static readonly int Column__Offset;
		/// <summary>The column index of the cell this slot is in</summary>
		public int Column
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Column__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Column__Offset, false);}
			
		}
		
		static UUniformGridSlot()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("UniformGridSlot");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			Row__Offset=GetPropertyOffset(NativeClassPtr,"Row");
			Column__Offset=GetPropertyOffset(NativeClassPtr,"Column");
			
		}
		
	}
	
}
#endif
#endif
