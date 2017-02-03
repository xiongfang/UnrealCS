#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Helper struct, since UnrealScript doesn't allow arrays of arrays, but
	/// arrays of structs of arrays are okay.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FDelegateArray
	{
		
	}
	
}
#endif
#endif
