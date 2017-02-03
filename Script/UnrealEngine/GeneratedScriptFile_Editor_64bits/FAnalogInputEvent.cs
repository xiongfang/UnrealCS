#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FAnalogEvent describes a analog key value.
	/// It is passed to event handlers dealing with analog keys.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FAnalogInputEvent
	{
		
	}
	
}
#endif
#endif
