#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FNetViewer
	{
		[FieldOffset(24)]
		public FVector ViewLocation;
		[FieldOffset(36)]
		public FVector ViewDir;
		
	}
	
}
#endif
#endif
