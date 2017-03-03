#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FRigTransformConstraint
	{
		[FieldOffset(0)]
		public EConstraintTransform TranformType;
		[FieldOffset(4)]
		public FName ParentSpace;
		[FieldOffset(12)]
		public float Weight;
		
	}
	
}
#endif
#endif
