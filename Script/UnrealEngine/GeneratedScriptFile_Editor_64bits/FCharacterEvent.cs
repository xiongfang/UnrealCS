#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>FCharacterEvent describes a keyboard action where the utf-16 code is given.  Used for OnKeyChar messages</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FCharacterEvent
	{
		
	}
	
}
#endif
#endif
