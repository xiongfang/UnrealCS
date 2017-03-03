#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FInterpolationParameter
	{
		/// <summary>Interpolation Time for input, when it gets input, it will use this time to interpolate to target, used for smoother interpolation.</summary>
		[FieldOffset(0)]
		public float InterpolationTime;
		/// <summary>Type of interpolation used for filtering the input value to decide how to get to target.</summary>
		[FieldOffset(4)]
		public EFilterInterpolationType InterpolationType;
		
	}
	
}
#endif
#endif
