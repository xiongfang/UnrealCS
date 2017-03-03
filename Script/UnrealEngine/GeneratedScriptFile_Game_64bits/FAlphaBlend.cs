#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FAlphaBlend
	{
		[FieldOffset(16)]
		public float BlendTime;
		
	}
	
}
#endif
#endif
