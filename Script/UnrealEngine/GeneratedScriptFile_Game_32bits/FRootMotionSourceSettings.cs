#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1)]
	public partial struct FRootMotionSourceSettings
	{
		[FieldOffset(0)]
		public byte Flags;
		
	}
	
}
#endif
#endif
