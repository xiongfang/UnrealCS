using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used by rendering project settings.</summary>
	public enum EAntiAliasingMethod:byte
	{
		AAM_None=0,
		AAM_FXAA=1,
		AAM_TemporalAA=2,
		/// <summary>Only supported with forward shading.  MSAA sample count is controlled by r.MSAACount.</summary>
		AAM_MSAA=3,
		AAM_MAX=4,
		
	}
	
}
