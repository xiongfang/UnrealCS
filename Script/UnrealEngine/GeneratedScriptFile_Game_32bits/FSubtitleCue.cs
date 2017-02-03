#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FSubtitleCue
	{
		[FieldOffset(0)]
		public FText Text;
		[FieldOffset(12)]
		public float Time;
		
	}
	
}
#endif
#endif
