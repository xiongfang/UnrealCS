#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A float range bound</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FFloatRangeBound
	{
		[FieldOffset(0)]
		public ERangeBoundTypes Type;
		[FieldOffset(4)]
		public float Value;
		
	}
	
}
#endif
#endif
