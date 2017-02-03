#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FNavGraphNode
	{
		/// <summary>Who's this node referring to? This will most commonly point to an actor or a component</summary>
		
	}
	
}
#endif
#endif
