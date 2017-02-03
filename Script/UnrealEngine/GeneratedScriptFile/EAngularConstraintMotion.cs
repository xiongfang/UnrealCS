using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>ANGULAR DOF</summary>
	public enum EAngularConstraintMotion:byte
	{
		/// <summary>No constraint against this axis.</summary>
		ACM_Free=0,
		/// <summary>Limited freedom along this axis.</summary>
		ACM_Limited=1,
		/// <summary>Fully constraint against this axis.</summary>
		ACM_Locked=2,
		ACM_MAX=3,
		
	}
	
}
