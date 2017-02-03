#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FBox
	{
		[FieldOffset(0)]
		public FVector Min;
		[FieldOffset(12)]
		public FVector Max;
		[FieldOffset(24)]
		public byte IsValid;
		
	}
	
}
#endif
#endif
