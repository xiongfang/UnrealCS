using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESettingsLockedAxis:byte
	{
		/// <summary>No axis is locked.</summary>
		None=0,
		/// <summary>Lock movement along the x-axis.</summary>
		X=1,
		/// <summary>Lock movement along the y-axis.</summary>
		Y=2,
		/// <summary>Lock movement along the z-axis.</summary>
		Z=3,
		/// <summary>Used for backwards compatibility. Indicates that we've updated into the new struct.</summary>
		Invalid=4,
		ESettingsLockedAxis_MAX=5,
		
	}
	
}
