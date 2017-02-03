#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Handles attachment replication to clients. Movement replication will not happen while AttachParent is non-nullptr</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FRepAttachment
	{
		[FieldOffset(8)]
		public FVector_NetQuantize100 LocationOffset;
		[FieldOffset(20)]
		public FVector_NetQuantize100 RelativeScale3D;
		[FieldOffset(32)]
		public FRotator RotationOffset;
		[FieldOffset(44)]
		public FName AttachSocket;
		
	}
	
}
#endif
#endif
