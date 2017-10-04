using System;
namespace UnrealEngine
{
	public partial struct FSkeletalMaterial
	{
		public UMaterialInterface MaterialInterface;
		public bool bEnableShadowCasting;
		public bool bRecomputeTangent;
		/// <summary>This name should be use by the gameplay to avoid error if the skeletal mesh Materials array topology change</summary>
		public FName MaterialSlotName;
		/// <summary>This name should be use when we re-import a skeletal mesh so we can order the Materials array like it should be</summary>
		public FName ImportedMaterialSlotName;
		/// <summary>Data used for texture streaming relative to each UV channels.</summary>
		public FMeshUVChannelInfo UVChannelData;
		
	}
	
}
