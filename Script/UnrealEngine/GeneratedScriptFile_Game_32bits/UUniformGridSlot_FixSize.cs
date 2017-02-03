#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UUniformGridSlot
	{
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
		
		static readonly int Column__Offset;
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
