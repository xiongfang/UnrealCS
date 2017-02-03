#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents a mapping of key handles to key index that may be serialized</summary>
	[StructLayout(LayoutKind.Explicit,Size=80)]
	public partial struct FKeyHandleMap
	{
		
	}
	
}
#endif
#endif
