#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Wrapper for opaque type FUniqueNetId
	/// Makes sure that the opaque aspects of FUniqueNetId are properly handled/serialized
	/// over network RPC and actor replication
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FUniqueNetIdRepl
	{
		
	}
	
}
#endif
#endif
