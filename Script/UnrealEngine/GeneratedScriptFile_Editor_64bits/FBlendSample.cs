#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Sample data</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBlendSample
	{
		/// <summary>blend 0->x, blend 1->y, blend 2->z</summary>
		[FieldOffset(8)]
		public FVector SampleValue;
		
	}
	
}
#endif
#endif
