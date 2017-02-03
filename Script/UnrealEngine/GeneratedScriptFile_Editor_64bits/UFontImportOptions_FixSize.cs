#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds options for importing fonts.</summary>
	public partial class UFontImportOptions
	{
		static readonly int Data__Offset;
		/// <summary>The actual data for this object.  We wrap it in a struct so that we can copy it around between objects.</summary>
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
