using System;
namespace UnrealEngine
{
	public partial class UDistributionVectorUniform:UDistributionVector
	{
		/// <summary>Upper end of FVector magnitude range.</summary>
		public FVector Max;
		
		/// <summary>Lower end of FVector magnitude range.</summary>
		public FVector Min;
		
		/// <summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
		public bool bLockAxes;
		
		public EDistributionVectorLockFlags LockedAxes;
		
		public EDistributionVectorMirrorFlags MirrorFlags;
		
		public bool bUseExtremes;
		
		
	}
	
}
