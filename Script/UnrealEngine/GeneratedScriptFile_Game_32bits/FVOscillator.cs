#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FVOscillator
	{
		[FieldOffset(0)]
		public FFOscillator X;
		[FieldOffset(12)]
		public FFOscillator Y;
		[FieldOffset(24)]
		public FFOscillator Z;
		
	}
	
}
#endif
#endif
