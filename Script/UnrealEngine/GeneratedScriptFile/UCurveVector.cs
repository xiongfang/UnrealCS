using System;
namespace UnrealEngine
{
	public partial class UCurveVector:UCurveBase
	{
		/// <summary>Evaluate this float curve at the specified time</summary>
		public extern FVector GetVectorValue(float InTime);
		/// <summary>Keyframe data, one curve for X, Y and Z</summary>
		public FRichCurve FloatCurves;
		
		
	}
	
}
