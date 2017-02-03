#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FMatrix
	{
		[FieldOffset(0)]
		public FPlane XPlane;
		[FieldOffset(16)]
		public FPlane YPlane;
		[FieldOffset(32)]
		public FPlane ZPlane;
		[FieldOffset(48)]
		public FPlane WPlane;
		
	}
	
}
#endif
#endif
