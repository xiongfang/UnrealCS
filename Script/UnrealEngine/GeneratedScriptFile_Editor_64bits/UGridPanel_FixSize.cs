#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A panel that evenly divides up available space between all of its children.
	/// * Many Children
	/// </summary>
	public partial class UGridPanel
	{
		static readonly int ColumnFill__Offset;
		/// <summary>The column fill rules</summary>
		public TStructArray<float> ColumnFill
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ColumnFill__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ColumnFill__Offset, false);}
			
		}
		
		static readonly int RowFill__Offset;
		/// <summary>The row fill rules</summary>
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
