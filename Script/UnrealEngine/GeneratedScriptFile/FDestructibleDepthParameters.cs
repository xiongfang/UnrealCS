using System;
namespace UnrealEngine
{
	/// <summary>Properties that may be set for all chunks at a particular depth in the fracture hierarchy.</summary>
	public partial struct FDestructibleDepthParameters
	{
		/// <summary>Chunks up to the depth DefaultImpactDamageDepth will take impact damage, unless one of the override options (see EImpactDamageOverride) is chosen.</summary>
		public EImpactDamageOverride ImpactDamageOverride;
		
	}
	
}
