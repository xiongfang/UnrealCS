#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FRigTransformConstraint
	{
		/// <summary>EditAnywhere, Category="FTransformBaseConstraint"</summary>
		[FieldOffset(0)]
		public EConstraintTransform TranformType;
		/// <summary>Parent space that are define *</summary>
		[FieldOffset(4)]
		public FName ParentSpace;
		/// <summary>EditAnywhere, Category="FTransformBaseConstraint"</summary>
		[FieldOffset(16)]
		public float Weight;
		
	}
	
}
#endif
#endif
