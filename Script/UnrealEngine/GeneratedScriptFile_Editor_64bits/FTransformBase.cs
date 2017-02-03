#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FTransformBase
	{
		[FieldOffset(0)]
		public FName Node;
		[FieldOffset(16)]
		public FTransformBaseConstraint Constraints;
		
	}
	
}
#endif
#endif
