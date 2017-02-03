#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UGridPanel
	{
		static readonly int ColumnFill__Offset;
		public TStructArray<float> ColumnFill
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ColumnFill__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ColumnFill__Offset, false);}
			
		}
		
		static readonly int RowFill__Offset;
		public TStructArray<float> RowFill
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RowFill__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RowFill__Offset, false);}
			
		}
		
		static UGridPanel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GridPanel");
			ColumnFill__Offset=GetPropertyOffset(NativeClassPtr,"ColumnFill");
			RowFill__Offset=GetPropertyOffset(NativeClassPtr,"RowFill");
			
		}
		
	}
	
}
#endif
#endif
