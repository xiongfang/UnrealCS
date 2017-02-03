#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FCameraPreviewInfo
	{
		[FieldOffset(8)]
		public FVector Location;
		[FieldOffset(20)]
		public FRotator Rotation;
		
	}
	
}
#endif
#endif
