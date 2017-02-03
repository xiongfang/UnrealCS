#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FKSphereElem
	{
		[FieldOffset(16)]
		public FMatrix TM;
		[FieldOffset(80)]
		public FVector Center;
		[FieldOffset(92)]
		public float Radius;
		
	}
	
}
#endif
#endif
