#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantize100
	/// 2 decimal place of precision.
	/// Up to 30 bits per component.
	/// Valid range: 2^30 / 100 = +/- 10,737,418.24
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVector_NetQuantize100
	{
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		
	}
	
}
#endif
#endif
