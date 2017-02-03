#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDataTable
	{
		static readonly int RowStruct__Offset;
		public UScriptStruct RowStruct
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RowStruct__Offset); if (v == IntPtr.Zero)return null; UScriptStruct retValue = new UScriptStruct(); retValue._this = v; return retValue; }
			
		}
		
		static UDataTable()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DataTable");
			RowStruct__Offset=GetPropertyOffset(NativeClassPtr,"RowStruct");
			
		}
		
	}
	
}
#endif
#endif
