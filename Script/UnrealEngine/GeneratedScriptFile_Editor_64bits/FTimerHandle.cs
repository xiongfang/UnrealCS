#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Unique handle that can be used to distinguish timers that have identical delegates.</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FTimerHandle
	{
		[FieldOffset(0)]
		public ulong Handle;
		
	}
	
}
#endif
#endif
