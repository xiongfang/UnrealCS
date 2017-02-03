#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=948)]
	public partial struct FTViewTarget
	{
		[FieldOffset(4)]
		public FMinimalViewInfo POV;
		
	}
	
}
#endif
#endif
