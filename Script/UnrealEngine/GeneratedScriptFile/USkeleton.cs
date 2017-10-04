using System;
namespace UnrealEngine
{
	public partial class USkeleton:UObject
	{
		/// <summary>
		/// Guid for virtual bones.
		/// Separate so that we don't have to dirty the original guid when only changing virtual bones
		/// </summary>
		public FGuid VirtualBoneGuid;
		
		/// <summary>Container for smart name mappings</summary>
		public FSmartNameContainer SmartNames;
		
		public FRigConfiguration RigConfig;
		
		/// <summary>Attached assets component for this skeleton</summary>
		public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
		
		
	}
	
}
