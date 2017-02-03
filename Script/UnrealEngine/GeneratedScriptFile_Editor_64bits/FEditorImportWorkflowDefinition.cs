#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the asset import workflow test</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FEditorImportWorkflowDefinition
	{
		/// <summary>The file to import</summary>
		[FieldOffset(0)]
		public FFilePath ImportFilePath;
		/// <summary>Settings for the import factory</summary>
		public TStructArray<FImportFactorySettingValues> FactorySettings
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FImportFactorySettingValues>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
