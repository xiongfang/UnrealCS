using System;
namespace UnrealEngine
{
	public partial struct FSplineCurves
	{
		/// <summary>Spline built from position data.</summary>
		public FInterpCurveVector Position;
		/// <summary>Spline built from rotation data.</summary>
		public FInterpCurveQuat Rotation;
		/// <summary>Spline built from scale data.</summary>
		public FInterpCurveVector Scale;
		/// <summary>Input: distance along curve, output: parameter that puts you there.</summary>
		public FInterpCurveFloat ReparamTable;
		
	}
	
}
