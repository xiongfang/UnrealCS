#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FRotator
	{
		[FieldOffset(0)]
		public float Pitch;
		[FieldOffset(4)]
		public float Yaw;
		[FieldOffset(8)]
		public float Roll;
		
	}
	
}
#endif
#endif
