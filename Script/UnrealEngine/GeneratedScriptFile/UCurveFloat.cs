using System;
namespace UnrealEngine
{
	public partial class UCurveFloat:UCurveBase
	{
		/// <summary>Evaluate this float curve at the specified time</summary>
		public extern float GetFloatValue(float InTime);
		/// <summary>Keyframe data</summary>
		public FRichCurve FloatCurve;
		
		/// <summary>Flag to represent event curve</summary>
		public bool bIsEventCurve;
		
		
	}
	
}
