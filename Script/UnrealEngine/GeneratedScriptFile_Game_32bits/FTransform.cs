#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FTransform
	{
		[FieldOffset(0)]
		public FQuat Rotation;
		[FieldOffset(16)]
		public FVector Translation;
		[FieldOffset(32)]
		public FVector Scale3D;
		
	}
	
}
#endif
#endif
