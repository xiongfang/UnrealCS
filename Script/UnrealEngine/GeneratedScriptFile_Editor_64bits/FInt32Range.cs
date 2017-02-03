#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An int32 range</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FInt32Range
	{
		[FieldOffset(0)]
		public FInt32RangeBound LowerBound;
		[FieldOffset(8)]
		public FInt32RangeBound UpperBound;
		
	}
	
}
#endif
#endif
