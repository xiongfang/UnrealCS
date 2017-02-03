#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A float range</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FFloatRange
	{
		[FieldOffset(0)]
		public FFloatRangeBound LowerBound;
		[FieldOffset(8)]
		public FFloatRangeBound UpperBound;
		
	}
	
}
#endif
#endif
