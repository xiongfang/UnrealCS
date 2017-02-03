using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Indicates how animation should be evaluated between keys.</summary>
	public enum EAnimInterpolationType:byte
	{
		/// <summary>Linear interpolation when looking up values between keys.</summary>
		Linear=0,
		/// <summary>Step interpolation when looking up values between keys.</summary>
		Step=1,
		EAnimInterpolationType_MAX=2,
		
	}
	
}
