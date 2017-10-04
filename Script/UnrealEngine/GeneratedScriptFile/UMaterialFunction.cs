using System;
namespace UnrealEngine
{
	public partial class UMaterialFunction:UObject
	{
		/// <summary>Used by materials using this function to know when to recompile.</summary>
		public FGuid StateId;
		
		/// <summary>Used in the material editor, points to the function asset being edited, which this function is just a preview for.</summary>
		public UMaterialFunction ParentFunction;
		
		/// <summary>Description of the function which will be displayed as a tooltip wherever the function is used.</summary>
		public FString Description;
		
		/// <summary>Whether to list this function in the material function library, which is a window in the material editor that lists categorized functions.</summary>
		public bool bExposeToLibrary;
		
		public UMaterial PreviewMaterial;
		
		/// <summary>Transient flag used to track re-entrance in recursive functions like IsDependent.</summary>
		public bool bReentrantFlag;
		
		public uint CombinedInputTypes;
		
		public uint CombinedOutputTypes;
		
		/// <summary>Information for thumbnail rendering</summary>
		public UThumbnailInfo ThumbnailInfo;
		
		
	}
	
}
