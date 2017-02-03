#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FNavCollisionCylinder
	{
		[FieldOffset(0)]
		public FVector Offset;
		[FieldOffset(12)]
		public float Radius;
		[FieldOffset(16)]
		public float Height;
		
	}
	
}
#endif
#endif
