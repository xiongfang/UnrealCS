using System;
namespace UnrealEngine
{
	/// <summary>One key in a rich, editable float curve</summary>
	public partial struct FRichCurveKey
	{
		/// <summary>Interpolation mode between this key and the next</summary>
		public ERichCurveInterpMode InterpMode;
		/// <summary>Mode for tangents at this key</summary>
		public ERichCurveTangentMode TangentMode;
		/// <summary>If either tangent at this key is 'weighted'</summary>
		public ERichCurveTangentWeightMode TangentWeightMode;
		/// <summary>Time at this key</summary>
		public float Time;
		/// <summary>Value at this key</summary>
		public float Value;
		/// <summary>If RCIM_Cubic, the arriving tangent at this key</summary>
		public float ArriveTangent;
		/// <summary>If RCTWM_WeightedArrive or RCTWM_WeightedBoth, the weight of the left tangent</summary>
		public float ArriveTangentWeight;
		/// <summary>If RCIM_Cubic, the leaving tangent at this key</summary>
		public float LeaveTangent;
		/// <summary>If RCTWM_WeightedLeave or RCTWM_WeightedBoth, the weight of the right tangent</summary>
		public float LeaveTangentWeight;
		
	}
	
}
