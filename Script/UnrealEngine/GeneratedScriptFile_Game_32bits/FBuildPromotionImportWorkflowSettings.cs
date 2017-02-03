#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=252)]
	public partial struct FBuildPromotionImportWorkflowSettings
	{
		[FieldOffset(0)]
		public FEditorImportWorkflowDefinition Diffuse;
		[FieldOffset(24)]
		public FEditorImportWorkflowDefinition Normal;
		[FieldOffset(48)]
		public FEditorImportWorkflowDefinition StaticMesh;
		[FieldOffset(72)]
		public FEditorImportWorkflowDefinition ReimportStaticMesh;
		[FieldOffset(96)]
		public FEditorImportWorkflowDefinition BlendShapeMesh;
		[FieldOffset(120)]
		public FEditorImportWorkflowDefinition MorphMesh;
		[FieldOffset(144)]
		public FEditorImportWorkflowDefinition SkeletalMesh;
		[FieldOffset(168)]
		public FEditorImportWorkflowDefinition Animation;
		[FieldOffset(192)]
		public FEditorImportWorkflowDefinition Sound;
		[FieldOffset(216)]
		public FEditorImportWorkflowDefinition SurroundSound;
		public TStructArray<FEditorImportWorkflowDefinition> OtherAssetsToImport
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FEditorImportWorkflowDefinition>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+240, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+240, false);}}}
			
		}
		
	}
	
}
#endif
#endif
