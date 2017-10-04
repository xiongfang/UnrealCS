using System;
namespace UnrealEngine
{
	/// <summary>Rig Controller for bone transform *</summary>
	public partial struct FNode
	{
		/// <summary>Name of the original node. We don't allow to change this. This is used for identity.*</summary>
		public FName Name;
		/// <summary>We save Parent Node but if the parent node is removed, it will reset to root</summary>
		public FName ParentName;
		/// <summary>Absolute transform of the node. Hoping to use this data in the future to render</summary>
		public FTransform Transform;
		/// <summary>This is Display Name where it will be used to display in Retarget Manager. This name has to be unique.</summary>
		public FString DisplayName;
		public bool bAdvanced;
		
	}
	
}
