using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used by FPostProcessSettings Anti-aliasings</summary>
	public enum EAntiAliasingMethod:byte
	{
		AAM_None=0,
		AAM_FXAA=1,
		AAM_TemporalAA=2,
		AAM_MAX=3,
		
	}
	
}
