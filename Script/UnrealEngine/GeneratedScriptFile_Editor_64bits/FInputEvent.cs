#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for all mouse and keyevents.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FInputEvent
	{
		
	}
	
}
#endif
#endif
