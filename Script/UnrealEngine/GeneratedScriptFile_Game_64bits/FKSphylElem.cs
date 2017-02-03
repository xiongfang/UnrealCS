#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FKSphylElem
	{
		[FieldOffset(32)]
		public FMatrix TM;
		[FieldOffset(96)]
		public FVector Center;
		[FieldOffset(112)]
		public FQuat Orientation;
		[FieldOffset(128)]
		public float Radius;
		[FieldOffset(132)]
		public float Length;
		
	}
	
}
#endif
#endif
