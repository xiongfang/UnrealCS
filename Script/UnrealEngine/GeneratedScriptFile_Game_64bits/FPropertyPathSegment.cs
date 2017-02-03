#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FPropertyPathSegment
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(8)]
		public int ArrayIndex;
		
	}
	
}
#endif
#endif
