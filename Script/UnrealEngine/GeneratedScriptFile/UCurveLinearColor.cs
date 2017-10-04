using System;
namespace UnrealEngine
{
	public partial class UCurveLinearColor:UCurveBase
	{
		public extern virtual FLinearColor GetLinearColorValue(float InTime);
		/// <summary>Keyframe data, one curve for red, green, blue, and alpha</summary>
		public FRichCurve FloatCurves;
		
		
	}
	
}
