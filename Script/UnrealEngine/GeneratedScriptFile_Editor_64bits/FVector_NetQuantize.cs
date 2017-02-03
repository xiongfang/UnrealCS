#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantize
	/// 0 decimal place of precision.
	/// Up to 20 bits per component.
	/// Valid range: 2^20 = +/- 1,048,576
	/// Note: this is the historical UE format for vector net serialization
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVector_NetQuantize
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
