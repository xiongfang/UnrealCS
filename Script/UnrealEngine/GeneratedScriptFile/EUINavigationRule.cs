using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EUINavigationRule:byte
	{
		/// <summary>Allow the movement to continue in that direction, seeking the next navigable widget automatically.</summary>
		Escape=0,
		/// <summary>Move to a specific widget.</summary>
		Explicit=1,
		/// <summary>
		/// Wrap movement inside this container, causing the movement to cycle around from the opposite side,
		/// if the navigation attempt would have escaped.
		/// </summary>
		Wrap=2,
		/// <summary>Stops movement in this direction</summary>
		Stop=3,
		/// <summary>Custom navigation handled by user code.</summary>
		Custom=4,
		/// <summary>Invalid Rule</summary>
		Invalid=5,
		EUINavigationRule_MAX=6,
		
	}
	
}
