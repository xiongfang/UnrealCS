#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBoxElement2D
	{
		[FieldOffset(0)]
		public FVector2D Center;
		[FieldOffset(8)]
		public float Width;
		[FieldOffset(12)]
		public float Height;
		[FieldOffset(16)]
		public float Angle;
		
	}
	
}
#endif
#endif
