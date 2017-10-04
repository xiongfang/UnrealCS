using System;
namespace UnrealEngine
{
	public partial class UDistributionVectorConstant:UDistributionVector
	{
		/// <summary>This FVector will be returned for all input times.</summary>
		public FVector Constant;
		
		/// <summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
		public bool bLockAxes;
		
		public EDistributionVectorLockFlags LockedAxes;
		
		
	}
	
}
