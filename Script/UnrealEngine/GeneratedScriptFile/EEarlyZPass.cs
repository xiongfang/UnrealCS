using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates available options for early Z-passes.</summary>
	public enum EEarlyZPass:byte
	{
		None=0,
		OpaqueOnly=1,
		OpaqueAndMasked=2,
		/// <summary>Let the engine decide what to render in the early Z pass based on the features being used.</summary>
		Auto=3,
		EEarlyZPass_MAX=4,
		
	}
	
}
