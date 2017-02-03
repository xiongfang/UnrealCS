using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>used by FPostProcessSettings Anti-aliasing</summary>
	public enum EAntiAliasingMethodUI:byte
	{
		AAM_None=0,
		AAM_FXAA=1,
		AAM_TemporalAA=2,
		AAM_MAX=3,
		
	}
	
}
