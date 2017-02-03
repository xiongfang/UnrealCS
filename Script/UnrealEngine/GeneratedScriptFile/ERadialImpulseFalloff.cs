using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum for controlling the falloff of strength of a radial impulse as a function of distance from Origin.</summary>
	public enum ERadialImpulseFalloff:byte
	{
		/// <summary>Impulse is a constant strength, up to the limit of its range.</summary>
		RIF_Constant=0,
		/// <summary>Impulse should get linearly weaker the further from origin.</summary>
		RIF_Linear=1,
		RIF_MAX=2,
		
	}
	
}
