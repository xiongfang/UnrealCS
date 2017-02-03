#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1000)]
	public partial struct FTViewTarget
	{
		[FieldOffset(8)]
		public FMinimalViewInfo POV;
		
	}
	
}
#endif
#endif
