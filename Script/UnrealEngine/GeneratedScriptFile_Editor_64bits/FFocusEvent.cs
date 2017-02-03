#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FFocusEvent is used when notifying widgets about keyboard focus changes
	/// It is passed to event handlers dealing with keyboard focus
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FFocusEvent
	{
		
	}
	
}
#endif
#endif
