#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantize10
	/// 1 decimal place of precision.
	/// Up to 24 bits per component.
	/// Valid range: 2^24 / 10 = +/- 1,677,721.6
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVector_NetQuantize10
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
