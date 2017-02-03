#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FNavCollisionBox
	{
		[FieldOffset(0)]
		public FVector Offset;
		[FieldOffset(12)]
		public FVector Extent;
		
	}
	
}
#endif
#endif
