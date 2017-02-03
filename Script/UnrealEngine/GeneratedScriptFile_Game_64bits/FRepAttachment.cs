#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FRepAttachment
	{
		[FieldOffset(8)]
		public FVector_NetQuantize100 LocationOffset;
		[FieldOffset(20)]
		public FVector_NetQuantize100 RelativeScale3D;
		[FieldOffset(32)]
		public FRotator RotationOffset;
		[FieldOffset(48)]
		public FName AttachSocket;
		
	}
	
}
#endif
#endif
