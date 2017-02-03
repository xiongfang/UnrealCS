using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>LINEAR DOF</summary>
	public enum ELinearConstraintMotion:byte
	{
		/// <summary>No constraint against this axis.</summary>
		LCM_Free=0,
		/// <summary>Limited freedom along this axis.</summary>
		LCM_Limited=1,
		/// <summary>Fully constraint against this axis.</summary>
		LCM_Locked=2,
		LCM_MAX=3,
		
	}
	
}
