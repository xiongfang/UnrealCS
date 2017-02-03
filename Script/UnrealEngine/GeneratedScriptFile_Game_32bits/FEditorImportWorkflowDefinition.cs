#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEditorImportWorkflowDefinition
	{
		[FieldOffset(0)]
		public FFilePath ImportFilePath;
		public TStructArray<FImportFactorySettingValues> FactorySettings
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FImportFactorySettingValues>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		
	}
	
}
#endif
#endif
