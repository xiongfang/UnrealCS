#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FTransformBase
	{
		[FieldOffset(0)]
		public FName Node;
		[FieldOffset(8)]
		public FTransformBaseConstraint Constraints;
		
	}
	
}
#endif
#endif
