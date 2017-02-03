#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FGenericStruct
	{
		[FieldOffset(0)]
		public int Data;
		
	}
	
}
#endif
#endif
