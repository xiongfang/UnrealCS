using System;
namespace UnrealEngine
{
	/// <summary>The world size for each texcoord mapping. Used by the texture streaming.</summary>
	public partial struct FMeshUVChannelInfo
	{
		public bool bInitialized;
		/// <summary>Whether this values was set manually or is auto generated.</summary>
		public bool bOverrideDensities;
		/// <summary>
		/// The UV density in the mesh, before any transform scaling, in world unit per UV.
		/// This value represents the length taken to cover a full UV unit.
		/// </summary>
		public float LocalUVDensities;
		
	}
	
}
