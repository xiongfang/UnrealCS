using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used by FPostProcessSettings Depth of Fields</summary>
	public enum EDepthOfFieldMethod:byte
	{
		DOFM_BokehDOF=0,
		DOFM_Gaussian=1,
		DOFM_CircleDOF=2,
		DOFM_MAX=3,
		
	}
	
}
