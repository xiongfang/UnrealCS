#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FKSphereElem
	{
		[FieldOffset(32)]
		public FMatrix TM;
		[FieldOffset(96)]
		public FVector Center;
		[FieldOffset(108)]
		public float Radius;
		
	}
	
}
#endif
#endif
