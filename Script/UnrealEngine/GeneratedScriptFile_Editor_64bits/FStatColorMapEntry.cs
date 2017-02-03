#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FStatColorMapEntry
	{
		[FieldOffset(0)]
		public float In;
		[FieldOffset(4)]
		public FColor Out;
		
	}
	
}
#endif
#endif
