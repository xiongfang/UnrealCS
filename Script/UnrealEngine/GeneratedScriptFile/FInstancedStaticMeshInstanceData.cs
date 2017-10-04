using System;
namespace UnrealEngine
{
	public partial struct FInstancedStaticMeshInstanceData
	{
		public FMatrix Transform;
		/// <summary>Legacy, this is now stored in FMeshMapBuildData.  Still serialized for backwards compatibility.</summary>
		public FVector2D LightmapUVBias;
		/// <summary>Legacy, this is now stored in FMeshMapBuildData.  Still serialized for backwards compatibility.</summary>
		public FVector2D ShadowmapUVBias;
		
	}
	
}
