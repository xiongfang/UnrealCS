using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used to determine how we should handle mouse wheel input events when someone scrolls.</summary>
	public enum EConsumeMouseWheel:byte
	{
		/// <summary>Only consume the mouse wheel event when we actually scroll some amount.</summary>
		WhenScrollingPossible=0,
		/// <summary>Always consume mouse wheel event even if we don't scroll at all.</summary>
		Always=1,
		/// <summary>Never consume the mouse wheel</summary>
		Never=2,
		EConsumeMouseWheel_MAX=3,
		
	}
	
}
