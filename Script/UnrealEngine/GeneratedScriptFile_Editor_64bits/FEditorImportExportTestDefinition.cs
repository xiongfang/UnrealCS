#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the asset import / export automation test</summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FEditorImportExportTestDefinition
	{
		/// <summary>The file to import</summary>
		[FieldOffset(0)]
		public FFilePath ImportFilePath;
		/// <summary>The file extension to use when exporting this asset.  Used to find a supporting exporter</summary>
		[FieldOffset(16)]
		public FString ExportFileExtension;
		/// <summary>If true, the export step will be skipped</summary>
		public bool bSkipExport
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Settings for the import factory</summary>
		public TStructArray<FImportFactorySettingValues> FactorySettings
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FImportFactorySettingValues>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		
	}
	
}
#endif
#endif
