using System;
namespace UnrealEngine
{
	public partial struct FInterpolationParameter
	{
		/// <summary>Interpolation Time for input, when it gets input, it will use this time to interpolate to target, used for smoother interpolation.</summary>
		public float InterpolationTime;
		/// <summary>Type of interpolation used for filtering the input value to decide how to get to target.</summary>
		public EFilterInterpolationType InterpolationType;
		
	}
	
}
