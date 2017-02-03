#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FEditorImportExportTestDefinition
	{
		[FieldOffset(0)]
		public FFilePath ImportFilePath;
		[FieldOffset(12)]
		public FString ExportFileExtension;
		public bool bSkipExport
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		public TStructArray<FImportFactorySettingValues> FactorySettings
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FImportFactorySettingValues>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+28, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+28, false);}}}
			
		}
		
	}
	
}
#endif
#endif
