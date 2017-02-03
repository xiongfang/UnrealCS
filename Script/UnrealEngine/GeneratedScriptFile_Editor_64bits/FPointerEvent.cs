#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FPointerEvent describes a mouse or touch action (e.g. Press, Release, Move, etc).
	/// It is passed to event handlers dealing with pointer-based input.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FPointerEvent
	{
		
	}
	
}
#endif
#endif
