using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum used to indicate desired behavior for MoveComponentTo latent function.</summary>
	public enum EMoveComponentAction:byte
	{
		/// <summary>Move to target over specified time.</summary>
		Move=0,
		/// <summary>If currently moving, stop.</summary>
		Stop=1,
		/// <summary>If currently moving, return to where you started, over the time elapsed so far.</summary>
		Return=2,
		EMoveComponentAction_MAX=3,
		
	}
	
}
