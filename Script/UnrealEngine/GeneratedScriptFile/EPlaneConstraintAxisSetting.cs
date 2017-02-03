using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Setting that controls behavior when movement is restricted to a 2D plane defined by a specific axis/normal,
	/// so that movement along the locked axis is not be possible.
	/// </summary>
	public enum EPlaneConstraintAxisSetting:byte
	{
		/// <summary>Lock movement to a user-defined axis.</summary>
		Custom=0,
		/// <summary>Lock movement in the X axis.</summary>
		X=1,
		/// <summary>Lock movement in the Y axis.</summary>
		Y=2,
		/// <summary>Lock movement in the Z axis.</summary>
		Z=3,
		/// <summary>Use the global physics project setting.</summary>
		UseGlobalPhysicsSetting=4,
		EPlaneConstraintAxisSetting_MAX=5,
		
	}
	
}
