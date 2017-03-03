#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FRepAttachment
	{
		[FieldOffset(4)]
		public FVector_NetQuantize100 LocationOffset;
		[FieldOffset(16)]
		public FVector_NetQuantize100 RelativeScale3D;
		[FieldOffset(28)]
		public FRotator RotationOffset;
		[FieldOffset(40)]
		public FName AttachSocket;
		
	}
	
}
#endif
#endif
