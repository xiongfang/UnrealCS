using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// EmitterDynamicParameterValue
	/// Enumeration indicating the way a dynamic parameter should be set.
	/// </summary>
	public enum EEmitterDynamicParameterValue:byte
	{
		/// <summary>UserSet - use the user set values in the distribution (the default)</summary>
		EDPV_UserSet=0,
		/// <summary>VelocityX - pass the particle velocity along the X-axis thru</summary>
		EDPV_VelocityX=1,
		/// <summary>VelocityY - pass the particle velocity along the Y-axis thru</summary>
		EDPV_VelocityY=2,
		/// <summary>VelocityZ - pass the particle velocity along the Z-axis thru</summary>
		EDPV_VelocityZ=3,
		/// <summary>VelocityMag - pass the particle velocity magnitude thru</summary>
		EDPV_VelocityMag=4,
		EDPV_MAX=5,
		
	}
	
}
