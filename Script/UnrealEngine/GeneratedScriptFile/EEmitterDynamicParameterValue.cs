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
		/// <summary>AutoSet - ignore values set in the distribution, another module will handle this data</summary>
		EDPV_AutoSet=1,
		/// <summary>VelocityX - pass the particle velocity along the X-axis thru</summary>
		EDPV_VelocityX=2,
		/// <summary>VelocityY - pass the particle velocity along the Y-axis thru</summary>
		EDPV_VelocityY=3,
		/// <summary>VelocityZ - pass the particle velocity along the Z-axis thru</summary>
		EDPV_VelocityZ=4,
		/// <summary>VelocityMag - pass the particle velocity magnitude thru</summary>
		EDPV_VelocityMag=5,
		EDPV_MAX=6,
		
	}
	
}
