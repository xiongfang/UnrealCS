using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the blueprint editor build promotion tests</summary>
	public partial struct FBlueprintEditorPromotionSettings
	{
		/// <summary>The starting mesh for the blueprint *</summary>
		public FFilePath FirstMeshPath;
		/// <summary>The mesh to set on the blueprint after the delay *</summary>
		public FFilePath SecondMeshPath;
		/// <summary>Default particle asset to use for tests</summary>
		public FFilePath DefaultParticleAsset;
		
	}
	
}
