using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates the valid types of range bounds.</summary>
	public enum ERangeBoundTypes:byte
	{
		/// <summary>The range excludes the bound.</summary>
		Exclusive=0,
		/// <summary>The range includes the bound.</summary>
		Inclusive=1,
		/// <summary>The bound is open.</summary>
		Open=2,
		ERangeBoundTypes_MAX=3,
		
	}
	
}
