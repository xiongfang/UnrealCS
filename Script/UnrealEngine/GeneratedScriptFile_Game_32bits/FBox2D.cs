#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBox2D
	{
		[FieldOffset(0)]
		public FVector2D Min;
		[FieldOffset(8)]
		public FVector2D Max;
		[FieldOffset(16)]
		public byte IsValid;
		
	}
	
}
#endif
#endif
