#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FAlphaBlend
	{
		[FieldOffset(8)]
		public float BlendTime;
		
	}
	
}
#endif
#endif
