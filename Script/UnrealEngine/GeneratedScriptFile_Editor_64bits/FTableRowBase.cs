#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Base class for all table row structs to inherit from.</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FTableRowBase
	{
		
	}
	
}
#endif
#endif
