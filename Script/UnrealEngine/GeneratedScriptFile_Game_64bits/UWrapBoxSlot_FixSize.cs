#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWrapBoxSlot
	{
		static readonly int Padding__Offset;
		public FMargin Padding
		{
			get{ CheckIsValid();return (FMargin)Marshal.PtrToStructure(_this.Get()+Padding__Offset, typeof(FMargin));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Padding__Offset, false);}
			
		}
		
		static readonly int bFillEmptySpace__Offset;
		public bool bFillEmptySpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFillEmptySpace__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFillEmptySpace__Offset, 1,0,1,255);}
			
		}
		
		static readonly int FillSpanWhenLessThan__Offset;
		public float FillSpanWhenLessThan
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FillSpanWhenLessThan__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FillSpanWhenLessThan__Offset, false);}
			
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
		
		static UWrapBoxSlot()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WrapBoxSlot");
			Padding__Offset=GetPropertyOffset(NativeClassPtr,"Padding");
			bFillEmptySpace__Offset=GetPropertyOffset(NativeClassPtr,"bFillEmptySpace");
			FillSpanWhenLessThan__Offset=GetPropertyOffset(NativeClassPtr,"FillSpanWhenLessThan");
			HorizontalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"HorizontalAlignment");
			VerticalAlignment__Offset=GetPropertyOffset(NativeClassPtr,"VerticalAlignment");
			
		}
		
	}
	
}
#endif
#endif
