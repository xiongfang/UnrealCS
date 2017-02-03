#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FPackedNormal
	{
		[FieldOffset(0)]
		public byte X;
		[FieldOffset(1)]
		public byte Y;
		[FieldOffset(2)]
		public byte Z;
		[FieldOffset(3)]
		public byte W;
		
	}
	
}
#endif
#endif
