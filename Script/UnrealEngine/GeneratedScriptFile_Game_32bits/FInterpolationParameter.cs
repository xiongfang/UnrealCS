#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FInterpolationParameter
	{
		[FieldOffset(0)]
		public float InterpolationTime;
		[FieldOffset(4)]
		public EFilterInterpolationType InterpolationType;
		
	}
	
}
#endif
#endif
