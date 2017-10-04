using System;
namespace UnrealEngine
{
	public partial class UDistributionVectorUniformCurve:UDistributionVector
	{
		/// <summary>Keyframe data for how output constant varies over time.</summary>
		public FInterpCurveTwoVectors ConstantCurve;
		
		/// <summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
		public bool bLockAxes1;
		
		public bool bLockAxes2;
		
		public EDistributionVectorLockFlags LockedAxes;
		
		public EDistributionVectorMirrorFlags MirrorFlags;
		
		public bool bUseExtremes;
		
		
	}
	
}
