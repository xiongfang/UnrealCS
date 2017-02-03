#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FRigTransformConstraint
	{
		[FieldOffset(0)]
		public EConstraintTransform TranformType;
		[FieldOffset(8)]
		public FName ParentSpace;
		[FieldOffset(16)]
		public float Weight;
		
	}
	
}
#endif
#endif
