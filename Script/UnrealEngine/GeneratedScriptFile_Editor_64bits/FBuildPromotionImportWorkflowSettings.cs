#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the import workflow stage of the build promotion test</summary>
	[StructLayout(LayoutKind.Explicit,Size=336)]
	public partial struct FBuildPromotionImportWorkflowSettings
	{
		/// <summary>Import settings for the Diffuse texture</summary>
		[FieldOffset(0)]
		public FEditorImportWorkflowDefinition Diffuse;
		/// <summary>Import settings for the Normalmap texture</summary>
		[FieldOffset(32)]
		public FEditorImportWorkflowDefinition Normal;
		/// <summary>Import settings for the static mesh</summary>
		[FieldOffset(64)]
		public FEditorImportWorkflowDefinition StaticMesh;
		/// <summary>Import settings for the static mesh to re-import</summary>
		[FieldOffset(96)]
		public FEditorImportWorkflowDefinition ReimportStaticMesh;
		/// <summary>Import settings for the blend shape</summary>
		[FieldOffset(128)]
		public FEditorImportWorkflowDefinition BlendShapeMesh;
		/// <summary>Import settings for the morph mesh</summary>
		[FieldOffset(160)]
		public FEditorImportWorkflowDefinition MorphMesh;
		/// <summary>Import settings for the skeletal mesh</summary>
		[FieldOffset(192)]
		public FEditorImportWorkflowDefinition SkeletalMesh;
		/// <summary>Import settings for the animation asset.  (Will automatically use the skeleton of the skeletal mesh above)</summary>
		[FieldOffset(224)]
		public FEditorImportWorkflowDefinition Animation;
		/// <summary>Import settings for the sound</summary>
		[FieldOffset(256)]
		public FEditorImportWorkflowDefinition Sound;
		/// <summary>Import settings for the surround sound (Select any of the channels.  It will auto import the rest)</summary>
		[FieldOffset(288)]
		public FEditorImportWorkflowDefinition SurroundSound;
		/// <summary>Import settings for any other assets you may want to import</summary>
		public TStructArray<FEditorImportWorkflowDefinition> OtherAssetsToImport
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FEditorImportWorkflowDefinition>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+320, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+320, false);}}}
			
		}
		
	}
	
}
#endif
#endif
