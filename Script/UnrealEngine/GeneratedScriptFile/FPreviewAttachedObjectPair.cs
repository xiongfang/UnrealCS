using System;
namespace UnrealEngine
{
	/// <summary>Preview items that are attached to the skeleton *</summary>
	public partial struct FPreviewAttachedObjectPair
	{
		public UObject Object;
		/// <summary>The name of the attach point of the Object (for example a bone or socket name)</summary>
		public FName AttachedTo;
		
	}
	
}
