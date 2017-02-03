#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FKeyEvent describes a key action (keyboard/controller key/button pressed or released.)
	/// It is passed to event handlers dealing with key input.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FKeyEvent
	{
		
	}
	
}
#endif
#endif
