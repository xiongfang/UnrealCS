using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum to indicate if a node has advanced-display-pins, and whether they are shown.</summary>
	public enum ENodeAdvancedPins:byte
	{
		/// <summary>No advanced pins.</summary>
		NoPins=0,
		/// <summary>There are some advanced pins, and they are shown.</summary>
		Shown=1,
		/// <summary>There are some advanced pins, and they are hidden.</summary>
		Hidden=2,
		ENodeAdvancedPins_MAX=3,
		
	}
	
}
