#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FMotionEvent describes a touch pad action (press, move, lift)
	/// It is passed to event handlers dealing with touch input.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FMotionEvent
	{
		
	}
	
}
#endif
#endif
