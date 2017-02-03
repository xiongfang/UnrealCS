#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FROscillator
	{
		[FieldOffset(0)]
		public FFOscillator Pitch;
		[FieldOffset(12)]
		public FFOscillator Yaw;
		[FieldOffset(24)]
		public FFOscillator Roll;
		
	}
	
}
#endif
#endif
