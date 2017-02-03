#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FPhysicalSurfaceName
	{
		[FieldOffset(0)]
		public EPhysicalSurface Type;
		[FieldOffset(8)]
		public FName Name;
		
	}
	
}
#endif
#endif
