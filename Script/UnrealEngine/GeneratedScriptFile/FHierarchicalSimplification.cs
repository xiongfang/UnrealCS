using System;
namespace UnrealEngine
{
	public partial struct FHierarchicalSimplification
	{
		/// <summary>The screen radius an mesh object should reach before swapping to the LOD actor, once one of parent displays, it won't draw any of children.</summary>
		public float TransitionScreenSize;
		/// <summary>
		/// If this is true, it will simplify mesh but it is slower.
		/// If false, it will just merge actors but not simplify using the lower LOD if exists.
		/// For example if you build LOD 1, it will use LOD 1 of the mesh to merge actors if exists.
		/// If you merge material, it will reduce drawcalls.
		/// </summary>
		public bool bSimplifyMesh;
		/// <summary>Simplification Setting if bSimplifyMesh is true</summary>
		public FMeshProxySettings ProxySetting;
		/// <summary>Merge Mesh Setting if bSimplifyMesh is false</summary>
		public FMeshMergingSettings MergeSetting;
		/// <summary>Desired Bounding Radius for clustering - this is not guaranteed but used to calculate filling factor for auto clustering</summary>
		public float DesiredBoundRadius;
		/// <summary>Desired Filling Percentage for clustering - this is not guaranteed but used to calculate filling factor  for auto clustering</summary>
		public float DesiredFillingPercentage;
		/// <summary>Min number of actors to build LODActor</summary>
		public int MinNumberOfActorsToBuild;
		
	}
	
}
