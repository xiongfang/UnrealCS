using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Traveling from server to server.</summary>
	public enum ETravelType:byte
	{
		/// <summary>Absolute URL.</summary>
		TRAVEL_Absolute=0,
		/// <summary>Partial (carry name, reset server).</summary>
		TRAVEL_Partial=1,
		/// <summary>Relative URL.</summary>
		TRAVEL_Relative=2,
		TRAVEL_MAX=3,
		
	}
	
}
