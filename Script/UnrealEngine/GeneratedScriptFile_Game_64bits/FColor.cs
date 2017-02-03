#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FColor
	{
		[FieldOffset(0)]
		public byte B;
		[FieldOffset(1)]
		public byte G;
		[FieldOffset(2)]
		public byte R;
		[FieldOffset(3)]
		public byte A;
		
	}
	
}
#endif
#endif
