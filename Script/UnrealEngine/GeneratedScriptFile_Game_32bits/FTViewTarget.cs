#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1296)]
	public partial struct FTViewTarget
	{
		[FieldOffset(16)]
		public FMinimalViewInfo POV;
		
	}
	
}
#endif
#endif
