using System;
namespace UnrealEngine
{
	public partial class UDistributionVectorConstantCurve:UDistributionVector
	{
		/// <summary>Keyframe data for each component (X,Y,Z) over time.</summary>
		public FInterpCurveVector ConstantCurve;
		
		/// <summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
		public bool bLockAxes;
		
		public EDistributionVectorLockFlags LockedAxes;
		
		
	}
	
}
