#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UGridSlot
	{
		static readonly int Padding__Offset;
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int HorizontalAlignment__Offset;
		public EHorizontalAlignment HorizontalAlignment
		{
			get{ CheckIsValid();return (EHorizontalAlignment)Marshal.PtrToStructure(_this.Get()+HorizontalAlignment__Offset, typeof(EHorizontalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HorizontalAlignment__Offset, false);}
			
		}
		
		static readonly int VerticalAlignment__Offset;
		public EVerticalAlignment VerticalAlignment
		{
			get{ CheckIsValid();return (EVerticalAlignment)Marshal.PtrToStructure(_this.Get()+VerticalAlignment__Offset, typeof(EVerticalAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VerticalAlignment__Offset, false);}
			
		}
		
		static readonly int Row__Offset;
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
		public int Layer
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Layer__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Layer__Offset, false);}
			
		}
		
		static readonly int Nudge__Offset;
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
