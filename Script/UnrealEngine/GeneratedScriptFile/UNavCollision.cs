using System;
namespace UnrealEngine
{
	public partial class UNavCollision:UObject
	{
		/// <summary>navigation area type (empty = default obstacle)</summary>
		public TSubclassOf<UNavArea>  AreaClass;
		
		/// <summary>If set, mesh will be used as dynamic obstacle (don't create navmesh on top, much faster adding/removing)</summary>
		public bool bIsDynamicObstacle;
		
		/// <summary>If set, convex collisions will be exported offline for faster runtime navmesh building (increases memory usage)</summary>
		public bool bGatherConvexGeometry;
		
		
	}
	
}
