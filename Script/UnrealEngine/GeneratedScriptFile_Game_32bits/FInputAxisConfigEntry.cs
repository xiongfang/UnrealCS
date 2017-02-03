#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FInputAxisConfigEntry
	{
		[FieldOffset(0)]
		public FName AxisKeyName;
		[FieldOffset(8)]
		public FInputAxisProperties AxisProperties;
		
	}
	
}
#endif
#endif
