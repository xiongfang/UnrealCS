using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Method of interpolation between this key and the next.</summary>
	public enum ERichCurveInterpMode:byte
	{
		RCIM_Linear=0,
		RCIM_Constant=1,
		RCIM_Cubic=2,
		RCIM_None=3,
		RCIM_MAX=4,
		
	}
	
}
