#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FKSphylElem
	{
		[FieldOffset(16)]
		public FMatrix TM;
		[FieldOffset(80)]
		public FVector Center;
		[FieldOffset(96)]
		public FQuat Orientation;
		[FieldOffset(112)]
		public float Radius;
		[FieldOffset(116)]
		public float Length;
		
	}
	
}
#endif
#endif
