using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Presets of values used in considering when put this body to sleep.</summary>
	public enum ESleepFamily:byte
	{
		/// <summary>Engine defaults.</summary>
		Normal=0,
		/// <summary>A family of values with a lower sleep threshold; good for slower pendulum-like physics.</summary>
		Sensitive=1,
		/// <summary>Specify your own sleep threshold multiplier</summary>
		Custom=2,
		ESleepFamily_MAX=3,
		
	}
	
}
