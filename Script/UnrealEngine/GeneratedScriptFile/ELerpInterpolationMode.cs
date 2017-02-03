using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Different methods for interpolating rotation between transforms</summary>
	public enum ELerpInterpolationMode:byte
	{
		/// <summary>Shortest Path or Quaternion interpolation for the rotation.</summary>
		QuatInterp=0,
		/// <summary>Rotor or Euler Angle interpolation.</summary>
		EulerInterp=1,
		/// <summary>Dual quaternion interpolation, follows helix or screw-motion path between keyframes.</summary>
		DualQuatInterp=2,
		ELerpInterpolationMode_MAX=3,
		
	}
	
}
