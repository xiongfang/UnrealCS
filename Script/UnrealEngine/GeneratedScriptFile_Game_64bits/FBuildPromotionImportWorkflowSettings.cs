#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=336)]
	public partial struct FBuildPromotionImportWorkflowSettings
	{
		[FieldOffset(0)]
		public FEditorImportWorkflowDefinition Diffuse;
		[FieldOffset(32)]
		public FEditorImportWorkflowDefinition Normal;
		[FieldOffset(64)]
		public FEditorImportWorkflowDefinition StaticMesh;
		[FieldOffset(96)]
		public FEditorImportWorkflowDefinition ReimportStaticMesh;
		[FieldOffset(128)]
		public FEditorImportWorkflowDefinition BlendShapeMesh;
		[FieldOffset(160)]
		public FEditorImportWorkflowDefinition MorphMesh;
		[FieldOffset(192)]
		public FEditorImportWorkflowDefinition SkeletalMesh;
		[FieldOffset(224)]
		public FEditorImportWorkflowDefinition Animation;
		[FieldOffset(256)]
		public FEditorImportWorkflowDefinition Sound;
		[FieldOffset(288)]
		public FEditorImportWorkflowDefinition SurroundSound;
		public TStructArray<FEditorImportWorkflowDefinition> OtherAssetsToImport
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FEditorImportWorkflowDefinition>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+320, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+320, false);}}}
			
		}
		
	}
	
}
#endif
#endif
