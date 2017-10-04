using System;
namespace UnrealEngine
{
	public partial class UHierarchicalInstancedStaticMeshComponent:UInstancedStaticMeshComponent
	{
		/// <summary>The number of instances in the ClusterTree. Subsequent instances will always be rendered.</summary>
		public int NumBuiltInstances;
		
		/// <summary>Bounding box of any built instances (cached from the ClusterTree)</summary>
		public FBox BuiltInstanceBounds;
		
		/// <summary>Bounding box of any unbuilt instances</summary>
		public FBox UnbuiltInstanceBounds;
		
		/// <summary>
		/// Enable for detail meshes that don't really affect the game. Disable for anything important.
		/// Typically, this will be enabled for small meshes without collision (e.g. grass) and disabled for large meshes with collision (e.g. trees)
		/// </summary>
		public bool bEnableDensityScaling;
		
		/// <summary>The number of nodes in the occlusion layer</summary>
		public int OcclusionLayerNumNodes;
		
		public bool bDisableCollision;
		
		
	}
	
}
