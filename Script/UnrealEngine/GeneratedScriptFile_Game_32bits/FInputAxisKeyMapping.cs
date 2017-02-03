#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FInputAxisKeyMapping
	{
		[FieldOffset(0)]
		public FName AxisName;
		[FieldOffset(8)]
		public FKey Key;
		[FieldOffset(24)]
		public float Scale;
		
	}
	
}
#endif
#endif
