#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UFontImportOptions
	{
		static readonly int Data__Offset;
		public FFontImportOptionsData Data
		{
			get{ CheckIsValid();return (FFontImportOptionsData)Marshal.PtrToStructure(_this.Get()+Data__Offset, typeof(FFontImportOptionsData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Data__Offset, false);}
			
		}
		
		static UFontImportOptions()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("FontImportOptions");
			Data__Offset=GetPropertyOffset(NativeClassPtr,"Data");
			
		}
		
	}
	
}
#endif
#endif
