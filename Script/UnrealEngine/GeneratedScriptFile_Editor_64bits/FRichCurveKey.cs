#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>One key in a rich, editable float curve</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FRichCurveKey
	{
		/// <summary>Interpolation mode between this key and the next</summary>
		[FieldOffset(0)]
		public ERichCurveInterpMode InterpMode;
		/// <summary>Mode for tangents at this key</summary>
		[FieldOffset(1)]
		public ERichCurveTangentMode TangentMode;
		/// <summary>If either tangent at this key is 'weighted'</summary>
		[FieldOffset(2)]
		public ERichCurveTangentWeightMode TangentWeightMode;
		/// <summary>Time at this key</summary>
		[FieldOffset(4)]
		public float Time;
		/// <summary>Value at this key</summary>
		[FieldOffset(8)]
		public float Value;
		/// <summary>If RCIM_Cubic, the arriving tangent at this key</summary>
		[FieldOffset(12)]
		public float ArriveTangent;
		/// <summary>If RCTWM_WeightedArrive or RCTWM_WeightedBoth, the weight of the left tangent</summary>
		[FieldOffset(16)]
		public float ArriveTangentWeight;
		/// <summary>If RCIM_Cubic, the leaving tangent at this key</summary>
		[FieldOffset(20)]
		public float LeaveTangent;
		/// <summary>If RCTWM_WeightedLeave or RCTWM_WeightedBoth, the weight of the right tangent</summary>
		[FieldOffset(24)]
		public float LeaveTangentWeight;
		
	}
	
}
#endif
#endif
