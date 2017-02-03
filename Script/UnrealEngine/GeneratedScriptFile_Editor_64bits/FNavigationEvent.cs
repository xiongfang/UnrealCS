#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FNavigationEvent describes a navigation action (Left, Right, Up, Down)
	/// It is passed to event handlers dealing with navigation.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FNavigationEvent
	{
		
	}
	
}
#endif
#endif
