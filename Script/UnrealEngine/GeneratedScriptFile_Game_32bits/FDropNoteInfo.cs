#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FDropNoteInfo
	{
		[FieldOffset(0)]
		public FVector Location;
		[FieldOffset(12)]
		public FRotator Rotation;
		[FieldOffset(24)]
		public FString Comment;
		
	}
	
}
#endif
#endif
