#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FNetViewer
	{
		[FieldOffset(12)]
		public FVector ViewLocation;
		[FieldOffset(24)]
		public FVector ViewDir;
		
	}
	
}
#endif
#endif
