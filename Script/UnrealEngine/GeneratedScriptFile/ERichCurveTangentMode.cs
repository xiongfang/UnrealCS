using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>If using RCIM_Cubic, this enum describes how the tangents should be controlled in editor.</summary>
	public enum ERichCurveTangentMode:byte
	{
		RCTM_Auto=0,
		RCTM_User=1,
		RCTM_Break=2,
		RCTM_None=3,
		RCTM_MAX=4,
		
	}
	
}
