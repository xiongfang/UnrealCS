#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FInputAxisKeyMapping
	{
		[FieldOffset(0)]
		public FName AxisName;
		[FieldOffset(8)]
		public FKey Key;
		[FieldOffset(32)]
		public float Scale;
		
	}
	
}
#endif
#endif
